using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddPstnBlackListItemSample
    {
        private ITestOutputHelper Console { get; }
        
        public AddPstnBlackListItemSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void AddPstnBlackListItem()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.AddPstnBlackListItem(
                    "123456789"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}