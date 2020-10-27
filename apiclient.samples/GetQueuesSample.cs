using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetQueuesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetQueuesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetQueues()
        {
            // Get the two queues.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetQueues(
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}