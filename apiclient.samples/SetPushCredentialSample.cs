using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetPushCredentialSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetPushCredentialSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Modify credentials.
        */
        [Fact]
        public void SetPushCredential()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetPushCredential(new SetPushCredentialRequest 
                {
                    PushCredentialId = 1,
                    CertPassword = "1234567",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}