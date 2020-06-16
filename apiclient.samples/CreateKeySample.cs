using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class CreateKeySample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public CreateKeySample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Create a key pair.
        */
        [Fact]
        public void CreateKey()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.CreateKey(new CreateKeyRequest 
                {
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}