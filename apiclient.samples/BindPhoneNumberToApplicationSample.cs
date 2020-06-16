using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindPhoneNumberToApplicationSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public BindPhoneNumberToApplicationSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Bind the phone 1 to the application 1.
        */
        [Fact]
        public void BindPhoneNumberToApplication()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.BindPhoneNumberToApplication(new BindPhoneNumberToApplicationRequest 
                {
                    PhoneId = new Argument<long>(1L),
                    ApplicationId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}