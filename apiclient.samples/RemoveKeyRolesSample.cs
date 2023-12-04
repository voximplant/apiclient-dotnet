using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class RemoveKeyRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public RemoveKeyRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void RemoveKeyRoles()
        {
            // Remove the roles 1, 2, 3 from the key.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.RemoveKeyRoles(
                    "ab81c90e-543e-4446-9af9-105269dfafca",
                    roleId: "1;2;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}