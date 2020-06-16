using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSmsHistorySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetSmsHistorySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get messages that had been sent to number 12345678222 starting from
        * March 1, 2019. Number of resulting rows is limited to 2.
        */
        [Fact]
        public void GetSmsHistory()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2019, 3, 1, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetSmsHistory(new GetSmsHistoryRequest 
                {
                    DestinationNumber = "12345678222",
                    FromDate = fromDate,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}