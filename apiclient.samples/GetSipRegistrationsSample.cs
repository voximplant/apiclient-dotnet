using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSipRegistrationsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetSipRegistrationsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetSipRegistrations()
        {
            // Get all active sip registrations.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetSipRegistrations().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}