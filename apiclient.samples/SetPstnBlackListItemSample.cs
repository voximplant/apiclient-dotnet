using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetPstnBlackListItemSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetPstnBlackListItemSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetPstnBlackListItem()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetPstnBlackListItem(
                    1L,
                    "123456789"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}