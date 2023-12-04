using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelSubUserSample
    {
        private ITestOutputHelper Console { get; }
        
        public DelSubUserSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DelSubUser()
        {
            // Delete the subuser with id = 12 from account_id = 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DelSubUser(
                    12L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}