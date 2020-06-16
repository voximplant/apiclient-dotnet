using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetTransactionHistorySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetTransactionHistorySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the three transactions record from the 2012-01-01 00:00:00 UTC to
        * the 2014-01-01 00:00:00 UTC with the 'gift' or 'money_distribution'
        * types.
        */
        [Fact]
        public void GetTransactionHistory()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2012, 1, 1, 0, 0, 0)
                    .ToUniversalTime();

                var toDate = new DateTime(2014, 1, 1, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetTransactionHistory(new GetTransactionHistoryRequest 
                {
                    FromDate = fromDate,
                    ToDate = toDate,
                    Count = 3,
                    TransactionType = new Argument<string>(new[] {"gift", "money_distribution"}),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}