using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR : IComparable, IComparable<MPFR>, IEquatable<MPFR>
    {
        #region IEquatable
        private static bool EqualsHelper(MPFR a, MPFR b) => mpfr_lib.mpfr_cmp(a.Value, b.Value) == 0;

        public static bool Equals(MPFR a, MPFR b)
        {
            if(object.ReferenceEquals(a, b))
                return true;

            if(a is null || b is null)
                return false;

            return MPFR.EqualsHelper(a, b);
        }

        public bool Equals(MPFR value)
        {
            if(value is null)
                return false;

            if(object.ReferenceEquals(this, value))
                return true;

            return MPFR.EqualsHelper(this, value);
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() != GetType())
                return false;

            if(object.ReferenceEquals(this, obj))
                return true;

            return MPFR.EqualsHelper(this, (MPFR)obj);
        }

        public override int GetHashCode() => Value.GetHashCode();
        #endregion

        #region IComparable
        public int CompareTo(MPFR other)
        {
            return CompareTo(other.Value);
        }

        public int CompareTo(mpfr_t obj)
        {
            if(obj is null)
                throw new System.ArgumentNullException();

            return mpfr_lib.mpfr_cmp(Value, obj);
        }

        public int CompareTo(double obj)
        {
            return mpfr_lib.mpfr_cmp_d(Value, obj);
        }

        public int CompareTo(int obj)
        {
            return mpfr_lib.mpfr_cmp_si(Value, obj);
        }

        public int CompareTo(uint obj)
        {
            return mpfr_lib.mpfr_cmp_ui(Value, obj);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is MPFR value))
                throw new System.InvalidCastException();

            return CompareTo(value);
        }
        #endregion

        #region Unary operators
        public static bool operator true(MPFR obj) => obj.BoolValue;
        public static bool operator false(MPFR obj) => !obj.BoolValue;
        public static bool operator !(MPFR obj) => !obj.BoolValue;
        #endregion

        #region Binary operators
        #region ==, !=
        public static bool operator ==(MPFR lhs, MPFR rhs) => MPFR.Equals(lhs, rhs);
        public static bool operator ==(MPFR lhs, mpfr_t rhs) => !(lhs is null || rhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(mpfr_t lhs, MPFR rhs) => !(lhs is null || rhs is null) && rhs.CompareTo(lhs) == 0;
        public static bool operator ==(MPFR lhs, double rhs) => !(lhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(double lhs, MPFR rhs) => !(rhs is null) && rhs.CompareTo(lhs) == 0;
        public static bool operator ==(MPFR lhs, int rhs) => !(lhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(int lhs, MPFR rhs) => !(rhs is null) && rhs.CompareTo(lhs) == 0;
        public static bool operator ==(MPFR lhs, uint rhs) => !(lhs is null) && lhs.CompareTo(rhs) == 0;
        public static bool operator ==(uint lhs, MPFR rhs) => !(rhs is null) && rhs.CompareTo(lhs) == 0;

        public static bool operator !=(MPFR lhs, MPFR rhs) => !MPFR.Equals(lhs, rhs);
        public static bool operator !=(MPFR lhs, mpfr_t rhs) => !(lhs == rhs);
        public static bool operator !=(mpfr_t lhs, MPFR rhs) => !(lhs == rhs);
        public static bool operator !=(MPFR lhs, double rhs) => !(lhs == rhs);
        public static bool operator !=(double lhs, MPFR rhs) => !(lhs == rhs);
        public static bool operator !=(MPFR lhs, int rhs) => !(lhs == rhs);
        public static bool operator !=(int lhs, MPFR rhs) => !(lhs == rhs);
        public static bool operator !=(MPFR lhs, uint rhs) => !(lhs == rhs);
        public static bool operator !=(uint lhs, MPFR rhs) => !(lhs == rhs);
        #endregion

        #region <, >
        public static bool operator <(MPFR lhs, MPFR rhs)  => lhs.CompareTo(rhs) < 0;
        public static bool operator <(MPFR lhs, mpfr_t rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(mpfr_t lhs, MPFR rhs) => rhs.CompareTo(lhs) > 0;
        public static bool operator <(MPFR lhs, double rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(double lhs, MPFR rhs) => rhs.CompareTo(lhs) > 0;
        public static bool operator <(MPFR lhs, int rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(int lhs, MPFR rhs) => rhs.CompareTo(lhs) > 0;
        public static bool operator <(MPFR lhs, uint rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator <(uint lhs, MPFR rhs) => rhs.CompareTo(lhs) > 0;

        public static bool operator >(MPFR lhs, MPFR rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(MPFR lhs, mpfr_t rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(mpfr_t lhs, MPFR rhs) => rhs.CompareTo(lhs) < 0;
        public static bool operator >(MPFR lhs, double rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(double lhs, MPFR rhs) => rhs.CompareTo(lhs) < 0;
        public static bool operator >(MPFR lhs, int rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(int lhs, MPFR rhs) => rhs.CompareTo(lhs) < 0;
        public static bool operator >(MPFR lhs, uint rhs) => lhs.CompareTo(rhs) > 0;
        public static bool operator >(uint lhs, MPFR rhs) => rhs.CompareTo(lhs) < 0;
        #endregion

        #region <=, >=
        public static bool operator <=(MPFR lhs, MPFR rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(MPFR lhs, mpfr_t rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(mpfr_t lhs, MPFR rhs) => rhs.CompareTo(lhs) >= 0;
        public static bool operator <=(MPFR lhs, double rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(double lhs, MPFR rhs) => rhs.CompareTo(lhs) >= 0;
        public static bool operator <=(MPFR lhs, int rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(int lhs, MPFR rhs) => rhs.CompareTo(lhs) >= 0;
        public static bool operator <=(MPFR lhs, uint rhs) => lhs.CompareTo(rhs) <= 0;
        public static bool operator <=(uint lhs, MPFR rhs) => rhs.CompareTo(lhs) >= 0;

        public static bool operator >=(MPFR lhs, MPFR rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(MPFR lhs, mpfr_t rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(mpfr_t lhs, MPFR rhs) => rhs.CompareTo(lhs) <= 0;
        public static bool operator >=(MPFR lhs, double rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(double lhs, MPFR rhs) => rhs.CompareTo(lhs) <= 0;
        public static bool operator >=(MPFR lhs, int rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(int lhs, MPFR rhs) => rhs.CompareTo(lhs) <= 0;
        public static bool operator >=(MPFR lhs, uint rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator >=(uint lhs, MPFR rhs) => rhs.CompareTo(lhs) <= 0;
        #endregion
        #endregion
    }
}
