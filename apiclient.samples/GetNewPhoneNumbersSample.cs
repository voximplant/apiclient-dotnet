using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetNewPhoneNumbersSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetNewPhoneNumbersSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetNewPhoneNumbers()
        {
            // Get the two new fixed Russian phone numbers at max.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetNewPhoneNumbers(
                    "RU",
                    "GEOGRAPHIC",
                    1L,
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}