using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindSipRegistrationSample
    {
        private ITestOutputHelper Console { get; }
        
        public BindSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void BindSipRegistration()
        {
            // Bind SIP registration with id 1 to application with id 123.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.BindSipRegistration(
                    applicationId: 123L,
                    sipRegistrationId: 1L,
                    bind: true
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}