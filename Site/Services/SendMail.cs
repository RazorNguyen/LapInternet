using Site.Model;
using System;
using System.Net;
using System.Net.Mail;

namespace Site.Services
{
    public class Mail
    {
        private RegisterViewModel _model;
        public Mail(RegisterViewModel model)
        {
            _model = model;
        }

        public void Send()
        {
            string smtpAddress = "smtp.mail.yahoo.com";
            int portNumber = 587;
            string emailFrom = "nv_manh@yahoo.com";
            string password = "1q2w3e4r5t";
            string emailTo = AppConfig.Email;
            string subject = "Đăng Kí Internet Online - " + DateTime.Now.ToString();
            string body = "Hi Tuyết mập, Có Người đăng kí internet nè: " + string.Format("Tên: {0}, SDT: {1}", _model.Name, _model.Phone);

            using (var mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                using (var smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}