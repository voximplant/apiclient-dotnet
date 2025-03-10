using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPstnBlackListSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetPstnBlackListSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetPstnBlackList()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetPstnBlackList().Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}