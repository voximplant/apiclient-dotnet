using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDStateSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetACDStateSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the state of the queue 1.
        */
        [Fact]
        public void GetACDState()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetACDState(new GetACDStateRequest 
                {
                    AcdQueueId = new Argument<long>(1L),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}