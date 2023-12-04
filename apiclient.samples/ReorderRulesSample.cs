using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ReorderRulesSample
    {
        private ITestOutputHelper Console { get; }
        
        public ReorderRulesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void ReorderRules()
        {
            // Set the rule selection order: 1, 7, 3.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.ReorderRules(
                    "1;7;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}