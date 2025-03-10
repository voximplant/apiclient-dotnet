using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelRuleSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelRuleSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelRule()
        {
            // Delete the rule 1 and 3.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelRule(
                    ruleId: "1;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}