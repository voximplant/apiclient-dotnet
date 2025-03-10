using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPhoneNumbersSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetPhoneNumbersSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetPhoneNumbers()
        {
            // Get two attached phone numbers.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetPhoneNumbers(
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}