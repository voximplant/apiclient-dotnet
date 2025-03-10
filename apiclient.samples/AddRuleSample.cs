using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddRuleSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddRuleSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddRule()
        {
            // Add a new rule.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddRule(
                    "allowall",
                    ".*",
                    applicationId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}