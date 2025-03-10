using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelCallerIDSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelCallerIDSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelCallerID()
        {
            // Delete the callerID 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelCallerID(
                    calleridId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}