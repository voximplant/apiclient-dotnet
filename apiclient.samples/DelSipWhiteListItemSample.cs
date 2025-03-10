using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelSipWhiteListItemSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelSipWhiteListItemSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelSipWhiteListItem()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelSipWhiteListItem(
                    1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}