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
            // Get statistics for all queues from the specified date

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetACDQueueStatistics(
                    new DateTime(2017, 1, 1, 0, 0, 0)
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}