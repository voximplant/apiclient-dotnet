using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRulesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetRulesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetRules()
        {
            // Get the first rule for the template 74951234567.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetRules(
                    applicationId: 1L,
                    template: "74951234567",
                    withScenarios: true,
                    count: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}