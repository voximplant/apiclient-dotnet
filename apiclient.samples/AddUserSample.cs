using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddUserSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddUserSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddUser()
        {
            // Add a new user

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddUser(
                    "GordonFreeman",
                    "GordonFreeman",
                    "1234567",
                    applicationId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}