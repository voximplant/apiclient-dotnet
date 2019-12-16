using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StartNextCallTaskSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public StartNextCallTaskSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Start next call task
        */
        [Fact]
        public void StartNextCallTask()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.StartNextCallTask(new StartNextCallTaskRequest 
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