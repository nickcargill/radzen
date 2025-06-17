//using SendGrid;
//using SendGrid.Helpers.Mail;
//using System.Net.Mail;

//namespace Destination.Shared.ExternalServices
//{
//    public class SendGridEmailService
//    {
//        private readonly SendGridClient client;
//        private readonly string fromEmail;

//        //public SendGridEmailService(IConfiguration configuration)
//        //{
//        //    client = new SendGridClient(configuration["SendGrid:ApiKey"]);
//        //    fromEmail = configuration["SendGrid:FromEmail"];
//        //}

//        //public async Task SendEmailAsync(string to, string subject, string body)
//        //{
//        //    var msg = new SendGridMessage
//        //    {
//        //        From = new EmailAddress(fromEmail),
//        //        Subject = subject,
//        //        HtmlContent = body
//        //    };
//        //    msg.AddTo(new EmailAddress(to));
//        //    await client.SendEmailAsync(msg);
//        //}
//    }
//}
