using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelAdminUserSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelAdminUserSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelAdminUser()
        {
            // Delete the admin user.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelAdminUser(
                    requiredAdminUserId: "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}