using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ReorderRulesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public ReorderRulesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Set the rule selection order: 1, 7, 3
        */
        [Fact]
        public void ReorderRules()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.ReorderRules(new ReorderRulesRequest 
                {
                    RuleId = new Argument<long>(new[] {1L, 7L, 3L}),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}