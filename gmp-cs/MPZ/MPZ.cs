using System;

namespace Math.Gmp.Native
{
    public sealed partial class MPZ : IDisposable
    {
        internal mpz_t Value { get; set; } = new mpz_t();
        private bool m_IsDisposed = false;

        public static int OutputBase { get; set; } = 10;

        public static MPZ Zero { get; } = new MPZ(0);
        public static MPZ NegativeOne { get; } = new MPZ(-1);
        public static MPZ PositiveOne { get; } = new MPZ(1);

        private bool BoolValue { get => gmp_lib.mpz_sgn(Value) != 0; }

        public string ToString(int radix)
        {
            char_ptr tmp = gmp_lib.mpz_get_str(char_ptr.Zero, radix, Value);
            string result = tmp.ToString();
            gmp_lib.free(tmp);
            return result;
        }

        public override string ToString()
        {
            return ToString(OutputBase);
        }

        public MPZ()
        {
            gmp_lib.mpz_init(Value);
        }

        public MPZ(mp_bitcnt_t precision)
        {
            gmp_lib.mpz_init2(Value, precision);
        }

        public MPZ(MPZ other) : this(other.Value) { }

        public MPZ(mpz_t value)
        {
            gmp_lib.mpz_init_set(Value, value);
        }

        public MPZ(int value)
        {
            gmp_lib.mpz_init_set_si(Value, value);
        }

        public MPZ(uint value)
        {
            gmp_lib.mpz_init_set_ui(Value, value);
        }

        public MPZ(double value)
        {
            gmp_lib.mpz_init_set_d(Value, value);
        }

        public MPZ(string value, int radix = 10)
        {
            char_ptr tmp = new char_ptr(value);
            gmp_lib.mpz_init_set_str(Value, tmp, radix);
            gmp_lib.free(tmp);
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

            gmp_lib.mpz_clear(Value);
            m_IsDisposed = true;
        }

        ~MPZ()
        {
            Dispose(false);
        }
    }
}
