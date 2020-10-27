using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetApplicationInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetApplicationInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetApplicationInfo()
        {
            // Change the application name.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetApplicationInfo(
                    applicationId: 1L,
                    applicationName: "myapp11"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}