using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindPhoneNumberToApplicationSample
    {
        private ITestOutputHelper Console { get; }
        
        public BindPhoneNumberToApplicationSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void BindPhoneNumberToApplication()
        {
            // Bind the phone 1 to the application 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.BindPhoneNumberToApplication(
                    phoneId: "1",
                    applicationId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}