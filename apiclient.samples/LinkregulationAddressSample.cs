using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class LinkregulationAddressSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public LinkregulationAddressSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Link regulation address to phone number
        */
        [Fact]
        public void LinkregulationAddress()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.LinkregulationAddress(new LinkregulationAddressRequest 
                {
                    RegulationAddressId = 1,
                    PhoneId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}