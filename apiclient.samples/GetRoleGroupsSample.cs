using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRoleGroupsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetRoleGroupsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetRoleGroups()
        {
            // Get all role groups.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetRoleGroups().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}