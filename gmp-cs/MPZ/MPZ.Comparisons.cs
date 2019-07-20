using System;

namespace Math.Gmp.Native
{
    public sealed partial class MPZ : IComparable, IComparable<MPZ>, IEquatable<MPZ>
    {
        #region IEquatable
        private static bool EqualsHelper(MPZ a, MPZ b) => gmp_lib.mpz_cmp(a.m_Value, b.m_Value) == 0;

        public static bool Equals(MPZ a, MPZ b)
        {
            if(object.ReferenceEquals(a, b))
                return true;

            if(a is null || b is null)
                return false;

            return MPZ.EqualsHelper(a, b);
        }

        public bool Equals(MPZ value)
        {
            if(value is null)
                return false;

            if(object.ReferenceEquals(this, value))
                return true;

            return MPZ.EqualsHelper(this, value);
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() != GetType())
                return false;

            if(object.ReferenceEquals(this, obj))
                return true;

            return MPZ.EqualsHelper(this, (MPZ)obj);
        }

        public override int GetHashCode() => m_Value.GetHashCode();
        #endregion

        #region IComparable
        public int CompareTo(MPZ other)
        {
            return CompareTo(other.m_Value);
        }

        public int CompareTo(mpz_t obj)
        {
            if(obj is null)
                throw new System.ArgumentNullException();

            return gmp_lib.mpz_cmp(m_Value, obj);
        }

        public int CompareTo(double obj)
        {
            return gmp_lib.mpz_cmp_d(m_Value, obj);
        }

        public int CompareTo(int obj)
        {
            return gmp_lib.mpz_cmp_si(m_Value, obj);
        }

        public int CompareTo(uint obj)
        {
            return gmp_lib.mpz_cmp_ui(m_Value, obj);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is MPZ value))
                throw new System.InvalidCastException();

            return CompareTo(value);
        }
        #endregion

        #region Unary operators
        public static bool operator true(MPZ obj) => obj.BoolValue;
        public static bool operator false(MPZ obj) => !obj.BoolValue;
        public static bool operator !(MPZ obj) => !obj.BoolValue;
        #endregion

        #region Binary operators
        #region ==, !=
        public static bool operator ==(MPZ lhs, MPZ rhs) => MPZ.Equals(lhs, rhs);
        public static bool operator ==(MPZ lhs, mpz_t rhs) => !(lhs is null || rhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(mpz_t lhs, MPZ rhs) => !(lhs is null || rhs is null) && rhs.CompareTo(lhs) == 0;
        public static bool operator ==(MPZ lhs, double rhs) => !(lhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(double lhs, MPZ rhs) => !(rhs is null) && rhs.CompareTo(lhs) == 0;
        public static bool operator ==(MPZ lhs, int rhs) => !(lhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(int lhs, MPZ rhs) => !(rhs is null) && rhs.CompareTo(lhs) == 0;
        public static bool operator ==(MPZ lhs, uint rhs) => !(lhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(uint lhs, MPZ rhs) => !(rhs is null) && rhs.CompareTo(lhs) == 0;

        public static bool operator !=(MPZ lhs, MPZ rhs) => !MPZ.Equals(lhs, rhs);
        public static bool operator !=(MPZ lhs, mpz_t rhs) => !(lhs == rhs);
        public static bool operator !=(mpz_t lhs, MPZ rhs) => !(lhs == rhs);
        public static bool operator !=(MPZ lhs, double rhs) => !(lhs == rhs);
        public static bool operator !=(double lhs, MPZ rhs) => !(lhs == rhs);
        public static bool operator !=(MPZ lhs, int rhs) => !(lhs == rhs);
        public static bool operator !=(int lhs, MPZ rhs) => !(lhs == rhs);
        public static bool operator !=(MPZ lhs, uint rhs) => !(lhs == rhs);
        public static bool operator !=(uint lhs, MPZ rhs) => !(lhs == rhs);
        #endregion

        #region <, >
        public static bool operator <(MPZ lhs, MPZ rhs)  => lhs.CompareTo(rhs) < 0;
        public static bool operator <(MPZ lhs, mpz_t rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(mpz_t lhs, MPZ rhs) => rhs.CompareTo(lhs) > 0;
        public static bool operator <(MPZ lhs, double rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(double lhs, MPZ rhs) => rhs.CompareTo(lhs) > 0;
        public static bool operator <(MPZ lhs, int rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(int lhs, MPZ rhs) => rhs.CompareTo(lhs) > 0;
        public static bool operator <(MPZ lhs, uint rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(uint lhs, MPZ rhs) => rhs.CompareTo(lhs) > 0;

        public static bool operator >(MPZ lhs, MPZ rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(MPZ lhs, mpz_t rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(mpz_t lhs, MPZ rhs) => rhs.CompareTo(lhs) < 0;
        public static bool operator >(MPZ lhs, double rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(double lhs, MPZ rhs) => rhs.CompareTo(lhs) < 0;
        public static bool operator >(MPZ lhs, int rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(int lhs, MPZ rhs) => rhs.CompareTo(lhs) < 0;
        public static bool operator >(MPZ lhs, uint rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(uint lhs, MPZ rhs) => rhs.CompareTo(lhs) < 0;
        #endregion

        #region <=, >=
        public static bool operator <=(MPZ lhs, MPZ rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(MPZ lhs, mpz_t rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(mpz_t lhs, MPZ rhs) => rhs.CompareTo(lhs) >= 0;
        public static bool operator <=(MPZ lhs, double rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(double lhs, MPZ rhs) => rhs.CompareTo(lhs) >= 0;
        public static bool operator <=(MPZ lhs, int rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(int lhs, MPZ rhs) => rhs.CompareTo(lhs) >= 0;
        public static bool operator <=(MPZ lhs, uint rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(uint lhs, MPZ rhs) => rhs.CompareTo(lhs) >= 0;

        public static bool operator >=(MPZ lhs, MPZ rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(MPZ lhs, mpz_t rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(mpz_t lhs, MPZ rhs) => rhs.CompareTo(lhs) <= 0;
        public static bool operator >=(MPZ lhs, double rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(double lhs, MPZ rhs) => rhs.CompareTo(lhs) <= 0;
        public static bool operator >=(MPZ lhs, int rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(int lhs, MPZ rhs) => rhs.CompareTo(lhs) <= 0;
        public static bool operator >=(MPZ lhs, uint rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(uint lhs, MPZ rhs) => rhs.CompareTo(lhs) <= 0;
        #endregion
        #endregion
    }
}
