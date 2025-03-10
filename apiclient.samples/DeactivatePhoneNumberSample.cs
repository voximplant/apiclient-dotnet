using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeactivatePhoneNumberSample
    {
        private ITestOutputHelper Console { get; }
        
        public DeactivatePhoneNumberSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DeactivatePhoneNumber()
        {
            // Deactivate the phone 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DeactivatePhoneNumber(
                    phoneId: "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}