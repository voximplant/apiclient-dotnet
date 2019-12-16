using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPhoneNumberCategoriesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetPhoneNumberCategoriesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the phone number categories in Russia.
        */
        [Fact]
        public void GetPhoneNumberCategories()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetPhoneNumberCategories(new GetPhoneNumberCategoriesRequest 
                {
                    CountryCode = "RU",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}