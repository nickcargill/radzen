//using Destination.Shared.DTO;
//using Microsoft.Extensions.Options;
//using Twilio;
//using Twilio.Rest.Api.V2010.Account;
//using Twilio.Types;

//namespace Destination.Services
//{
//    public class TwilioSmsService
//    {
//        private readonly TwilioSmsOptions _options;

//        public TwilioSmsService(IOptions<TwilioSmsOptions> options)
//        {
//            _options = options.Value;

//            if (string.IsNullOrWhiteSpace(_options.AccountSid) ||
//                string.IsNullOrWhiteSpace(_options.AuthToken) ||
//                string.IsNullOrWhiteSpace(_options.FromNumber))
//            {
//                throw new ArgumentException("Twilio configuration is invalid.");
//            }

//            TwilioClient.Init(_options.AccountSid, _options.AuthToken);
//        }

//        public async Task<string> SendSmsAsync(string toPhoneNumber, string messageBody)
//        {
//            try
//            {
//                var message = await MessageResource.CreateAsync(
//                    to: new PhoneNumber(toPhoneNumber),
//                    from: new PhoneNumber(_options.FromNumber),
//                    body: messageBody
//                );

//                return message.Sid; // Success SID
//            }
//            catch (Exception ex)
//            {
//                return $"Error sending SMS: {ex.Message}";
//            }
//        }
//    }
//}