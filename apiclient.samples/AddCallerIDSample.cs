using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddCallerIDSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddCallerIDSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddCallerID()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddCallerID(
                    "74953331122"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}