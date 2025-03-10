using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class VerifyCallerIDSample
    {
        private ITestOutputHelper Console { get; }
        
        public VerifyCallerIDSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void VerifyCallerID()
        {
            // Verify the callerID 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.VerifyCallerID(
                    calleridId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}