using Microsoft.AspNetCore.Mvc;
using CryptoAPI.Services;

namespace CryptoAPI.Controllers
{
    [Route("api/crypto")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        private readonly CryptoService _cryptoService;

        public CryptoController()
        {
            _cryptoService = new CryptoService();
        }

        [HttpPost("encrypt")]
        public IActionResult Encrypt([FromBody] string text)
        {
            var encrypted = _cryptoService.Encrypt(text);
            return Ok(new { EncryptedText = encrypted });
        }

        [HttpPost("decrypt")]
        public IActionResult Decrypt([FromBody] string text)
        {
            var decrypted = _cryptoService.Decrypt(text);
            return Ok(new { DecryptedText = decrypted });
        }
    }
}
