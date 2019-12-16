using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StopCallListProcessingSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public StopCallListProcessingSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Cancel list with id = 1
        */
        [Fact]
        public void StopCallListProcessing()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.StopCallListProcessing(new StopCallListProcessingRequest 
                {
                    ListId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}