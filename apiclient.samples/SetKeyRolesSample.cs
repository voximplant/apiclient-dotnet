using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetKeyRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetKeyRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetKeyRoles()
        {
            // Set roles 1, 2, 3 for the key.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetKeyRoles(
                    "ab81c76e-573e-4046-9af9-105269dfafca",
                    roleId: "1;2;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}