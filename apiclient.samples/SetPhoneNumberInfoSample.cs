using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetPhoneNumberInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetPhoneNumberInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetPhoneNumberInfo()
        {
            // Enable the auto charging.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetPhoneNumberInfo(
                    phoneId: "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}