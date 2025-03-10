using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class RemoveSubUserRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public RemoveSubUserRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void RemoveSubUserRoles()
        {
            // Remove roles 1,2,3 from the subuser with id = 12.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.RemoveSubUserRoles(
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