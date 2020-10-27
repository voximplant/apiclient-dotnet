using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSubUserRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetSubUserRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetSubUserRoles()
        {
            // Get subuser's roles.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetSubUserRoles(
                    12L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}