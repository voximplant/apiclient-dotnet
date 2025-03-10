using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetKeysSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetKeysSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetKeys()
        {
            // Get keys info of the specified account.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetKeys().Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}