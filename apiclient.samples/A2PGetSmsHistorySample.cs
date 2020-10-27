using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class A2PGetSmsHistorySample
    {
        private ITestOutputHelper Console { get; }
        
        public A2PGetSmsHistorySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void A2PGetSmsHistory()
        {
            // Get messages that had been sent to number 12345678222 starting from
            // March 1, 2019. Number of resulting rows is limited to 2.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.A2PGetSmsHistory(
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