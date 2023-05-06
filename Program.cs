
using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fromMail = "javlonrahmatullayev07@gmail.com";
            string fromPassword = "qisyjgtdzudxdzoy";

            MailMessage message = new MailMessage();
            message.From= new MailAddress(fromMail);
            message.Subject="Test Subjects";
            message.To.Add(new MailAddress("javlonrahmatullayev07@gmail.com"));
            message.Body = "<html><body> Test Body </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}
