using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetApplicationInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetApplicationInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Change the application name.
        */
        [Fact]
        public void SetApplicationInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetApplicationInfo(new SetApplicationInfoRequest 
                {
                    ApplicationId = 1,
                    ApplicationName = "myapp11",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}