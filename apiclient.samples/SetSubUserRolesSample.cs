using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSubUserRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetSubUserRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetSubUserRoles()
        {
            // Add the roles 1, 2, 3 to the subuser with id = 12.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetSubUserRoles(
                    12L,
                    roleId: "1;2;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}