using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StopCallListProcessingSample
    {
        private ITestOutputHelper Console { get; }
        
        public StopCallListProcessingSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void StopCallListProcessing()
        {
            // Cancel list with id = 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.StopCallListProcessing(
                    1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}