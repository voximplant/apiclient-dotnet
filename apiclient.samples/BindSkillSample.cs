using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindSkillSample
    {
        private ITestOutputHelper Console { get; }
        
        public BindSkillSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void BindSkill()
        {
            // Bind the skills 1, 5 to the users 5, 6, 10.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.BindSkill(
                    skillId: "1;3",
                    userId: "5;6;10"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}