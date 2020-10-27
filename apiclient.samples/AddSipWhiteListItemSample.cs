using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddSipWhiteListItemSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddSipWhiteListItemSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddSipWhiteListItem()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddSipWhiteListItem(
                    "192.168.1.5/16"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}