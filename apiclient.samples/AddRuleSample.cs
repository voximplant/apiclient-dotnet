using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddRuleSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddRuleSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add a new rule.
        */
        [Fact]
        public void AddRule()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddRule(new AddRuleRequest 
                {
                    ApplicationId = 1,
                    RuleName = "allowall",
                    RulePattern = ".*",
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}