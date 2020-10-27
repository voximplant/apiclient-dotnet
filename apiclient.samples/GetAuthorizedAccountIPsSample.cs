using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAuthorizedAccountIPsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetAuthorizedAccountIPsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetAuthorizedAccountIPs()
        {
            // Show the all items.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetAuthorizedAccountIPs().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}