using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SendSmsMessageSample
    {
        private ITestOutputHelper Console { get; }
        
        public SendSmsMessageSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SendSmsMessage()
        {
            // Send the SMS message with the text "Test message" from the phone
            // number 447443332211 to the phone number 447443332212.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SendSmsMessage(
                    "447443332211",
                    "447443332212",
                    "Test message"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}