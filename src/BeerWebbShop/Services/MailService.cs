using System;
using System.Net.Mail;

namespace BeerWebbShop.Services
{
    public class MailService
    {
        public void SendEmail(string email, string nickName)
        {
            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                var mail = new MailMessage
                {
                    From = new MailAddress("emelie2018@hotmail.com")
                };


                mail.To.Add(email);
                mail.Subject = "Funny Beer";
                mail.Body = "Your order has been confirmd";
                SmtpServer.Port = 587;

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential("emelie2018", "emelie1234");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception)
            {
                //ignore
            }
        }
    }
}
