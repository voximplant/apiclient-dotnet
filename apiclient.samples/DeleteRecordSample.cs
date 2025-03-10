using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeleteRecordSample
    {
        private ITestOutputHelper Console { get; }
        
        public DeleteRecordSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void DeleteRecord()
        {
            // Try remove link with record_id is 1.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.DeleteRecord(
                    recordId: 1L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}