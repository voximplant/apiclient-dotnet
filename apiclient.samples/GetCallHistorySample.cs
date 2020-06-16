using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCallHistorySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetCallHistorySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the first call session history record with calls and record URLs
        * from the 2020-02-25 00:00:00 UTC to the 2020-02-26 00:00:00 UTC
        */
        [Fact]
        public void GetCallHistory()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2020, 2, 25, 0, 0, 0)
                    .ToUniversalTime();

                var toDate = new DateTime(2020, 2, 26, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetCallHistory(new GetCallHistoryRequest 
                {
                    FromDate = fromDate,
                    ToDate = toDate,
                    Count = 1,
                    WithCalls = true,
                    WithRecords = true,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}