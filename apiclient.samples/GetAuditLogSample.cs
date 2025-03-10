using System;
using Voximplant.API;
using Voximplant.API.Response;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAuditLogSample
    {
        private ITestOutputHelper Console { get; }
        
        public GetAuditLogSample(ITestOutputHelper outputHelper)
        {
            Console = outputHelper;
        }
        
        [Fact]
        public void GetAuditLog()
        {
            // Get the three log items from the 2018-02-01 00:00:00 to the
            // 2018-03-01 00:00:00 and filter.

            try {
                var voximplant = new VoximplantAPI();

                var result = voximplant.GetAuditLog(
                    new DateTime(2018, 2, 1, 0, 0, 0),
                    new DateTime(2018, 3, 1, 0, 0, 0),
                    filteredCmd: "BindSkill;AddSkill;DelSkill",
                    advancedFilters: "152",
                    count: 3L
                ).Result;

                Console.WriteLine($"Response: {result.ToString()}");

            } catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}