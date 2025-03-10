using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class UpdateKeySample
    {
        private ITestOutputHelper Console { get; }
        
        public UpdateKeySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void UpdateKey()
        {
            // Create a new subuser for account_id = 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.UpdateKey(
                    "ab98c70e-573e-4446-9af9-105269dfafca",
                    "test_desc"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}