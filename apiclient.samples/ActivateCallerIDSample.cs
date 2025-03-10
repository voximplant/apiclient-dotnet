using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ActivateCallerIDSample
    {
        private ITestOutputHelper Console { get; }
        
        public ActivateCallerIDSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void ActivateCallerID()
        {
            // Activate the callerID by the verification code.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.ActivateCallerID(
                    "12345",
                    calleridId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}