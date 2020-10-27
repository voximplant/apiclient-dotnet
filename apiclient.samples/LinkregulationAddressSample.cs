using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class LinkregulationAddressSample
    {
        private ITestOutputHelper Console { get; }
        
        public LinkregulationAddressSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void LinkregulationAddress()
        {
            // Link the regulation address to a phone number

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.LinkregulationAddress(
                    1L,
                    phoneId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}