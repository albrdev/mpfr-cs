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
            gmp_lib.mpz_com(result.m_Value, value.m_Value);
            return result;
        }
        #endregion

        public static MPZ operator +(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_abs(result.m_Value, value.m_Value);
            return value;
        }

        public static MPZ operator -(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_neg(result.m_Value, value.m_Value);
            return result;
        }

        public static MPZ operator ++(MPZ value)
        {
            gmp_lib.mpz_add_ui(value.m_Value, value.m_Value, 1U);
            return value;
        }

        public static MPZ operator --(MPZ value)
        {
            gmp_lib.mpz_sub_ui(value.m_Value, value.m_Value, 1U);
            return value;
        }
        #endregion

        #region Binary operators
        #region Bitwise operators
        public static MPZ operator |(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_ior(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator &(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_and(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator ^(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_xor(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator <<(MPZ lhs, int rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_2exp(result.m_Value, lhs.m_Value, (mp_bitcnt_t)rhs);
            return result;
        }

        public static MPZ operator >>(MPZ lhs, int rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_fdiv_q_2exp(result.m_Value, lhs.m_Value, (mp_bitcnt_t)rhs);
            return result;
        }

        public static MPZ LeftShift(MPZ lhs, MPZ rhs)
        {
            return lhs << gmp_lib.mpz_get_si(rhs.m_Value);
        }

        public static MPZ RightShift(MPZ lhs, MPZ rhs)
        {
            return lhs >> gmp_lib.mpz_get_si(rhs.m_Value);
        }

        public static MPZ RightShift2(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q_2exp(result.m_Value, lhs.m_Value, (mp_bitcnt_t)gmp_lib.mpz_get_si(rhs.m_Value));
            return result;
        }
        #endregion

        #region +
        public static MPZ operator +(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator +(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator +(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add(result.m_Value, lhs, rhs.m_Value);
            return result;
        }

        public static MPZ operator +(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add_ui(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator +(uint lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_add_ui(result.m_Value, rhs.m_Value, lhs);
            return result;
        }
        #endregion

        #region -
        public static MPZ operator -(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator -(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator -(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub(result.m_Value, lhs, rhs.m_Value);
            return result;
        }

        public static MPZ operator -(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sub_ui(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator -(uint lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_ui_sub(result.m_Value, lhs, rhs.m_Value);
            return result;
        }
        #endregion

        #region *
        public static MPZ operator *(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator *(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator *(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul(result.m_Value, lhs, rhs.m_Value);
            return result;
        }

        public static MPZ operator *(MPZ lhs, int rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_si(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator *(int lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_si(result.m_Value, rhs.m_Value, lhs);
            return result;
        }

        public static MPZ operator *(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_ui(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator *(uint lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mul_ui(result.m_Value, rhs.m_Value, lhs);
            return result;
        }
        #endregion

        #region /
        public static MPZ operator /(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator /(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator /(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q(result.m_Value, lhs, rhs.m_Value);
            return result;
        }

        public static MPZ operator /(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_tdiv_q_ui(result.m_Value, lhs.m_Value, rhs);
            return result;
        }
        #endregion

        #region %
        public static MPZ operator %(MPZ lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod(result.m_Value, lhs.m_Value, rhs.m_Value);
            return result;
        }

        public static MPZ operator %(MPZ lhs, mpz_t rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod(result.m_Value, lhs.m_Value, rhs);
            return result;
        }

        public static MPZ operator %(mpz_t lhs, MPZ rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod(result.m_Value, lhs, rhs.m_Value);
            return result;
        }

        public static MPZ operator %(MPZ lhs, uint rhs)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_mod_ui(result.m_Value, lhs.m_Value, rhs);
            return result;
        }
        #endregion
        #endregion
    }
}
