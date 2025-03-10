using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelUserSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelUserSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelUser()
        {
            // Delete two users with ID 3 and 55.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelUser(
                    userId: "3;55"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}