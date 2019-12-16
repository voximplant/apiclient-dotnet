using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelDialogflowKeySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelDialogflowKeySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Remove key.
        */
        [Fact]
        public void DelDialogflowKey()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelDialogflowKey(new DelDialogflowKeyRequest 
                {
                    DialogflowKeyId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}