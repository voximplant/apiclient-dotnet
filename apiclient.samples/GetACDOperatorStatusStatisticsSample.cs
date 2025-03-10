using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDOperatorStatusStatisticsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetACDOperatorStatusStatisticsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetACDOperatorStatusStatistics()
        {
            // Get statistics for the 'READY' and 'ONLINE' statuses of all
            // operators; grouped by operators.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetACDOperatorStatusStatistics(
                    new DateTime(2019, 5, 20, 11, 0, 0),
                    "all",
                    toDate: new DateTime(2019, 5, 20, 13, 0, 0),
                    acdStatus: "READY;ONLINE",
                    aggregation: "hour",
                    group: "user"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}