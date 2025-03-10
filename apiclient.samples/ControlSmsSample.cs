using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ControlSmsSample
    {
        private ITestOutputHelper Console { get; }
        
        public ControlSmsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void ControlSms()
        {
            // Enable work with SMS for phone number 447443332211.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.ControlSms(
                    "447443332211",
                    "enable"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}