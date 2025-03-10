using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StartScenariosSample
    {
        private ITestOutputHelper Console { get; }
        
        public StartScenariosSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void StartScenarios()
        {
            // Start the scripts from the account.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.StartScenarios(
                    1L,
                    scriptCustomData: "mystr"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}