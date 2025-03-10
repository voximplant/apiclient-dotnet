using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetPushCredentialSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetPushCredentialSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetPushCredential()
        {
            // Modify credentials.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetPushCredential(
                    1L,
                    certPassword: "1234567"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}