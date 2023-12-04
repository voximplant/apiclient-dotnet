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
            // Get AC and TT statistics for two operators and the queue from the
            // specified date.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetACDOperatorStatistics(
                    new DateTime(2021, 4, 8, 0, 0, 0),
                    "1768;1769",
                    toDate: new DateTime(2021, 4, 10, 0, 0, 0),
                    acdQueueId: "54",
                    report: "AC;TT",
                    aggregation: "day"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}