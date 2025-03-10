using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDQueueStatisticsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetACDQueueStatisticsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetACDQueueStatistics()
        {
            // Get WT and TT statistics for the queue from the specified date.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetACDQueueStatistics(
                    new DateTime(2021, 4, 8, 0, 0, 0),
                    toDate: new DateTime(2021, 4, 10, 0, 0, 0),
                    acdQueueId: "54",
                    report: "WT;TT",
                    aggregation: "day"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}