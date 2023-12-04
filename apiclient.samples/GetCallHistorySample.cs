using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCallHistorySample
    {
        private ITestOutputHelper Console { get; }
        
        public GetCallHistorySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetCallHistory()
        {
            // Get the first call session history record with calls and record URLs
            // from the 2020-02-25 00:00:00 UTC to the 2020-02-26 00:00:00 UTC.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetCallHistory(
                    new DateTime(2020, 2, 25, 0, 0, 0),
                    new DateTime(2020, 2, 26, 0, 0, 0),
                    count: 1L,
                    withCalls: true,
                    withRecords: true
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}