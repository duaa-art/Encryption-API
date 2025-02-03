using System;

namespace CryptoAPI.Services
{
    public class CryptoService
    {
        private const int Shift = 3; 

        public string Encrypt(string input)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] + Shift);
            }
            return new string(buffer);
        }

        public string Decrypt(string input)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] - Shift);
            }
            return new string(buffer);
        }
    }
}
