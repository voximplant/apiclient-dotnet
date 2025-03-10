using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindDialogflowKeysSample
    {
        private ITestOutputHelper Console { get; }
        
        public BindDialogflowKeysSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void BindDialogflowKeys()
        {
            // Bind a Dialogflow key to the application.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.BindDialogflowKeys(
                    1L,
                    "1"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}