using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindScenarioSample
    {
        private ITestOutputHelper Console { get; }
        
        public BindScenarioSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void BindScenario()
        {
            // Bind the scenarios 1, 2 and 3 with the rule 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.BindScenario(
                    scenarioId: "1;2;3",
                    ruleId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}