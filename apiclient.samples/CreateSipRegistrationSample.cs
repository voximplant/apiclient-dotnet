using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class CreateSipRegistrationSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public CreateSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Create SIP registration.
        */
        [Fact]
        public void CreateSipRegistration()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.CreateSipRegistration(new CreateSipRegistrationRequest 
                {
                    SipUsername = "JohnGalt",
                    Proxy = "localhost",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}