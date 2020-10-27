using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCallListsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetCallListsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetCallLists()
        {
            // Get all lists registered by user

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetCallLists().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}