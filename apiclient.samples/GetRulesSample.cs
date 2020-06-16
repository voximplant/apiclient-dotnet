using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRulesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetRulesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the first rule for the template 74951234567
        */
        [Fact]
        public void GetRules()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetRules(new GetRulesRequest 
                {
                    ApplicationId = 1,
                    Template = "74951234567",
                    WithScenarios = true,
                    Count = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}