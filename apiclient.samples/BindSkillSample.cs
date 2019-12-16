using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class BindSkillSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public BindSkillSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Unbind the skills 1, 6 from the all users and the queues 11, 12.
        */
        [Fact]
        public void BindSkill()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.BindSkill(new BindSkillRequest 
                {
                    SkillId = new Argument<long>(new[] {1L, 6L}),
                    AcdQueueId = new Argument<long>(new[] {11L, 12L}),
                    UserId = new Argument<long>(),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}