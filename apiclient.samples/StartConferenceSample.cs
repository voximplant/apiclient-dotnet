using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class StartConferenceSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public StartConferenceSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Start the conference from the user 1.
        */
        [Fact]
        public void StartConference()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.StartConference(new StartConferenceRequest 
                {
                    ConferenceName = "boss",
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