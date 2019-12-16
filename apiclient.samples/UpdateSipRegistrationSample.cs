using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class UpdateSipRegistrationSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public UpdateSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Bind SIP registration with id 1 to the application with id 123.
        */
        [Fact]
        public void UpdateSipRegistration()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.UpdateSipRegistration(new UpdateSipRegistrationRequest 
                {
                    SipRegistrationId = 1,
                    ApplicationId = 123,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}