using CryptoAPI.Services;
using Xunit;

namespace CryptoAPI.Tests
{
    public class CryptoServiceTests
    {
        private readonly CryptoService _cryptoService = new();

        [Fact]
        public void Encrypt_ShouldShiftCharacters()
        {
            
            string input = "hello";
            string expected = "khoor"; 

           
            string result = _cryptoService.Encrypt(input);

          
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Decrypt_ShouldShiftCharactersBack()
        {
            
            string input = "khoor";
            string expected = "hello";

           
            string result = _cryptoService.Decrypt(input);

            
            Assert.Equal(expected, result);
        }
    }
}
