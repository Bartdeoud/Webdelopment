using System.Security.Cryptography;
using System.Web;

public class SessionIdCreator{
public static string HashString()
{
    Random random = new Random();
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, 25)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}