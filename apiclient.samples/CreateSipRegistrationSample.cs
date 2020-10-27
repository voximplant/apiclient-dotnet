using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class CreateSipRegistrationSample
    {
        private ITestOutputHelper Console { get; }
        
        public CreateSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void CreateSipRegistration()
        {
            // Create SIP registration.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.CreateSipRegistration(
                    "JohnGalt",
                    "localhost"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}