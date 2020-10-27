using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelScenarioSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelScenarioSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelScenario()
        {
            // Delete the scenario 1 and 3.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelScenario(
                    scenarioId: "1;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}