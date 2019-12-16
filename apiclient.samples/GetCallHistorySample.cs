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
        * Get the first call session history record from the 2012-01-01
        * 00:00:00 UTC to the 2014-01-01 00:00:00 UTC
        */
        [Fact]
        public void GetCallHistory()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2012, 1, 1, 0, 0, 0)
                    .ToUniversalTime();

                var toDate = new DateTime(2014, 1, 1, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetCallHistory(new GetCallHistoryRequest 
                {
                    FromDate = fromDate,
                    ToDate = toDate,
                    Count = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}