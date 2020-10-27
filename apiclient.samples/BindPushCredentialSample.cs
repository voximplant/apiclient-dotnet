using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindPushCredentialSample
    {
        private ITestOutputHelper Console { get; }
        
        public BindPushCredentialSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void BindPushCredential()
        {
            // Bind the push credential to the application.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.BindPushCredential(
                    "1",
                    "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}