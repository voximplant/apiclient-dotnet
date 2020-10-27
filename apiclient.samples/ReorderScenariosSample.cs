using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ReorderScenariosSample
    {
        private ITestOutputHelper Console { get; }
        
        public ReorderScenariosSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void ReorderScenarios()
        {
            // Set the scenario loading order: 17, 15, 20.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.ReorderScenarios(
                    ruleId: 2L,
                    scenarioId: "17;15;20"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}