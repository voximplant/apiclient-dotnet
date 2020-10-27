using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRolesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetRolesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetRoles()
        {
            // Get all roles.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetRoles().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}