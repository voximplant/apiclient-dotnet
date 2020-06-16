using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetDialogflowKeysSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetDialogflowKeysSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get push credentials.
        */
        [Fact]
        public void GetDialogflowKeys()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetDialogflowKeys(new GetDialogflowKeysRequest 
                {
                    DialogflowKeyId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}