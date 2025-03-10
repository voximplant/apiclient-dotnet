using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddAuthorizedAccountIPSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddAuthorizedAccountIPSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddAuthorizedAccountIP()
        {
            // Add the 92.255.220.0/24 network to the white list.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddAuthorizedAccountIP(
                    "92.255.220.0/24"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}