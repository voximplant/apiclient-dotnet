using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class TransferMoneyToChildAccountSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public TransferMoneyToChildAccountSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Transfer the all money from the child account 1 to the parent account.
        */
        [Fact]
        public void TransferMoneyToChildAccount()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.TransferMoneyToChildAccount(new TransferMoneyToChildAccountRequest 
                {
                    ChildAccountId = new Argument<long>(1L),
                    Amount = -10000000m,
                    StrictMode = false,
                    Currency = "USD",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}