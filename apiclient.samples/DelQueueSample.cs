using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelQueueSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelQueueSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelQueue()
        {
            // Delete the ACD queue 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelQueue(
                    acdQueueId: "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}