using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPhoneNumberRegionsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetPhoneNumberRegionsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the Russian regions of the phone numbers.
        */
        [Fact]
        public void GetPhoneNumberRegions()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetPhoneNumberRegions(new GetPhoneNumberRegionsRequest 
                {
                    CountryCode = "RU",
                    PhoneCategoryName = "GEOGRAPHIC",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}