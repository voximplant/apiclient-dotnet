using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDQueueStatisticsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetACDQueueStatisticsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get statistics for all queues from the specified date
        */
        [Fact]
        public void GetACDQueueStatistics()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2017, 1, 1, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetACDQueueStatistics(new GetACDQueueStatisticsRequest 
                {
                    FromDate = fromDate,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}