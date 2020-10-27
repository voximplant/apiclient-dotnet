using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAccountDocumentsSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetAccountDocumentsSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetAccountDocuments()
        {

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetAccountDocuments(
                    withDetails: true
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}