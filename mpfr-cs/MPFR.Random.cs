using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR
    {
        public static MPFR URandom(mpfr_rnd_t roundingMode, bool inclusive = false)
        {
            MPFR result = new MPFR();

            if(inclusive)
                mpfr_lib.mpfr_urandom(result.Value, MPFR.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.Value, MPFR.RandomState.Value);

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
                mpfr_lib.mpfr_urandom(result.Value, MPFR.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.Value, MPFR.RandomState.Value);

            mpfr_lib.mpfr_mul(result.Value, result.Value, max.Value, MPFR.RoundingMode);
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
                mpfr_lib.mpfr_urandom(result.Value, MPFR.RandomState.Value, roundingMode);
            else
                mpfr_lib.mpfr_urandomb(result.Value, MPFR.RandomState.Value);

            mpfr_lib.mpfr_sub(tmp, max.Value, min.Value, MPFR.RoundingMode);

            mpfr_lib.mpfr_mul(result.Value, result.Value, tmp, MPFR.RoundingMode);
            mpfr_lib.mpfr_add(result.Value, result.Value, min.Value, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmp);
            return result;
        }

        public static MPFR URandom(MPFR min, MPFR max, bool inclusive = false)
        {
            return MPFR.URandom(min, max, MPFR.RoundingMode, inclusive);
        }
    }
}
