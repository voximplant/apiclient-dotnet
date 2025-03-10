using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StartConferenceSample
    {
        private ITestOutputHelper Console { get; }
        
        public StartConferenceSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void StartConference()
        {
            // Start the conference from the account.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.StartConference(
                    "boss",
                    1L,
                    scriptCustomData: "mystr"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}