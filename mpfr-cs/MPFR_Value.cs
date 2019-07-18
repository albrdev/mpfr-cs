using System;
using Math.Gmp.Native;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR_Value : IDisposable
    {
        private static int m_OutputPrecision = -1;

        private readonly mpfr_t m_Value = new mpfr_t();
        private bool m_IsDisposed = false;

        private bool BoolValue { get => mpfr_lib.mpfr_regular_p(m_Value) != 0 || mpfr_lib.mpfr_inf_p(m_Value) != 0; }

        public static mpfr_prec_t MinPrecision { get { return mpfr_lib.MPFR_PREC_MIN; } }
        public static mpfr_prec_t MaxPrecision { get { return mpfr_lib.MPFR_PREC_MAX; } }

        public static mpfr_prec_t DefaultPrecision
        {
            get => mpfr_lib.mpfr_get_default_prec();
            set => mpfr_lib.mpfr_set_default_prec(value);
        }

        public static mpfr_rnd_t RoundingMode { get; set; } = default;

        public static int OutputPrecision
        {
            get => m_OutputPrecision >= 0 ? m_OutputPrecision : (int)System.Math.Ceiling((uint)DefaultPrecision * System.Math.Log10(2));
            set => m_OutputPrecision = value;
        }

        public static GMP_RandState RandomState { get; set; } = new GMP_RandState(Environment.TickCount);

        public mpfr_prec_t Precision
        {
            get => m_Value._mpfr_prec;
            set => mpfr_lib.mpfr_set_prec_raw(m_Value, value);
        }

        public static MPFR_Value Zero { get; } = new MPFR_Value(0);
        public static MPFR_Value NegativeOne { get; } = new MPFR_Value(-1);
        public static MPFR_Value PositiveOne { get; } = new MPFR_Value(1);
        public static MPFR_Value NegativeInfinity { get; } = new MPFR_Value(-1D / 0D);
        public static MPFR_Value PositiveInfinity { get; } = new MPFR_Value(1D / 0D);
        public static MPFR_Value NaN { get; } = new MPFR_Value(/*0D / 0D*/);

        public static MPFR_Value Pi { get; } = MPFR_Pi(MPFR_Value.DefaultPrecision);
        public static MPFR_Value Euler { get; } = MPFR_Euler(MPFR_Value.DefaultPrecision);
        public static MPFR_Value Catalan { get; } = MPFR_Catalan(MPFR_Value.DefaultPrecision);
        public static MPFR_Value LN2 { get; } = MPFR_LN2(MPFR_Value.DefaultPrecision);

        public bool IsNegative => mpfr_lib.mpfr_sgn(m_Value) < 0;
        public bool IsPositive => mpfr_lib.mpfr_sgn(m_Value) > 0;
        public bool IsInfinity => mpfr_lib.mpfr_inf_p(m_Value) != 0;
        public bool IsNegativeInfinity => IsInfinity && IsNegative;
        public bool IsPositiveInfinity => IsInfinity && IsPositive;

        public string ToString(mpfr_rnd_t roundingMode, int outputPrecision)
        {
            ptr<char_ptr> buffer = new ptr<char_ptr>();

            mpfr_lib.mpfr_asprintf(buffer, "%.*R*g", outputPrecision, roundingMode, m_Value);
            string result = buffer.Value.ToString();

            gmp_lib.free(buffer.Value);
            return result;
        }

        public override string ToString()
        {
            return ToString(MPFR_Value.RoundingMode, MPFR_Value.OutputPrecision);
        }

        public static MPFR_Value MPFR_Pi(mpfr_prec_t precision)
        {
            MPFR_Value result = new MPFR_Value(precision);
            mpfr_lib.mpfr_const_pi(result.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value MPFR_Euler(mpfr_prec_t precision)
        {
            MPFR_Value result = new MPFR_Value(precision);
            mpfr_lib.mpfr_const_euler(result.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value MPFR_Catalan(mpfr_prec_t precision)
        {
            MPFR_Value result = new MPFR_Value(precision);
            mpfr_lib.mpfr_const_catalan(result.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value MPFR_LN2(mpfr_prec_t precision)
        {
            MPFR_Value result = new MPFR_Value(precision);
            mpfr_lib.mpfr_const_log2(result.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public MPFR_Value(MPFR_Value other) : this(other.m_Value) { }

        public MPFR_Value(mpfr_t value) : this(value._mpfr_prec, value) { }

        public MPFR_Value(mpfr_prec_t precision, mpfr_t value)
        {
            mpfr_lib.mpfr_init2(m_Value, precision);
            mpfr_lib.mpfr_set(m_Value, value, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(int value)
        {
            mpfr_lib.mpfr_init_set_si(m_Value, value, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(mpfr_prec_t precision, int value)
        {
            mpfr_lib.mpfr_init2(m_Value, precision);
            mpfr_lib.mpfr_set_si(m_Value, value, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(uint value)
        {
            mpfr_lib.mpfr_init_set_ui(m_Value, value, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(mpfr_prec_t precision, uint value)
        {
            mpfr_lib.mpfr_init2(m_Value, precision);
            mpfr_lib.mpfr_set_ui(m_Value, value, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(double value)
        {
            mpfr_lib.mpfr_init_set_d(m_Value, value, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(mpfr_prec_t precision, double value)
        {
            mpfr_lib.mpfr_init2(m_Value, precision);
            mpfr_lib.mpfr_set_d(m_Value, value, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(string value, int radix = 10)
        {
            mpfr_lib.mpfr_init_set_str(m_Value, value, radix, MPFR_Value.RoundingMode);
        }

        public MPFR_Value(mpfr_prec_t precision, string value, int radix = 10)
        {
            mpfr_lib.mpfr_init2(m_Value, precision);
            char_ptr tmp = new char_ptr(value);
            mpfr_lib.mpfr_set_str(m_Value, tmp, radix, MPFR_Value.RoundingMode);
            gmp_lib.free(tmp);
        }

        public MPFR_Value(mpfr_prec_t precision)
        {
            mpfr_lib.mpfr_init2(m_Value, precision);
        }

        public MPFR_Value()
        {
            mpfr_lib.mpfr_init(m_Value);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(m_IsDisposed)
                return;

            mpfr_lib.mpfr_clear(m_Value);
            m_IsDisposed = true;
        }

        ~MPFR_Value()
        {
            Dispose(false);
        }
    }
}
