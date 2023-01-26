using System.Net;
using System.Net.Mail;

public class MailService{
    public static void sendMail(string email){
        var smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("laakentertainment@gmail.com", "vrubkeyyqxsnjiji"),
            EnableSsl = true,
        };

        smtpClient.Send("laakentertainment@gmail.com", email, "subject", "body");
    }
}
    

