using System;

namespace Math.Gmp.Native
{
    public sealed partial class MPZ
    {
        public static MPZ Abs(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_abs(result.m_Value, value.m_Value);
            return result;
        }

        public static MPZ Neg(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_neg(result.m_Value, value.m_Value);
            return result;
        }

        public static MPZ Neg2(MPZ value)
        {
            if(value <= 0)
                return new MPZ(value);

            return Neg(value);
        }

        public static MPZ Min(params MPZ[] values)
        {
            if(values.Length == 0)
                throw new System.ArgumentException();

            MPZ result = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                if(values[i] < result)
                {
                    result = values[i];
                }
            }

            return new MPZ(result);
        }

        public static MPZ Max(params MPZ[] values)
        {
            if(values.Length == 0)
                throw new System.ArgumentException();

            MPZ result = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                if(values[i] > result)
                {
                    result = values[i];
                }
            }

            return new MPZ(result);
        }

        public static MPZ Pow(MPZ a, MPZ b)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_pow_ui(result.m_Value, a.m_Value, b);
            return result;
        }

        public static MPZ Sqr(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_pow_ui(result.m_Value, value.m_Value, 2U);
            return result;
        }

        public static MPZ Cb(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_pow_ui(result.m_Value, value.m_Value, 3U);
            return result;
        }

        public static MPZ Sqrt(MPZ value)
        {
            MPZ result = new MPZ();
            gmp_lib.mpz_sqrt(result.m_Value, value.m_Value);
            return result;
        }
    }
}
