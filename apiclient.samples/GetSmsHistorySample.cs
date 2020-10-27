using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSmsHistorySample
    {
        private ITestOutputHelper Console { get; }
        
        public GetSmsHistorySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetSmsHistory()
        {
            // Get messages that had been sent to number 12345678222 starting from
            // March 1, 2019. Number of resulting rows is limited to 2.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetSmsHistory(
                    destinationNumber: "12345678222",
                    fromDate: new DateTime(2019, 3, 1, 0, 0, 0)
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}