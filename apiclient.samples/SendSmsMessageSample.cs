using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SendSmsMessageSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SendSmsMessageSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Send the SMS message with text "Test message" from the phone number
        * 447443332211 to the phone number 447443332212.
        */
        [Fact]
        public void SendSmsMessage()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SendSmsMessage(new SendSmsMessageRequest 
                {
                    Source = "447443332211",
                    Destination = "447443332212",
                    SmsBody = "Test message",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}