using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class A2PSendSmsSample
    {
        private ITestOutputHelper Console { get; }
        
        public A2PSendSmsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void A2PSendSms()
        {
            // Send the SMS message with the text "Test message" from the phone
            // number 447443332211 to the phone numbers 447443332212 and
            // 447443332213.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.A2PSendSms(
                    "447443332211",
                    "447443332212;447443332213",
                    "Test message"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}