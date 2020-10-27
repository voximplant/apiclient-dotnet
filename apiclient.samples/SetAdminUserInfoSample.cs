using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetAdminUserInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetAdminUserInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetAdminUserInfo()
        {
            // Edit the admin user password.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetAdminUserInfo(
                    requiredAdminUserId: 1L,
                    newAdminUserPassword: "7654321"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}