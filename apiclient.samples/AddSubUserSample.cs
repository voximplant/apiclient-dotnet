using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddSubUserSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddSubUserSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddSubUser()
        {
            // Create a new subuser for account_id = 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddSubUser(
                    "John_McClane",
                    "pssw0rd"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}