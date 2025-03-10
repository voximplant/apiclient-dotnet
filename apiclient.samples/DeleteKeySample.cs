using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeleteKeySample
    {
        private ITestOutputHelper Console { get; }
        
        public DeleteKeySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DeleteKey()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DeleteKey(
                    "ab81c66e-570e-4446-9af9-105269dfafca"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}