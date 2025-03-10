using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AttachAdminRoleSample
    {
        private ITestOutputHelper Console { get; }
        
        public AttachAdminRoleSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AttachAdminRole()
        {
            // Bind the all admin users with the admin roles 1, 2 and 3.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AttachAdminRole(
                    requiredAdminUserId: "all",
                    adminRoleId: "1;2;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}