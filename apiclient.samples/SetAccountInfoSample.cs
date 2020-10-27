using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetAccountInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetAccountInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetAccountInfo()
        {
            // Change the account's password.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetAccountInfo(
                    newAccountPassword: "7654321"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}