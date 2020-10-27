using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelAdminRoleSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelAdminRoleSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelAdminRole()
        {
            // Delete the admin role.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelAdminRole(
                    adminRoleId: "10"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}