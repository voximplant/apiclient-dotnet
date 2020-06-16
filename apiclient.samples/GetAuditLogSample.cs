using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAuditLogSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetAuditLogSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the three log items from the 2018-02-01 00:00:00 to the
        * 2018-03-01 00:00:00 and filter.
        */
        [Fact]
        public void GetAuditLog()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var fromDate = new DateTime(2018, 2, 1, 0, 0, 0)
                    .ToUniversalTime();

                var toDate = new DateTime(2018, 3, 1, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.GetAuditLog(new GetAuditLogRequest 
                {
                    FromDate = fromDate,
                    ToDate = toDate,
                    FilteredCmd = new Argument<string>(new[] {"BindSkill", "AddSkill", "DelSkill"}),
                    AdvancedFilters = "152",
                    Count = 3,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}