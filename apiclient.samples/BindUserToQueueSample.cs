using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindUserToQueueSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public BindUserToQueueSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Bind three users to one queue.
        */
        [Fact]
        public void BindUserToQueue()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.BindUserToQueue(new BindUserToQueueRequest 
                {
                    ApplicationId = 1,
                    UserId = new Argument<long>(new[] {12L, 987L, 456L}),
                    AcdQueueName = new Argument<string>("myqueue"),
                    Bind = true,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}