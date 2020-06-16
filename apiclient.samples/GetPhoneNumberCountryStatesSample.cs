using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPhoneNumberCountryStatesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetPhoneNumberCountryStatesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the AL (Alabama) state info.
        */
        [Fact]
        public void GetPhoneNumberCountryStates()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetPhoneNumberCountryStates(new GetPhoneNumberCountryStatesRequest 
                {
                    CountryCode = "US",
                    PhoneCategoryName = "GEOGRAPHIC",
                    CountryState = "AL",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}