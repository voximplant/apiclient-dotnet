using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetACDStateSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetACDStateSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetACDState()
        {
            // Get the state of the queue 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetACDState(
                    acdQueueId: "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}