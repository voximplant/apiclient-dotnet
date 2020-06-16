using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindSipRegistrationSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public BindSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Unbind the user with id 123 from all SIP registrations.
        */
        [Fact]
        public void BindSipRegistration()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.BindSipRegistration(new BindSipRegistrationRequest 
                {
                    UserId = 123,
                    Bind = false,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}