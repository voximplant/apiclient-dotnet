using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddQueueSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddQueueSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddQueue()
        {
            // Add a new ACD queue for the application 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddQueue(
                    "myqueue",
                    applicationId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}