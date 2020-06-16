using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddQueueSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddQueueSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add a new ACD queue for the application 1.
        */
        [Fact]
        public void AddQueue()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddQueue(new AddQueueRequest 
                {
                    ApplicationId = 1,
                    AcdQueueName = "myqueue",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}