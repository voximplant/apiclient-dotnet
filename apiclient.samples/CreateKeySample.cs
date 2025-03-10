using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class CreateKeySample
    {
        private ITestOutputHelper Console { get; }
        
        public CreateKeySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void CreateKey()
        {
            // Create a key pair.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.CreateKey().Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}