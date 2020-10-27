using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddScenarioSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddScenarioSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddScenario()
        {
            // Add a new scenario: var s='hello';

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddScenario(
                    "call_scenario",
                    scenarioScript: "var s=\"hello\";"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}