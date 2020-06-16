using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRegulationsAddressSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetRegulationsAddressSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Search regulation address with ID = 1
        */
        [Fact]
        public void GetRegulationsAddress()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetRegulationsAddress(new GetRegulationsAddressRequest 
                {
                    RegulationAddressId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}