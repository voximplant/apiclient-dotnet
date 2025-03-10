using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindUserToQueueSample
    {
        private ITestOutputHelper Console { get; }
        
        public BindUserToQueueSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void BindUserToQueue()
        {
            // Bind three users to one queue.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.BindUserToQueue(
                    true,
                    applicationId: 1L,
                    userId: "12;987;456",
                    acdQueueName: "myqueue"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}