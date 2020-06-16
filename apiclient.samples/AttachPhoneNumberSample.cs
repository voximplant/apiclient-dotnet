using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AttachPhoneNumberSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AttachPhoneNumberSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Attach the '74953332211' and '74953332299' phone numbers to the
        * account 1.
        */
        [Fact]
        public void AttachPhoneNumber()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AttachPhoneNumber(new AttachPhoneNumberRequest 
                {
                    CountryCode = "RU",
                    PhoneCategoryName = "GEOGRAPHIC",
                    PhoneRegionId = 4,
                    PhoneNumber = new Argument<string>("74953332211"),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}