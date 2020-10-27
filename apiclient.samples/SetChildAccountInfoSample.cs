using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetChildAccountInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetChildAccountInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetChildAccountInfo()
        {
            // Disable the child account.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetChildAccountInfo(
                    childAccountId: "1321",
                    active: false
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}