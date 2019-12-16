using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetMoneyAmountToChargeSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetMoneyAmountToChargeSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the recommended money amount to charge in USD.
        */
        [Fact]
        public void GetMoneyAmountToCharge()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetMoneyAmountToCharge(new GetMoneyAmountToChargeRequest 
                {
                    Currency = "USD",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}