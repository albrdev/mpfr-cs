using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR
    {
        public static MPFR Trunc(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_trunc(result.Value, value.Value);
            return result;
        }

        public static MPFR Abs(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_abs(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Neg(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_neg(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Neg2(MPFR value)
        {
            if(value <= 0)
                return new MPFR(value);

            return Neg(value);
        }

        public static MPFR Pow(MPFR a, MPFR b)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_pow(result.Value, a.Value, b.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Sqr(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sqr(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cb(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_pow_ui(result.Value, value.Value, 3U, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Exp(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_exp(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Exp2(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_exp2(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Exp10(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_exp10(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Root(MPFR a, MPFR b)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init(tmpValue);

            mpfr_lib.mpfr_si_div(tmpValue, 1, b.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_pow(result.Value, a.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR Sqrt(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sqrt(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cbrt(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_cbrt(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR LogN(MPFR x, MPFR n)
        {
            MPFR result = new MPFR();

            mpfr_t tmpX = new mpfr_t();
            mpfr_t tmpN = new mpfr_t();
            mpfr_lib.mpfr_inits(tmpX, tmpN);

            mpfr_lib.mpfr_log(tmpX, x.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_log(tmpN, n.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_div(result.Value, x, n, MPFR.RoundingMode);

            mpfr_lib.mpfr_clears(tmpX, tmpN);
            return result;
        }

        public static MPFR Log(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_log(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Log2(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_log2(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Log10(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_log10(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Sin(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sin(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cos(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_cos(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Tan(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_tan(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cot(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_cot(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Sec(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sec(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Csc(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_csc(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Asin(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_asin(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Acos(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_acos(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Atan(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_atan(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Atan2(MPFR y, MPFR x)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_atan2(result.Value, y.Value, x.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Asec(MPFR value)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init(tmpValue);

            mpfr_lib.mpfr_si_div(tmpValue, 1, value.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_acos(result.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR Sinh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sinh(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Cosh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_cosh(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Tanh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_tanh(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Coth(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_coth(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Sech(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sech(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Csch(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_csch(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Asinh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_asinh(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Acosh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_acosh(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR Atanh(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_atanh(result.Value, value.Value, MPFR.RoundingMode);
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
                mpfr_lib.mpfr_add(result.Value, result.Value, value.Value, MPFR.RoundingMode);
            }

            mpfr_lib.mpfr_div_si(result.Value, result.Value, values.Length, MPFR.RoundingMode);
            return result;
        }
    }
}
