using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR_Value
    {
        public static MPFR_Value URandom(mpfr_rnd_t roundingMode, bool inclusive = false)
        {
            MPFR_Value result = new MPFR_Value();

            if(inclusive)
                mpfr_lib.mpfr_urandom(result.m_Value, MPFR_Value.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.m_Value, MPFR_Value.RandomState.Value);

            return result;
        }

        public static MPFR_Value URandom(bool inclusive = false)
        {
            return MPFR_Value.URandom(MPFR_Value.RoundingMode, inclusive);
        }

        public static MPFR_Value URandom(MPFR_Value max, mpfr_rnd_t roundingMode, bool inclusive = false)
        {
            MPFR_Value result = new MPFR_Value();

            if(inclusive)
                mpfr_lib.mpfr_urandom(result.m_Value, MPFR_Value.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.m_Value, MPFR_Value.RandomState.Value);

            mpfr_lib.mpfr_mul(result.m_Value, result.m_Value, max.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value URandom(MPFR_Value max, bool inclusive = false)
        {
            return MPFR_Value.URandom(max, MPFR_Value.RoundingMode, inclusive);
        }

        public static MPFR_Value URandom(MPFR_Value min, MPFR_Value max, mpfr_rnd_t roundingMode, bool inclusive = false)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_t tmp = new mpfr_t();
            mpfr_lib.mpfr_init(tmp);

            if(inclusive)
                mpfr_lib.mpfr_urandom(result.m_Value, MPFR_Value.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.m_Value, MPFR_Value.RandomState.Value);

            mpfr_lib.mpfr_sub(tmp, max.m_Value, min.m_Value, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_mul(result.m_Value, result.m_Value, tmp, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_add(result.m_Value, result.m_Value, min.m_Value, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmp);
            return result;
        }

        public static MPFR_Value URandom(MPFR_Value min, MPFR_Value max, bool inclusive = false)
        {
            return MPFR_Value.URandom(min, max, MPFR_Value.RoundingMode, inclusive);
        }
    }
}
