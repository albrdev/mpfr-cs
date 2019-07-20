using System;
using System.Text;
using System.Security.Cryptography;

namespace Math.Gmp.Native
{
    public sealed class RandState : IDisposable
    {
        public gmp_randstate_t Value { get; private set; } = new gmp_randstate_t();
        public mpz_t Seed { get; private set; } = new mpz_t();
        private bool m_IsDisposed = false;

        public static implicit operator RandState(int value) => new RandState(value);
        public static implicit operator RandState(uint value) => new RandState(value);
        public static implicit operator RandState(double value) => new RandState(value);
        public static implicit operator RandState(string value) => new RandState(value);

        public override string ToString()
        {
            ptr<char_ptr> buffer = new ptr<char_ptr>();

            gmp_lib.gmp_asprintf(buffer, "%Zu", Seed);
            string result = buffer.Value.ToString();

            gmp_lib.free(buffer.Value);
            return result;
        }

        public RandState(RandState other) : this(other.Value) { }

        public RandState(gmp_randstate_t value)
        {
            gmp_lib.gmp_randinit_set(Value, value);
        }

        public RandState(mpz_t value)
        {
            gmp_lib.gmp_randinit_default(Value);
            gmp_lib.mpz_init_set(Seed, value);
            gmp_lib.gmp_randseed(Value, Seed);
        }

        public RandState(int value)
        {
            gmp_lib.gmp_randinit_default(Value);

            gmp_lib.mpz_init_set_si(Seed, value);
            gmp_lib.gmp_randseed(Value, Seed);
        }

        public RandState(uint value)
        {
            gmp_lib.gmp_randinit_default(Value);

            gmp_lib.mpz_init_set_ui(Seed, value);
            gmp_lib.gmp_randseed(Value, Seed);
        }

        public RandState(double value)
        {
            gmp_lib.gmp_randinit_default(Value);

            gmp_lib.mpz_init_set_d(Seed, value);
            gmp_lib.gmp_randseed(Value, Seed);
        }

        public RandState(string value)
        {
            gmp_lib.gmp_randinit_default(Value);
            using(SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.Default.GetBytes(value));

                StringBuilder sb = new StringBuilder();
                foreach(var h in hash)
                {
                    sb.Append(h.ToString("X2"));
                }

                char_ptr tmpStr = new char_ptr(sb.ToString());
                gmp_lib.mpz_init_set_str(Seed, tmpStr, 16);
                gmp_lib.gmp_randseed(Value, Seed);
                gmp_lib.free(tmpStr);
            }
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

            gmp_lib.gmp_randclear(Value);
            gmp_lib.mpz_clear(Seed);
            m_IsDisposed = true;
        }

        ~RandState()
        {
            Dispose(false);
        }
    }
}
