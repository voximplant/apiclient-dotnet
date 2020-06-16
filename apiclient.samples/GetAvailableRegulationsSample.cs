using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAvailableRegulationsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetAvailableRegulationsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Search available regulation address
        */
        [Fact]
        public void GetAvailableRegulations()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetAvailableRegulations(new GetAvailableRegulationsRequest 
                {
                    CountryCode = "DE",
                    PhoneCategoryName = "GEOGRAPHIC",
                    PhoneRegionCode = "643",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}