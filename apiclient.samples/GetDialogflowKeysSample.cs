using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetDialogflowKeysSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetDialogflowKeysSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetDialogflowKeys()
        {
            // Get push credentials.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetDialogflowKeys(
                    dialogflowKeyId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}