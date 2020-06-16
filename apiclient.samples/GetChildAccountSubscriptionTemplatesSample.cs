using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetChildAccountSubscriptionTemplatesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetChildAccountSubscriptionTemplatesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the eligible subscription templates.
        */
        [Fact]
        public void GetChildAccountSubscriptionTemplates()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetChildAccountSubscriptionTemplates(new GetChildAccountSubscriptionTemplatesRequest 
                {
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}