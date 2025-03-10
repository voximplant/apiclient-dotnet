using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AttachPhoneNumberSample
    {
        private ITestOutputHelper Console { get; }
        
        public AttachPhoneNumberSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AttachPhoneNumber()
        {
            // Attach a US phone number to the account 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AttachPhoneNumber(
                    "US",
                    "GEOGRAPHIC",
                    1100L,
                    countryState: "CA",
                    phoneCount: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}