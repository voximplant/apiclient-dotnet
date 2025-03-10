using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetScenarioInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetScenarioInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetScenarioInfo()
        {
            // Add a new scenario: var s='hello';

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetScenarioInfo(
                    scenarioId: 1L,
                    scenarioName: "call_scenario",
                    scenarioScript: "var s=\"hello world\";"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}