using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDOperatorStatisticsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetACDOperatorStatisticsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetACDOperatorStatistics()
        {
            // Get statistics for all operators and all queues from the specified
            // date

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetACDOperatorStatistics(
                    new DateTime(2017, 1, 1, 0, 0, 0),
                    "all"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}