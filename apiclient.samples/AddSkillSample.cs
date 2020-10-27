using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddSkillSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddSkillSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddSkill()
        {
            // Add a new skill.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddSkill(
                    "English"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}