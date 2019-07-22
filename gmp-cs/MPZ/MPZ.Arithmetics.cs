using System;

namespace Math.Gmp.Native
{
    public sealed partial class MPZ : IDisposable
    {
        #region Unary operators
        #region Bitwise operators
        public static MPZ operator ~(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_com(result.Value, value.Value);
            return result;
        }
        #endregion

        public static MPZ operator +(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_abs(result.Value, value.Value);
            return value;
        }

        public static MPZ operator -(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_neg(result.Value, value.Value);
            return result;
        }

        public static MPZ operator ++(MPZ value)
        {
            gmp_lib.mpz_add_ui(value.Value, value.Value, 1U);
            return value;
        }

        public static MPZ operator --(MPZ value)
        {
            gmp_lib.mpz_sub_ui(value.Value, value.Value, 1U);
            return value;
        }
        #endregion

        #region Binary operators
        #region Bitwise operators
        public static MPZ operator |(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_ior(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator &(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_and(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator ^(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_xor(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator <<(MPZ lhs, int rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_2exp(result.Value, lhs.Value, (mp_bitcnt_t)rhs);
            return result;
        }

        public static MPZ operator >>(MPZ lhs, int rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q_2exp(result.Value, lhs.Value, (mp_bitcnt_t)rhs);
            return result;
        }

        public static MPZ LeftShift(MPZ lhs, MPZ rhs)
        {
            return lhs << rhs;
        }

        public static MPZ RightShift(MPZ lhs, MPZ rhs)
        {
            return lhs >> rhs;
        }
        #endregion

        #region +
        public static MPZ operator +(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator +(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator +(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add(result.Value, lhs, rhs.Value);
            return result;
        }

        public static MPZ operator +(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add_ui(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator +(uint lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add_ui(result.Value, rhs.Value, lhs);
            return result;
        }
        #endregion

        #region -
        public static MPZ operator -(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator -(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator -(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub(result.Value, lhs, rhs.Value);
            return result;
        }

        public static MPZ operator -(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub_ui(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator -(uint lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_ui_sub(result.Value, lhs, rhs.Value);
            return result;
        }
        #endregion

        #region *
        public static MPZ operator *(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator *(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator *(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul(result.Value, lhs, rhs.Value);
            return result;
        }

        public static MPZ operator *(MPZ lhs, int rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_si(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator *(int lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_si(result.Value, rhs.Value, lhs);
            return result;
        }

        public static MPZ operator *(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_ui(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator *(uint lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_ui(result.Value, rhs.Value, lhs);
            return result;
        }
        #endregion

        #region /
        public static MPZ operator /(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator /(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator /(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q(result.Value, lhs, rhs.Value);
            return result;
        }

        public static MPZ operator /(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q_ui(result.Value, lhs.Value, rhs);
            return result;
        }
        #endregion

        #region %
        public static MPZ operator %(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod(result.Value, lhs.Value, rhs.Value);
            return result;
        }

        public static MPZ operator %(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod(result.Value, lhs.Value, rhs);
            return result;
        }

        public static MPZ operator %(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod(result.Value, lhs, rhs.Value);
            return result;
        }

        public static MPZ operator %(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod_ui(result.Value, lhs.Value, rhs);
            return result;
        }
        #endregion
        #endregion
    }
}
