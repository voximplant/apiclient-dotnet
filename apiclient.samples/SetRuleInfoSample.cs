using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetRuleInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetRuleInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetRuleInfo()
        {
            // Deny all.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetRuleInfo(
                    1L,
                    ruleName: "denyall",
                    rulePatternExclude: ".*"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}