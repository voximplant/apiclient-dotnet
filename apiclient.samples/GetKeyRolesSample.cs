using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetKeyRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetKeyRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetKeyRoles()
        {
            // Get roles of the key.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetKeyRoles(
                    "ab81c50e-573e-4446-9af9-105269dfafca"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}