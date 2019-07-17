using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR_Value
    {
        public static MPFR_Value Trunc(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_trunc(result.m_Value, value.m_Value);
            return result;
        }

        public static MPFR_Value Abs(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_abs(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Neg(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_neg(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Min(params MPFR_Value[] values)
        {
            if(values.Length == 0)
                return new MPFR_Value(MPFR_Value.NaN);

            MPFR_Value result = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                if(values[i] < result)
                {
                    result = values[i];
                }
            }

            return new MPFR_Value(result);
        }

        public static MPFR_Value Max(params MPFR_Value[] values)
        {
            if(values.Length == 0)
                return new MPFR_Value(MPFR_Value.NaN);

            MPFR_Value result = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                if(values[i] > result)
                {
                    result = values[i];
                }
            }

            return new MPFR_Value(result);
        }

        public static MPFR_Value Mean(params MPFR_Value[] values)
        {
            MPFR_Value result = new MPFR_Value(0);

            foreach(var value in values)
            {
                mpfr_lib.mpfr_add(result.m_Value, result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            }

            mpfr_lib.mpfr_div_si(result.m_Value, result.m_Value, values.Length, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Pow(MPFR_Value a, MPFR_Value b)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_pow(result.m_Value, a.m_Value, b.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Sqr(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sqr(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Root(MPFR_Value a, MPFR_Value b)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init(tmpValue);

            mpfr_lib.mpfr_si_div(tmpValue, 1, b.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_pow(result.m_Value, a.m_Value, tmpValue, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR_Value Sqrt(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sqrt(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Cbrt(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_cbrt(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Log(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_log(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Log2(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_log2(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Log10(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_log10(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value NthLog(MPFR_Value a, MPFR_Value b)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue1 = new mpfr_t();
            mpfr_t tmpValue2 = new mpfr_t();
            mpfr_lib.mpfr_inits(tmpValue1, tmpValue2);

            mpfr_lib.mpfr_log(tmpValue1, a.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_log(tmpValue2, b.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_div(result.m_Value, a, b, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clears(tmpValue1, tmpValue2);
            return result;
        }

        public static MPFR_Value Sin(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sin(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Cos(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_cos(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Tan(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_tan(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Asin(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_asin(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Acos(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_acos(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Atan(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_atan(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Sinh(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sinh(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Cosh(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_cosh(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Tanh(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_tanh(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Asinh(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_asinh(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Acosh(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_acosh(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value Atanh(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_atanh(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }
    }
}
