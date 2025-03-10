using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCallListDetailsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetCallListDetailsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetCallListDetails()
        {
            // Get all lists registered by user.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetCallListDetails(
                    1L,
                    output: "json"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}