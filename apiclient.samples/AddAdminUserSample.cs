using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddAdminUserSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddAdminUserSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddAdminUser()
        {
            // Add a new admin user.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddAdminUser(
                    "Overseer_Campbell",
                    "Overseer_Campbell",
                    "1234567",
                    adminRoleId: "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}