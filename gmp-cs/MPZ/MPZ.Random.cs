using System;

namespace Math.Gmp.Native
{
    public sealed partial class MPZ
    {
        public static MPZ URandom(MPZ max, bool inclusive = false)
        {
            MPZ result = new MPZ();

            if(inclusive)
            {
                mpz_t tmp = new mpz_t();
                gmp_lib.mpz_init(tmp);
                gmp_lib.mpz_add_ui(tmp, max.Value, 1U);
                gmp_lib.mpz_urandomm(result.Value, MPZ.RandomState.Value, tmp);
                gmp_lib.mpz_clear(tmp);
            }
            else
                gmp_lib.mpz_urandomm(result.Value, MPZ.RandomState.Value, max.Value);

            return result;
        }

        public static MPZ URandom(MPZ min, MPZ max, bool inclusive = false)
        {
            MPZ result = new MPZ();

            mpz_t tmp = new mpz_t();
            gmp_lib.mpz_init(tmp);
            gmp_lib.mpz_sub(tmp, max.Value, min.Value);

            if(inclusive)
                gmp_lib.mpz_add_ui(tmp, tmp, 1U);

            gmp_lib.mpz_urandomm(result.Value, MPZ.RandomState.Value, tmp);
            gmp_lib.mpz_add(result.Value, min.Value, result.Value);

            gmp_lib.mpz_clear(tmp);
            return result;
        }


        public static MPZ BRandom(MPZ max)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_urandomb(result.Value, MPZ.RandomState.Value, (mp_bitcnt_t)(ulong)max);
            return result;
        }
    }
}
