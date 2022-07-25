using MailKit.Net.Smtp;
using MimeKit;
using Statanly.Web.Infrastructure.Interfaces;
using Statanly.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statanly.Web.Infrastructure.Implementation
{
    public class MessageService : IMessageService
    {
        public async Task<string> SendAsync(MessageViewModel mail)
        {
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 465, true);
                await client.AuthenticateAsync("sergey@statanly.com", "Xjt367Mj2276");

                var emailMessage = this.GetMimeMessage(mail);
                if (emailMessage != null)
                {
                    await client.SendAsync(emailMessage);
                }
                await client.DisconnectAsync(true);
            }
            return "";
        }

        public async Task<string> SendAsync(NewsletterViewModel mails)
        {
            var resume = "";
            var send = 0;
            var error = 0;
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync("smtp.yandex.ru", 465, true);
                    //await client.AuthenticateAsync("sergey@statanly.com", "xjt367mj2276");
                    await client.AuthenticateAsync(mails.FromEmail, mails.Password);

                }
                catch (Exception ex)
                {
                    resume += ex.Message;
                    return resume;
                }
                var mimeMessages = this.GetMimeMessageNewsletter(mails);
                foreach (var emailMessage in mimeMessages)
                {
                    try
                    {
                        if (emailMessage != null)
                        {
                            await client.SendAsync(emailMessage);
                            send++;
                        }
                    }
                    catch (Exception ex)
                    {
                        error++;
                        resume += ex.Message + " " + "Email: " + emailMessage.To + "\r\n";
                        continue;

                    }
                }
                await client.DisconnectAsync(true);
            }
            resume += "Отправлено " + send + " " + "ошибок " + error;
            return resume;
        }
        private MimeMessage GetMimeMessage(MessageViewModel mail)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(mail.Email, "sergey@statanly.com"));
            emailMessage.To.Add(new MailboxAddress("", "sergey@statanly.com"));
            emailMessage.Subject = mail.Subject;
            //emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html){Text = mail.Body};
            var builder = new BodyBuilder();
            // Set the plain-text version of the message text
            builder.HtmlBody = "<p>" + mail.Email + "</p>" + "<p>" + mail.Phone + "</p>" + "<p>" + mail.Name + "</p>" + "<p>" + "Сообщение:" + "</p>" + "<p>" + mail.Text + "</p>";
            // Now we just need to set the message body and we're done
            emailMessage.Body = builder.ToMessageBody();
            return emailMessage;
        }
        private MimeMessage[] GetMimeMessageNewsletter(NewsletterViewModel mails)
        {
            var list = new List<MimeMessage>();
            foreach (var email in mails.EmailList)
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("Statanly Technologies", mails.FromEmail));
                emailMessage.To.Add(new MailboxAddress("", email));
                emailMessage.Subject = mails.Subject;
                //emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html){Text = mail.Body};
                var builder = new BodyBuilder();
                // Set the plain-text version of the message text
                builder.HtmlBody = mails.Text;
                // Now we just need to set the message body and we're done
                emailMessage.Body = builder.ToMessageBody();
                list.Add(emailMessage);
            }
            return list.ToArray();
        }
    }
}
