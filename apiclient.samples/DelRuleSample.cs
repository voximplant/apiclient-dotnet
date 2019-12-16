using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelRuleSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelRuleSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Delete the all rules from the all applications.
        */
        [Fact]
        public void DelRule()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelRule(new DelRuleRequest 
                {
                    RuleId = new Argument<long>(),
                    ApplicationId = new Argument<long>(),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}