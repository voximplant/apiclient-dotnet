using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSkillInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetSkillInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetSkillInfo()
        {
            // Change the skill name.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetSkillInfo(
                    "Support",
                    skillId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}