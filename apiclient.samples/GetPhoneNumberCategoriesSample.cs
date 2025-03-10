using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetPhoneNumberCategoriesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetPhoneNumberCategoriesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetPhoneNumberCategories()
        {
            // Get the all phone number categories.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetPhoneNumberCategories().Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}