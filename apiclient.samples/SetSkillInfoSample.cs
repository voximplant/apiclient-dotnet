using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSkillInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetSkillInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Change the skill name.
        */
        [Fact]
        public void SetSkillInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetSkillInfo(new SetSkillInfoRequest 
                {
                    SkillId = 1,
                    NewSkillName = "Support",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}