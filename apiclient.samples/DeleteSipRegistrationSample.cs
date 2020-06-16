using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeleteSipRegistrationSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DeleteSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Delete SIP registration with id 1.
        */
        [Fact]
        public void DeleteSipRegistration()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DeleteSipRegistration(new DeleteSipRegistrationRequest 
                {
                    SipRegistrationId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}