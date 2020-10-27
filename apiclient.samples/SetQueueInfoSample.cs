using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetQueueInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetQueueInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetQueueInfo()
        {
            // Change the queue name.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetQueueInfo(
                    acdQueueId: 1L,
                    newAcdQueueName: "support"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}