using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelAuthorizedAccountIPSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelAuthorizedAccountIPSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelAuthorizedAccountIP()
        {
            // Delete the 92.255.220.0/24 network from all the lists.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelAuthorizedAccountIP(
                    authorizedIp: "92.255.220.0/24"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}