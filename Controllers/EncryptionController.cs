using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Encrypt(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return BadRequest(new
            {
                Error = "Input text cannot be null or empty."
            });
        }

        var encrypted = new string(input.Reverse().ToArray());
        return Ok(new
        {
            Input = input,
            Encrypted = encrypted
        });
    }

    [HttpGet]
    public IActionResult Decrypt(string encrypted)
    {
        if (string.IsNullOrEmpty(encrypted))
        {
            return BadRequest(new
            {
                Error = "Encrypted text cannot be null or empty."
            });
        }

        var decrypted = new string(encrypted.Reverse().ToArray());
        return Ok(new
        {
            Encrypted = encrypted,
            Decrypted = decrypted
        });
    }
}