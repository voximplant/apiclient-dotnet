using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRegionsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetRegionsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get regions with city AACHEN.
        */
        [Fact]
        public void GetRegions()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetRegions(new GetRegionsRequest 
                {
                    CountryCode = "DE",
                    PhoneCategoryName = "GEOGRAPHIC",
                    CityName = "AACHEN",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}