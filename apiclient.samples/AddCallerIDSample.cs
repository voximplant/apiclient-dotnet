using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddCallerIDSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddCallerIDSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        
        [Fact]
        public void AddCallerID()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddCallerID(new AddCallerIDRequest 
                {
                    CalleridNumber = "74953331122",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}