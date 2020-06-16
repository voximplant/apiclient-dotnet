using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDOperatorStatusStatisticsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetACDOperatorStatusStatisticsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get statistics for the 'READY' and 'ONLINE' statuses of all
        * operators; grouped by operators.
        */
        [Fact]
        public void GetACDOperatorStatusStatistics()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2019, 5, 20, 11, 0, 0)
                    .ToUniversalTime();

                var toDate = new DateTime(2019, 5, 20, 13, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetACDOperatorStatusStatistics(new GetACDOperatorStatusStatisticsRequest 
                {
                    FromDate = fromDate,
                    ToDate = toDate,
                    AcdStatus = new Argument<string>(new[] {"READY", "ONLINE"}),
                    UserId = new Argument<string>(),
                    Aggregation = "hour",
                    Group = "user",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}