using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetScenarioInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetScenarioInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add a new scenario: var s='hello';
        */
        [Fact]
        public void SetScenarioInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetScenarioInfo(new SetScenarioInfoRequest 
                {
                    ScenarioId = 1,
                    ScenarioName = "call_scenario",
                    ScenarioScript = "var s=\"hello world\";",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}