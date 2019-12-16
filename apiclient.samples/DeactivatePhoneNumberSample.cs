using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeactivatePhoneNumberSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DeactivatePhoneNumberSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Deactivate the phone 1.
        */
        [Fact]
        public void DeactivatePhoneNumber()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DeactivatePhoneNumber(new DeactivatePhoneNumberRequest 
                {
                    PhoneId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}