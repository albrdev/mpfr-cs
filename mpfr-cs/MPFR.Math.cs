using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR
    {
        public static MPFR Trunc(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_trunc(result.m_Value, value.m_Value);
            return result;
        }

        public static MPFR Abs(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_abs(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Neg(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_neg(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Min(params MPFR[] values)
        {
            if(values.Length == 0)
                return new MPFR(MPFR.NaN);

            MPFR result = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                if(values[i] < result)
                {
                    result = values[i];
                }
            }

            return new MPFR(result);
        }

        public static MPFR Max(params MPFR[] values)
        {
            if(values.Length == 0)
                return new MPFR(MPFR.NaN);

            MPFR result = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                if(values[i] > result)
                {
                    result = values[i];
                }
            }

            return new MPFR(result);
        }

        public static MPFR Mean(params MPFR[] values)
        {
            MPFR result = new MPFR(0);

            foreach(var value in values)
            {
                mpfr_lib.mpfr_add(result.m_Value, result.m_Value, value.m_Value, MPFR.RoundingMode);
            }

            mpfr_lib.mpfr_div_si(result.m_Value, result.m_Value, values.Length, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Pow(MPFR a, MPFR b)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_pow(result.m_Value, a.m_Value, b.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Sqr(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sqr(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Root(MPFR a, MPFR b)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init(tmpValue);

            mpfr_lib.mpfr_si_div(tmpValue, 1, b.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_pow(result.m_Value, a.m_Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR Sqrt(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sqrt(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cbrt(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_cbrt(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Log(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_log(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Log2(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_log2(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Log10(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_log10(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR NthLog(MPFR a, MPFR b)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue1 = new mpfr_t();
            mpfr_t tmpValue2 = new mpfr_t();
            mpfr_lib.mpfr_inits(tmpValue1, tmpValue2);

            mpfr_lib.mpfr_log(tmpValue1, a.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_log(tmpValue2, b.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_div(result.m_Value, a, b, MPFR.RoundingMode);

            mpfr_lib.mpfr_clears(tmpValue1, tmpValue2);
            return result;
        }

        public static MPFR Sin(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sin(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cos(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_cos(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Tan(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_tan(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Asin(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_asin(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Acos(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_acos(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Atan(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_atan(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Sinh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sinh(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cosh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_cosh(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Tanh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_tanh(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Asinh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_asinh(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Acosh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_acosh(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Atanh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_atanh(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }
    }
}
