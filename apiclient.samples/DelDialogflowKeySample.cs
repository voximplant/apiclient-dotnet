using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelDialogflowKeySample
    {
        private ITestOutputHelper Console { get; }
        
        public DelDialogflowKeySample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelDialogflowKey()
        {
            // Remove key.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelDialogflowKey(
                    1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}