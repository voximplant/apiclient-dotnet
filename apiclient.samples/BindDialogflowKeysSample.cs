using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindDialogflowKeysSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public BindDialogflowKeysSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Bind a Dialogflow key to the application.
        */
        [Fact]
        public void BindDialogflowKeys()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.BindDialogflowKeys(new BindDialogflowKeysRequest 
                {
                    DialogflowKeyId = 1,
                    ApplicationId = new Argument<long>(1L),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}