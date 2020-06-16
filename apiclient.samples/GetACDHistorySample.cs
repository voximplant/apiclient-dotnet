using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDHistorySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetACDHistorySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the two ACD session history records from the 2012-01-01 00:00:00
        * to the 2014-04-01 00:00:00
        */
        [Fact]
        public void GetACDHistory()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2012, 1, 1, 0, 0, 0)
                    .ToUniversalTime();

                var toDate = new DateTime(2014, 1, 1, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetACDHistory(new GetACDHistoryRequest 
                {
                    FromDate = fromDate,
                    ToDate = toDate,
                    WithEvents = true,
                    Count = 2,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}