using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetUserInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetUserInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetUserInfo()
        {
            // Edit the user password.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetUserInfo(
                    userId: 1L,
                    userPassword: "7654321"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}