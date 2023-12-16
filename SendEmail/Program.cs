using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string senderEmail = "ramadhaniabidin12@gmail.com";
        string senderPassword = "lopg gggw mnrj xwrs";

        MailMessage message = new MailMessage();
        message.From = new MailAddress(senderEmail);
        message.Subject = "Testing send second email";
        message.To.Add(new MailAddress("my.second.ramadhaniabidin12@gmail.com"));
        message.Body = "<html><body> Test Body </body></html>";
        message.IsBodyHtml = true;

        var smtpClient = new SmtpClient("smtp.gmail.com");
        smtpClient.Port = 587;
        smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
        smtpClient.EnableSsl = true;
        smtpClient.Send(message);
    }
}