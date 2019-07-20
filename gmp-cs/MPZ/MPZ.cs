using System;

namespace Math.Gmp.Native
{
    public sealed partial class MPZ : IDisposable
    {
        private mpz_t m_Value = new mpz_t();
        private bool m_IsDisposed = false;

        public static MPZ Zero { get; } = new MPZ(0);
        public static MPZ NegativeOne { get; } = new MPZ(-1);
        public static MPZ PositiveOne { get; } = new MPZ(1);

        private bool BoolValue { get => gmp_lib.mpz_sgn(m_Value) != 0; }

        public string ToString(int radix)
        {
            char_ptr tmp = gmp_lib.mpz_get_str(char_ptr.Zero, radix, m_Value);
            string result = tmp.ToString();
            gmp_lib.free(tmp);
            return result;
        }

        public override string ToString()
        {
            /*ptr<char_ptr> buffer = new ptr<char_ptr>();

            gmp_lib.gmp_asprintf(buffer, "%Zd", m_Value);
            string result = buffer.Value.ToString();

            gmp_lib.free(buffer.Value);*/
            return ToString(10);
        }

        public MPZ(MPZ other) : this(other.m_Value) { }

        public MPZ(mpz_t value)
        {
            gmp_lib.mpz_init_set(m_Value, value);
        }

        public MPZ(int value)
        {
            gmp_lib.mpz_init_set_si(m_Value, value);
        }

        public MPZ(uint value)
        {
            gmp_lib.mpz_init_set_ui(m_Value, value);
        }

        public MPZ(double value)
        {
            gmp_lib.mpz_init_set_d(m_Value, value);
        }

        public MPZ(string value, int radix = 10)
        {
            char_ptr tmp = new char_ptr(value);
            gmp_lib.mpz_init_set_str(m_Value, tmp, radix);
            gmp_lib.free(tmp);
        }

        public MPZ(mp_bitcnt_t precision)
        {
            gmp_lib.mpz_init2(m_Value, precision);
        }

        public MPZ()
        {
            gmp_lib.mpz_init(m_Value);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(m_IsDisposed)
                return;

            gmp_lib.mpz_clear(m_Value);
            m_IsDisposed = true;
        }

        ~MPZ()
        {
            Dispose(false);
        }
    }
}
