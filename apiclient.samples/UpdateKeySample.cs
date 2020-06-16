using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class UpdateKeySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public UpdateKeySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Create a new subuser for account_id = 1.
        */
        [Fact]
        public void UpdateKey()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.UpdateKey(new UpdateKeyRequest 
                {
                    KeyId = "ab98c70e-573e-4446-9af9-105269dfafca",
                    Description = "test_desc",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}