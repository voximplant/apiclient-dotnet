using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDHistorySample
    {
        private ITestOutputHelper Console { get; }
        
        public GetACDHistorySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetACDHistory()
        {
            // Get the two ACD session history records from the 2012-01-01 00:00:00
            // to the 2014-04-01 00:00:00.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetACDHistory(
                    new DateTime(2012, 1, 1, 0, 0, 0),
                    new DateTime(2014, 1, 1, 0, 0, 0),
                    withEvents: true,
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}