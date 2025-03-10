using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeleteSipRegistrationSample
    {
        private ITestOutputHelper Console { get; }
        
        public DeleteSipRegistrationSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DeleteSipRegistration()
        {
            // Delete SIP registration with id 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DeleteSipRegistration(
                    1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}