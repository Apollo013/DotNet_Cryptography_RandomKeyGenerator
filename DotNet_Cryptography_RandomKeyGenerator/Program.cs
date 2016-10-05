using System;
using System.Security.Cryptography;

namespace DotNet_Cryptography_RandomKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = GenerateRandomKey(32);
            var key2 = GenerateRandomKey(256);

            Console.WriteLine(key);
            Console.WriteLine(key2);
        }

        /// <summary>
        /// Random key generator
        /// </summary>
        /// <param name="keySize"></param>
        /// <returns></returns>
        private static string GenerateRandomKey(int keySize)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[keySize];
            rng.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);
        }
    }
}
