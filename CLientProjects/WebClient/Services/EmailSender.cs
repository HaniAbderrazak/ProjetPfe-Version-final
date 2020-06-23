using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebClient.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {

        public Task SendEmailAsync(string Name, string Email, string Message)
        {

            try
            {
                // Credentials
                var credentials = new NetworkCredential("grandhanoss@gmail.com","Hani975393011");

                // Mail message
                var mail = new MailMessage("grandhanoss@gmail.com", Name)
                {
                 
                  
                    Body = Message,
                    
                };
         
                
                mail.IsBodyHtml = true;
                

                // Smtp client
                var client = new SmtpClient()
                {
                    
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                
                client.Send(mail);

                return Task.CompletedTask;
            }
            catch (System.Exception e)
            {
                return Task.FromException(e);
            }

        }

       
    }
    
}
