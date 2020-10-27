using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddAdminRoleSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddAdminRoleSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddAdminRole()
        {
            // Add a new admin role with the GetAccountInfo and GetCallHistory
            // permissions.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddAdminRole(
                    "read_only",
                    allowedEntries: "GetAccountInfo;GetCallHistory"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}