using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetResourcePriceSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetResourcePriceSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the price to call to the phone number 79263332211
        */
        [Fact]
        public void GetResourcePrice()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetResourcePrice(new GetResourcePriceRequest 
                {
                    ResourceType = new Argument<string>("PSTNOUT"),
                    ResourceParam = new Argument<string>("79263332211"),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}