using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelSkillSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelSkillSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelSkill()
        {
            // Delete the skill 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelSkill(
                    skillId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}