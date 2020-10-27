using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddApplicationSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddApplicationSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddApplication()
        {
            // Add a new application.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddApplication(
                    "myapp1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}