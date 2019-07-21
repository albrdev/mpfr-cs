using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR
    {
        #region Unary operators
        public static MPFR operator +(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_abs(result.Value, value.Value, MPFR.RoundingMode);
            return value;
        }

        public static MPFR operator -(MPFR value)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_neg(result.Value, value.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator ++(MPFR value)
        {
            mpfr_lib.mpfr_add_si(value.Value, value.Value, 1, MPFR.RoundingMode);
            return value;
        }

        public static MPFR operator --(MPFR value)
        {
            mpfr_lib.mpfr_sub_si(value.Value, value.Value, 1, MPFR.RoundingMode);
            return value;
        }
        #endregion

        #region Binary operators
        #region +
        public static MPFR operator +(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add(result.Value, lhs.Value, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_d(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_d(result.Value, rhs.Value, lhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_si(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_si(result.Value, rhs.Value, lhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_ui(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator +(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_add_ui(result.Value, rhs.Value, lhs, MPFR.RoundingMode);
            return result;
        }
        #endregion

        #region -
        public static MPFR operator -(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub(result.Value, lhs.Value, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub_d(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_d_sub(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub_si(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_si_sub(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_sub_ui(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator -(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_ui_sub(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }
        #endregion

        #region *
        public static MPFR operator *(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul(result.Value, lhs.Value, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_d(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_d(result.Value, rhs.Value, lhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_si(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_si(result.Value, rhs.Value, lhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_ui(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator *(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_mul_ui(result.Value, rhs.Value, lhs, MPFR.RoundingMode);
            return result;
        }
        #endregion

        #region /
        public static MPFR operator /(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.Value, lhs.Value, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_d(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_d_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_si(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_si_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_ui(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator /(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_ui_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }
        #endregion

        #region //
        public static MPFR TruncatedDivision(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.Value, lhs.Value, rhs.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_d(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_d_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_si(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_si_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_div_ui(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }

        public static MPFR TruncatedDivision(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_ui_div(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            mpfr_lib.mpfr_trunc(result.Value, result.Value);
            return result;
        }
        #endregion

        #region %
        public static MPFR operator %(MPFR lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_fmod(result.Value, lhs.Value, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator %(MPFR lhs, mpfr_t rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_fmod(result.Value, lhs.Value, rhs, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator %(mpfr_t lhs, MPFR rhs)
        {
            MPFR result = new MPFR();
            mpfr_lib.mpfr_fmod(result.Value, lhs, rhs.Value, MPFR.RoundingMode);
            return result;
        }

        public static MPFR operator %(MPFR lhs, double rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_d(tmpValue, rhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.Value, lhs.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(double lhs, MPFR rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_d(tmpValue, lhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.Value, rhs.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(MPFR lhs, int rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_si(tmpValue, rhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.Value, lhs.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(int lhs, MPFR rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_si(tmpValue, lhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.Value, rhs.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(MPFR lhs, uint rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_ui(tmpValue, rhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.Value, lhs.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR operator %(uint lhs, MPFR rhs)
        {
            MPFR result = new MPFR();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_ui(tmpValue, lhs, MPFR.RoundingMode);

            mpfr_lib.mpfr_fmod(result.Value, rhs.Value, tmpValue, MPFR.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }
        #endregion
        #endregion
    }
}
