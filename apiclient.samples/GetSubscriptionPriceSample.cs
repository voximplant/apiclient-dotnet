using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSubscriptionPriceSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetSubscriptionPriceSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the SIP registration subscription template.
        */
        [Fact]
        public void GetSubscriptionPrice()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetSubscriptionPrice(new GetSubscriptionPriceRequest 
                {
                    SubscriptionTemplateType = "SIP_REGISTRATION",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}