using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetHistoryReportsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetHistoryReportsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetHistoryReports()
        {
            // Get all the reports.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetHistoryReports(
                    historyType: "all"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}