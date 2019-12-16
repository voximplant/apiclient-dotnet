using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StartScenariosSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public StartScenariosSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Start the scripts from the user 1.
        */
        [Fact]
        public void StartScenarios()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.StartScenarios(new StartScenariosRequest 
                {
                    RuleId = 1,
                    ScriptCustomData = "mystr",
                    UserId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}