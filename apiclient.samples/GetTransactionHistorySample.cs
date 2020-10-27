using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetTransactionHistorySample
    {
        private ITestOutputHelper Console { get; }
        
        public GetTransactionHistorySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetTransactionHistory()
        {
            // Get the three transactions record from the 2012-01-01 00:00:00 UTC to
            // the 2014-01-01 00:00:00 UTC with the 'gift' or 'money_distribution'
            // types.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetTransactionHistory(
                    new DateTime(2012, 1, 1, 0, 0, 0),
                    new DateTime(2014, 1, 1, 0, 0, 0),
                    count: 3L,
                    transactionType: "gift;money_distribution"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}