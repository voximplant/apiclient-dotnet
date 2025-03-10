using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetResourcePriceSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetResourcePriceSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetResourcePrice()
        {
            // 

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetResourcePrice().Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}