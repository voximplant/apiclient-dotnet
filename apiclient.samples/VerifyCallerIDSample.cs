using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class VerifyCallerIDSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public VerifyCallerIDSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Verify the callerID 1.
        */
        [Fact]
        public void VerifyCallerID()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.VerifyCallerID(new VerifyCallerIDRequest 
                {
                    CalleridId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}