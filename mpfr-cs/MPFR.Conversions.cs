using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR : IConvertible
    {
        #region To MPFR_Value
        public static explicit operator MPFR(mpfr_t value) => new MPFR(value);
        public static implicit operator MPFR(int value) => new MPFR(value);
        public static implicit operator MPFR(uint value) => new MPFR(value);
        public static implicit operator MPFR(double value) => new MPFR(value);
        public static implicit operator MPFR(string value) => new MPFR(value);
        #endregion

        #region From MPFR_Value
        public static implicit operator mpfr_t(MPFR value)
        {
            mpfr_t result = new mpfr_t();
            mpfr_lib.mpfr_init_set(result, value.m_Value, MPFR.RoundingMode);
            return result;
        }

        public static implicit operator bool(MPFR obj) => obj.BoolValue;
        public static implicit operator int(MPFR value) => mpfr_lib.mpfr_get_si(value.m_Value, MPFR.RoundingMode);
        public static implicit operator uint(MPFR value) => mpfr_lib.mpfr_get_ui(value.m_Value, MPFR.RoundingMode);
        public static implicit operator float(MPFR value) => mpfr_lib.mpfr_get_flt(value.m_Value, MPFR.RoundingMode);
        public static implicit operator double(MPFR value) => mpfr_lib.mpfr_get_d(value.m_Value, MPFR.RoundingMode);
        public static implicit operator decimal(MPFR value) => System.Convert.ToDecimal(value.ToString());
        public static implicit operator string(MPFR value) => value.ToString();
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
