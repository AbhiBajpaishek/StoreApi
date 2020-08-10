using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace StoreApiPoc.Areas.Helper_Class
{
    public class EmailVerification
    {
        public static bool SendEmailOTP(int OTP,string email,string name)
        {
            try
            {
                var senderEmail = new MailAddress("abhishek782@live.com", "abcElectronics");
                var receiverEmail = new MailAddress(email, name);
                var password = "Smile@1a";
                var sub = "OTP Verification for registration at abcElectronics";
                var body = "Please Enter this OTP /n/n/n " + OTP;
                var smtp = new SmtpClient
                {
                    Host = "smtp.live.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = sub,
                    Body = body
                })
                {
                    smtp.Send(mess);
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }
    }
}