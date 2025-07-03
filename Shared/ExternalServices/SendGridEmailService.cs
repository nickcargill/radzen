//using Destination.Data;
//using Destination.Shared.DTO;
//using Microsoft.Extensions.Options;
//using SendGrid;
//using SendGrid.Helpers.Mail;
//using System.Net.Mail;

//namespace Destination.Shared.ExternalServices
//{
//    public class SendGridEmailService
//    {
//        private readonly SendGridEmailOptions _emailOptions;

//        public SendGridEmailService(IOptions<SendGridEmailOptions> emailOptions)
//        {
//            _emailOptions = emailOptions.Value;
//        }

//        public async Task SendViaSendGridAsync(string toEmail, string subject, string htmlContent)
//        {
//            var client = new SendGridClient(_emailOptions.ApiKey);
//            var from = new EmailAddress(_emailOptions.FromEmail, _emailOptions.FromName);
//            var to = new EmailAddress(toEmail);
//            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent: null, htmlContent);
//            await client.SendEmailAsync(msg);
//        }
//    }
//}
