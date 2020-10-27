using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelPstnBlackListItemSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelPstnBlackListItemSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelPstnBlackListItem()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelPstnBlackListItem(
                    1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}