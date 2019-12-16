using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddPushCredentialSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddPushCredentialSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add new Google credentials.
        */
        [Fact]
        public void AddPushCredential()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddPushCredential(new AddPushCredentialRequest 
                {
                    PushProviderName = "GOOGLE",
                    SenderId = "704777431520",
                    ServerKey = "AAAAjM-LQsc:APA91bGyCb5WhcGtaM-RaOI1GqWps1Uh9K-YoY75HIBy-En-4piH4c6_50gIEbSaCfuDrsLNfyZCvteiu6EjxA_rEBOvlc4xZ30uiGgbuM_jdT6y6Ku55OwnCyIxRNznvmx1jkkLexSU",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}