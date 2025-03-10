using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSubUserInfoSample
    {
        private ITestOutputHelper Console { get; }
        
        public SetSubUserInfoSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void SetSubUserInfo()
        {
            // Edit the password and description for the subuser with id = 12 from
            // account_id = 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.SetSubUserInfo(
                    12L,
                    oldSubuserPassword: "old_test_password",
                    newSubuserPassword: "test_pass",
                    description: "test_desc"
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}