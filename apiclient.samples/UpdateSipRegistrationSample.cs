using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class UpdateSipRegistrationSample
    {
        private ITestOutputHelper Console { get; }
        
        public UpdateSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void UpdateSipRegistration()
        {
            // Update SIP registration with id 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.UpdateSipRegistration(
                    1L,
                    sipUsername: "HedyLamarr",
                    outboundProxy: "12",
                    password: "123456"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}