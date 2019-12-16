using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCurrencyRateSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetCurrencyRateSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the current currency rates: RUR/USD and EUR/USD.
        */
        [Fact]
        public void GetCurrencyRate()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetCurrencyRate(new GetCurrencyRateRequest 
                {
                    Currency = new Argument<string>(new[] {"RUR", "EUR"}),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}