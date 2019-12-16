using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetQueueInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetQueueInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Change the queue name.
        */
        [Fact]
        public void SetQueueInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetQueueInfo(new SetQueueInfoRequest 
                {
                    AcdQueueId = 1,
                    NewAcdQueueName = "support",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}