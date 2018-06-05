using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace WPFSentMail.Module
{
   public class Helper
    {
        public string sendMail(string to, string subject)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("alfar.latypov@gmail.com", "Zloi_Tatarin");

            msg.To.Add(to); // komu 
            msg.Subject = subject; //tema
            msg.Body = "test Body";

            //--------------------------------------------

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true; //
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false; // ispolzovat po umol4aniu avtorizachiu?// govorim net
            smtp.Credentials = new NetworkCredential("alfar.latypov@gmail.com", "Zarina2020");

            try
            {
                smtp.Send(msg);
                return "Сообщение отправлено";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
