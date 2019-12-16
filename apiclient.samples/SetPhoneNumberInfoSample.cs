using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetPhoneNumberInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetPhoneNumberInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Enable the auto charging.
        */
        [Fact]
        public void SetPhoneNumberInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetPhoneNumberInfo(new SetPhoneNumberInfoRequest 
                {
                    PhoneId = new Argument<long>(1L),
                    AutoCharge = true,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}