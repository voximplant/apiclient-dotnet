using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSkillsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetSkillsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetSkills()
        {
            // Get two skills, but skip the first one.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetSkills(
                    offset: 1L,
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}