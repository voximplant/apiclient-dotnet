using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetScenariosSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetScenariosSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get two scenarios, but skip the first one.
        */
        [Fact]
        public void GetScenarios()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetScenarios(new GetScenariosRequest 
                {
                    Offset = 1,
                    Count = 2,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}