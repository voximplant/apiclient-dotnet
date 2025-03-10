using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAdminRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetAdminRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetAdminRoles()
        {
            // Get two admin roles attached to the admin_user_id=22.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetAdminRoles(
                    withEntries: true,
                    showingAdminUserId: 11L,
                    includedAdminUserId: "22",
                    count: 2L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}