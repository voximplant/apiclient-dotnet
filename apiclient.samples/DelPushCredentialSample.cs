using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelPushCredentialSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelPushCredentialSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelPushCredential()
        {
            // Remove credentials.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelPushCredential(
                    1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}