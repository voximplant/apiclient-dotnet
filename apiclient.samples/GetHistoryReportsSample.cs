using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetHistoryReportsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetHistoryReportsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get all the reports.
        */
        [Fact]
        public void GetHistoryReports()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetHistoryReports(new GetHistoryReportsRequest 
                {
                    HistoryType = new Argument<string>(),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}