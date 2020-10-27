using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPhoneNumberRegionsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetPhoneNumberRegionsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetPhoneNumberRegions()
        {
            // Get the Russian regions of the phone numbers.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetPhoneNumberRegions(
                    "RU",
                    "GEOGRAPHIC"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}