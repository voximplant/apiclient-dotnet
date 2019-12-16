using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindPushCredentialSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public BindPushCredentialSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Bind the push credential to the application.
        */
        [Fact]
        public void BindPushCredential()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.BindPushCredential(new BindPushCredentialRequest 
                {
                    PushCredentialId = new Argument<long>(1L),
                    ApplicationId = new Argument<long>(1L),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}