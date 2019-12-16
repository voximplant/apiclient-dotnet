using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeleteKeySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DeleteKeySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        
        [Fact]
        public void DeleteKey()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DeleteKey(new DeleteKeyRequest 
                {
                    KeyId = "ab81c66e-570e-4446-9af9-105269dfafca",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}