using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetActualPhoneNumberRegionSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetActualPhoneNumberRegionSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetActualPhoneNumberRegion()
        {
            // Get the Germany region of the phone numbers.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetActualPhoneNumberRegion(
                    "DE",
                    "GEOGRAPHIC",
                    1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}