using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ReorderScenariosSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public ReorderScenariosSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Set the scenario loading order: 17, 15, 20.
        */
        [Fact]
        public void ReorderScenarios()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.ReorderScenarios(new ReorderScenariosRequest 
                {
                    RuleId = 2,
                    ScenarioId = new Argument<long>(new[] {17L, 15L, 20L}),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}