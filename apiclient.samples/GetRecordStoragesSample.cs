using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRecordStoragesSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetRecordStoragesSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetRecordStorages()
        {
            // Get all record storages.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetRecordStorages().Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}