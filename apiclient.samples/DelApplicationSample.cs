using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelApplicationSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelApplicationSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelApplication()
        {
            // Delete the application 1 and 3.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelApplication(
                    applicationId: "1;3"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}