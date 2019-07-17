using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR_Value
    {
        #region Unary operators
        public static MPFR_Value operator +(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_abs(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return value;
        }

        public static MPFR_Value operator -(MPFR_Value value)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_neg(result.m_Value, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator ++(MPFR_Value value)
        {
            mpfr_lib.mpfr_add_si(value.m_Value, value.m_Value, 1, MPFR_Value.RoundingMode);
            return value;
        }

        public static MPFR_Value operator --(MPFR_Value value)
        {
            mpfr_lib.mpfr_sub_si(value.m_Value, value.m_Value, 1, MPFR_Value.RoundingMode);
            return value;
        }
        #endregion

        #region Binary operators
        #region +
        public static MPFR_Value operator +(MPFR_Value lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_add(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator +(MPFR_Value lhs, mpfr_t rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_add(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator +(mpfr_t lhs, MPFR_Value rhs)
        {
            return rhs + lhs;
        }

        public static MPFR_Value operator +(MPFR_Value lhs, double rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_add_d(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator +(double lhs, MPFR_Value rhs)
        {
            return rhs + lhs;
        }

        public static MPFR_Value operator +(MPFR_Value lhs, int rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_add_si(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator +(int lhs, MPFR_Value rhs)
        {
            return rhs + lhs;
        }

        public static MPFR_Value operator +(MPFR_Value lhs, uint rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_add_ui(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator +(uint lhs, MPFR_Value rhs)
        {
            return rhs + lhs;
        }
        #endregion

        #region -
        public static MPFR_Value operator -(MPFR_Value lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sub(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(MPFR_Value lhs, mpfr_t rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sub(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(mpfr_t lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sub(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(MPFR_Value lhs, double rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sub_d(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(double lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_d_sub(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(MPFR_Value lhs, int rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sub_si(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(int lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_si_sub(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(MPFR_Value lhs, uint rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_sub_ui(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator -(uint lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_ui_sub(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }
        #endregion

        #region *
        public static MPFR_Value operator *(MPFR_Value lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_mul(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator *(MPFR_Value lhs, mpfr_t rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_mul(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator *(mpfr_t lhs, MPFR_Value rhs)
        {
            return rhs * lhs;
        }

        public static MPFR_Value operator *(MPFR_Value lhs, double rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_mul_d(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator *(double lhs, MPFR_Value rhs)
        {
            return rhs * lhs;
        }

        public static MPFR_Value operator *(MPFR_Value lhs, int rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_mul_si(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator *(int lhs, MPFR_Value rhs)
        {
            return rhs * lhs;
        }

        public static MPFR_Value operator *(MPFR_Value lhs, uint rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_mul_ui(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator *(uint lhs, MPFR_Value rhs)
        {
            return rhs * lhs;
        }
        #endregion

        #region /
        public static MPFR_Value operator /(MPFR_Value lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(MPFR_Value lhs, mpfr_t rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(mpfr_t lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(MPFR_Value lhs, double rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div_d(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(double lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_d_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(MPFR_Value lhs, int rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div_si(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(int lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_si_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(MPFR_Value lhs, uint rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div_ui(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator /(uint lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_ui_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }
        #endregion

        #region //
        public static MPFR_Value TruncatedDivision(MPFR_Value lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(MPFR_Value lhs, mpfr_t rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(mpfr_t lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(MPFR_Value lhs, double rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div_d(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(double lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_d_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(MPFR_Value lhs, int rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div_si(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(int lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_si_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(MPFR_Value lhs, uint rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_div_ui(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }

        public static MPFR_Value TruncatedDivision(uint lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_ui_div(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            mpfr_lib.mpfr_trunc(result.m_Value, result.m_Value);
            return result;
        }
        #endregion

        #region %
        public static MPFR_Value operator %(MPFR_Value lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator %(MPFR_Value lhs, mpfr_t rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, rhs, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator %(mpfr_t lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();
            mpfr_lib.mpfr_fmod(result.m_Value, lhs, rhs.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static MPFR_Value operator %(MPFR_Value lhs, double rhs)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_d(tmpValue, rhs, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, tmpValue, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR_Value operator %(double lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_d(tmpValue, lhs, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, rhs.m_Value, tmpValue, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR_Value operator %(MPFR_Value lhs, int rhs)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_si(tmpValue, rhs, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, tmpValue, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR_Value operator %(int lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_si(tmpValue, lhs, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, rhs.m_Value, tmpValue, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR_Value operator %(MPFR_Value lhs, uint rhs)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_ui(tmpValue, rhs, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, lhs.m_Value, tmpValue, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }

        public static MPFR_Value operator %(uint lhs, MPFR_Value rhs)
        {
            MPFR_Value result = new MPFR_Value();

            mpfr_t tmpValue = new mpfr_t();
            mpfr_lib.mpfr_init_set_ui(tmpValue, lhs, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_fmod(result.m_Value, rhs.m_Value, tmpValue, MPFR_Value.RoundingMode);

            mpfr_lib.mpfr_clear(tmpValue);
            return result;
        }
        #endregion
        #endregion
    }
}
