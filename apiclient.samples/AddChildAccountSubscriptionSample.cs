using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddChildAccountSubscriptionSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddChildAccountSubscriptionSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Create a subscription for the child account with ID = 10 using the
        * subscription template with ID = 184.
        */
        [Fact]
        public void AddChildAccountSubscription()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddChildAccountSubscription(new AddChildAccountSubscriptionRequest 
                {
                    ChildAccountId = 10,
                    SubscriptionTemplateId = 184,
                    SubscriptionName = "Meaningful subscription name",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}