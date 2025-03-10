using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRegulationsAddressSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetRegulationsAddressSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetRegulationsAddress()
        {
            // Search regulation address with ID = 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetRegulationsAddress(
                    regulationAddressId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}