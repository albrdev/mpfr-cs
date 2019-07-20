using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR
    {
        #region Unary operators
        public static MPFR operator +(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_abs(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return value;
        }

        public static MPFR operator -(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_neg(result.m_Value, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator ++(MPFR value)
        {
            mpfr_lib.mpfr_add_si(value.m_Value, value.m_Value, 1, MPFR.RoundingMode);
            return value;
        }

        public static MPFR operator --(MPFR value)
        {
            mpfr_lib.mpfr_sub_si(value.m_Value, value.m_Value, 1, MPFR.RoundingMode);
            return value;
        }
        #endregion

        #region Binary operators
        #region +
        public static MPFR operator +(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(mpfr_t lhs, MPFR rhs)
        {
            return rhs + lhs;
        }

        public static MPFR operator +(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_d(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(double lhs, MPFR rhs)
        {
            return rhs + lhs;
        }

        public static MPFR operator +(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_si(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(int lhs, MPFR rhs)
        {
            return rhs + lhs;
        }

        public static MPFR operator +(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_ui(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(uint lhs, MPFR rhs)
        {
            return rhs + lhs;
        }
        #endregion

        #region -
        public static MPFR operator -(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub_d(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_d_sub(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub_si(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_si_sub(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub_ui(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_ui_sub(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }
        #endregion

        #region *
        public static MPFR operator *(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(mpfr_t lhs, MPFR rhs)
        {
            return rhs * lhs;
        }

        public static MPFR operator *(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_d(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(double lhs, MPFR rhs)
        {
            return rhs * lhs;
        }

        public static MPFR operator *(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_si(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(int lhs, MPFR rhs)
        {
            return rhs * lhs;
        }

        public static MPFR operator *(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_ui(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(uint lhs, MPFR rhs)
        {
            return rhs * lhs;
        }
        #endregion

        #region /
        public static MPFR operator /(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_d(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_d_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_si(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_si_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_ui(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_ui_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }
        #endregion

        #region //
        public static MPFR TruncatedDivision(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_d(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_d_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_si(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_si_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_ui(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR TruncatedDivision(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_ui_div(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }
        #endregion

        #region %
        public static MPFR operator %(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator %(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator %(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_fmod(result.m_Value, lhs, rhs.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator %(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_d(tmpValue, rhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_d(tmpValue, lhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, rhs.m_Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_si(tmpValue, rhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_si(tmpValue, lhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, rhs.m_Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_ui(tmpValue, rhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_ui(tmpValue, lhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, rhs.m_Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }
        #endregion
        #endregion
    }
}
