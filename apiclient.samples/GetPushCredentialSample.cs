using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPushCredentialSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetPushCredentialSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetPushCredential()
        {
            // Get push credentials.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetPushCredential(
                    pushCredentialId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}