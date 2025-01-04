using System.Security.Cryptography;
using System.Text;

namespace DocWellV2.Utils;

public class SecretManager
{
    public string Password { get; set; } = string.Empty;

    public string GetSha256Hash(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentNullException(nameof(password), "Password cannot be null or empty.");
        }

        using SHA256 sha256 = SHA256.Create();
        var passwordBytes = Encoding.UTF8.GetBytes(password);
        var hashBytes = sha256.ComputeHash(passwordBytes);

        var hashString = new StringBuilder();
        foreach (var b in hashBytes)
        {
            hashString.Append(b.ToString("x2"));
        }

        return hashString.ToString();
    }

    public bool VerifyPassword(string? passwordToCheck)
    {
        if (string.IsNullOrEmpty(passwordToCheck)) return false;
        return GetSha256Hash(Password) == passwordToCheck;
    }
}