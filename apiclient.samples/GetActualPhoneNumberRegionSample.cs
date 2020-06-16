using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetActualPhoneNumberRegionSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetActualPhoneNumberRegionSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the Germany region of the phone numbers.
        */
        [Fact]
        public void GetActualPhoneNumberRegion()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetActualPhoneNumberRegion(new GetActualPhoneNumberRegionRequest 
                {
                    CountryCode = "DE",
                    PhoneCategoryName = "GEOGRAPHIC",
                    PhoneRegionId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}