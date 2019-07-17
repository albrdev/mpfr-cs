using System;

namespace Math.Mpfr.Native
{
    public sealed partial class MPFR_Value : IConvertible
    {
        #region To MPFR_Value
        public static explicit operator MPFR_Value(mpfr_t value) => new MPFR_Value(value);
        public static implicit operator MPFR_Value(int value) => new MPFR_Value(value);
        public static implicit operator MPFR_Value(uint value) => new MPFR_Value(value);
        public static implicit operator MPFR_Value(double value) => new MPFR_Value(value);
        public static implicit operator MPFR_Value(string value) => new MPFR_Value(value);
        #endregion

        #region From MPFR_Value
        public static implicit operator mpfr_t(MPFR_Value value)
        {
            mpfr_t result = new mpfr_t();
            mpfr_lib.mpfr_init_set(result, value.m_Value, MPFR_Value.RoundingMode);
            return result;
        }

        public static implicit operator bool(MPFR_Value obj) => obj.BoolValue;
        public static implicit operator int(MPFR_Value value) => mpfr_lib.mpfr_get_si(value.m_Value, MPFR_Value.RoundingMode);
        public static implicit operator uint(MPFR_Value value) => mpfr_lib.mpfr_get_ui(value.m_Value, MPFR_Value.RoundingMode);
        public static implicit operator float(MPFR_Value value) => mpfr_lib.mpfr_get_flt(value.m_Value, MPFR_Value.RoundingMode);
        public static implicit operator double(MPFR_Value value) => mpfr_lib.mpfr_get_d(value.m_Value, MPFR_Value.RoundingMode);
        public static implicit operator decimal(MPFR_Value value) => System.Convert.ToDecimal(value.ToString());
        public static implicit operator string(MPFR_Value value) => value.ToString();
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
