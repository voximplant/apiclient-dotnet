using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class CheckAuthorizedAccountIPSample
    {
        private ITestOutputHelper Console { get; }
        
        public CheckAuthorizedAccountIPSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void CheckAuthorizedAccountIP()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.CheckAuthorizedAccountIP(
                    "92.255.220.0/24"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}