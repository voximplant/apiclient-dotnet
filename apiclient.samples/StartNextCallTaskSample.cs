using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StartNextCallTaskSample
    {
        private ITestOutputHelper Console { get; }
        
        public StartNextCallTaskSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void StartNextCallTask()
        {
            // Start the next call task

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.StartNextCallTask(
                    "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}