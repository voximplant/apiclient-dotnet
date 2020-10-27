using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetChildrenAccountsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetChildrenAccountsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetChildrenAccounts()
        {
            // Get the all children.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetChildrenAccounts().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}