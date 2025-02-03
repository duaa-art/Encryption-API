using API.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<EncryptionService>();
builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddDefaultPolicy(policy =>
        policy.WithOrigins("*").AllowAnyHeader().AllowAnyHeader())
);
var app = builder.Build();

app.UseCors();

app.MapGet("/", () => "Hello World!");

app.MapGet("/encrypt/{text}", (string text, CryptoService cryptoService) =>
{
    return encryptionService.Encrypt(text);
});

app.MapGet("/decrypt/{text}", (string text,  CryptoService cryptoService ) =>
{
    return encryptionService.Decrypt(text);
});

app.Run();