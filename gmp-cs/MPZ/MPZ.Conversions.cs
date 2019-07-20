using System;

namespace Math.Gmp.Native
{
    public sealed partial class MPZ : IConvertible
    {
        #region To MPZ_Value
        public static explicit operator MPZ(mpz_t value) => new MPZ(value);
        public static implicit operator MPZ(int value) => new MPZ(value);
        public static implicit operator MPZ(uint value) => new MPZ(value);
        public static implicit operator MPZ(double value) => new MPZ(value);
        public static implicit operator MPZ(string value) => new MPZ(value);
        #endregion

        #region From MPZ_Value
        public static implicit operator mpz_t(MPZ value)
        {
            mpz_t result = new mpz_t();
            gmp_lib.mpz_init_set(result, value.m_Value);
            return result;
        }

        public static implicit operator bool(MPZ obj) => obj.BoolValue;
        public static implicit operator int(MPZ value) => gmp_lib.mpz_get_si(value.m_Value);
        public static implicit operator uint(MPZ value) => gmp_lib.mpz_get_ui(value.m_Value);
        public static implicit operator float(MPZ value) => (float)gmp_lib.mpz_get_d(value.m_Value);
        public static implicit operator double(MPZ value) => gmp_lib.mpz_get_d(value.m_Value);
        public static implicit operator decimal(MPZ value) => System.Convert.ToDecimal(value.ToString());
        public static implicit operator string(MPZ value) => value.ToString();
        #endregion

        #region IConvertible
        public TypeCode GetTypeCode() => TypeCode.Object;
        public object ToType(Type conversionType, IFormatProvider provider) => Convert.ChangeType(this, conversionType);
        public bool ToBoolean(IFormatProvider provider) => BoolValue;
        public byte ToByte(IFormatProvider provider) => System.Convert.ToByte((uint)this);
        public sbyte ToSByte(IFormatProvider provider) => System.Convert.ToSByte((int)this);
        public decimal ToDecimal(IFormatProvider provider) => System.Convert.ToDecimal(ToString());
        public short ToInt16(IFormatProvider provider) => System.Convert.ToInt16((int)this);
        public ushort ToUInt16(IFormatProvider provider) => System.Convert.ToUInt16((uint)this);
        public int ToInt32(IFormatProvider provider) => this;
        public uint ToUInt32(IFormatProvider provider) => this;
        public long ToInt64(IFormatProvider provider) => System.Convert.ToInt64((double)this);
        public ulong ToUInt64(IFormatProvider provider) => System.Convert.ToUInt64((double)this);
        public float ToSingle(IFormatProvider provider) => this;
        public double ToDouble(IFormatProvider provider) => this;
        public char ToChar(IFormatProvider provider) => throw new System.InvalidCastException();
        public string ToString(IFormatProvider provider) => ToString();
        public DateTime ToDateTime(IFormatProvider provider) => throw new System.InvalidCastException();
        #endregion
    }
}
