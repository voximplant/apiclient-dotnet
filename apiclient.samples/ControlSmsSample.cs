using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ControlSmsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public ControlSmsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Disable work with SMS for phone number 447443332211.
        */
        [Fact]
        public void ControlSms()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.ControlSms(new ControlSmsRequest 
                {
                    PhoneNumber = "447443332211",
                    Command = "disable",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}