using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindScenarioSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public BindScenarioSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Bind the scenarios 1, 2 and 3 with the rule 1.
        */
        [Fact]
        public void BindScenario()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.BindScenario(new BindScenarioRequest 
                {
                    ScenarioId = new Argument<long>(new[] {1L, 2L, 3L}),
                    RuleId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}