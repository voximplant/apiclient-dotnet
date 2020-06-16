using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetNewPhoneNumbersSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetNewPhoneNumbersSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the two new fixed Russian phone numbers at max.
        */
        [Fact]
        public void GetNewPhoneNumbers()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetNewPhoneNumbers(new GetNewPhoneNumbersRequest 
                {
                    CountryCode = "RU",
                    PhoneCategoryName = "GEOGRAPHIC",
                    PhoneRegionId = 1,
                    Count = 2,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}