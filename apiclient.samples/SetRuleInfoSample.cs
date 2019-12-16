using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetRuleInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetRuleInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Deny all.
        */
        [Fact]
        public void SetRuleInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetRuleInfo(new SetRuleInfoRequest 
                {
                    RuleId = 1,
                    RuleName = "denyall",
                    RulePatternExclude = ".*",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}