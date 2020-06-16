using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddScenarioSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddScenarioSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add a new scenario: var s='hello';
        */
        [Fact]
        public void AddScenario()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddScenario(new AddScenarioRequest 
                {
                    ScenarioName = "call_scenario",
                    ScenarioScript = "var s=\"hello\";",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}