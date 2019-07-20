using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR
    {
        public static MPFR URandom(mpfr_rnd_t roundingMode, bool inclusive = false)
        {
            MPFR result = new MPFR();

            if(inclusive)
                mpfr_lib.mpfr_urandom(result.m_Value, MPFR.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.m_Value, MPFR.RandomState.Value);

            return result;
        }

        public static MPFR URandom(bool inclusive = false)
        {
            return MPFR.URandom(MPFR.RoundingMode, inclusive);
        }

        public static MPFR URandom(MPFR max, mpfr_rnd_t roundingMode, bool inclusive = false)
        {
            MPFR result = new MPFR();

            if(inclusive)
                mpfr_lib.mpfr_urandom(result.m_Value, MPFR.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.m_Value, MPFR.RandomState.Value);

            mpfr_lib.mpfr_mul(result.m_Value, result.m_Value, max.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR URandom(MPFR max, bool inclusive = false)
        {
            return MPFR.URandom(max, MPFR.RoundingMode, inclusive);
        }

        public static MPFR URandom(MPFR min, MPFR max, mpfr_rnd_t roundingMode, bool inclusive = false)
        {
            MPFR result = new MPFR();
            mpfr_t tmp = new mpfr_t();
            mpfr_lib.mpfr_init(tmp);

            if(inclusive)
                mpfr_lib.mpfr_urandom(result.m_Value, MPFR.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.m_Value, MPFR.RandomState.Value);

            mpfr_lib.mpfr_sub(tmp, max.m_Value, min.m_Value, MPFR.RoundingMode);

            mpfr_lib.mpfr_mul(result.m_Value, result.m_Value, tmp, MPFR.RoundingMode);
            mpfr_lib.mpfr_add(result.m_Value, result.m_Value, min.m_Value, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmp);
            return result;
        }

        public static MPFR URandom(MPFR min, MPFR max, bool inclusive = false)
        {
            return MPFR.URandom(min, max, MPFR.RoundingMode, inclusive);
        }
    }
}
