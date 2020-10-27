using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetAdminRoleInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetAdminRoleInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetAdminRoleInfo()
        {
            // Allow the all permissions except the DelUser and DelApplication.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetAdminRoleInfo(
                    adminRoleId: 1L,
                    entryModificationMode: "set",
                    allowedEntries: "all",
                    deniedEntries: "DelUser;DelApplication"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}