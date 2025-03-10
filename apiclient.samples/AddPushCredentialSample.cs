using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddPushCredentialSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddPushCredentialSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddPushCredential()
        {
            // Add new Apple credentials.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddPushCredential(
                    pushProviderName: "APPLE",
                    certPassword: "12345678",
                    certFileName: "apple_certificate_name",
                    isDevMode: false
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}