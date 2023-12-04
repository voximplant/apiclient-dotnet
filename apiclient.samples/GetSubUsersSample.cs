using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSubUsersSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetSubUsersSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetSubUsers()
        {
            // Get subusers info.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetSubUsers().Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}