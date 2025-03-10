using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPhoneNumberCountryStatesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetPhoneNumberCountryStatesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetPhoneNumberCountryStates()
        {
            // Get the USA states.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetPhoneNumberCountryStates(
                    "US",
                    "GEOGRAPHIC"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}