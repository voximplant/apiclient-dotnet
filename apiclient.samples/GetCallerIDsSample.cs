using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCallerIDsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetCallerIDsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetCallerIDs()
        {
            // Get the two callerIDs.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetCallerIDs(
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}