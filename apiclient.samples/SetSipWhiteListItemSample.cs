using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSipWhiteListItemSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetSipWhiteListItemSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetSipWhiteListItem()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetSipWhiteListItem(
                    1L,
                    "192.168.1.5/16"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}