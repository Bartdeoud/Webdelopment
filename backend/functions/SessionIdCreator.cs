using System.Security.Cryptography;
using System.Web;

public class SessionIdCreator{
public static string HashString()
{
    string salt = "C8LSrwcvtP9I";
    // Uses SHA256 to create the hash
    using (var sha = new SHA256Managed())
    {
        // Convert the string to a byte array first, to be processed
        byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(DateTime.Now + salt);
        byte[] hashBytes = sha.ComputeHash(textBytes);
        
        // Convert back to a string, removing the '-' that BitConverter adds
        string hash = BitConverter
            .ToString(hashBytes)
            .Replace("-", String.Empty);

        return hash;
    }
}
}