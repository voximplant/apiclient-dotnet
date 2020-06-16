using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ActivateCallerIDSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public ActivateCallerIDSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Activate the callerID by the verification code.
        */
        [Fact]
        public void ActivateCallerID()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.ActivateCallerID(new ActivateCallerIDRequest 
                {
                    CalleridId = 1,
                    VerificationCode = "12345",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}