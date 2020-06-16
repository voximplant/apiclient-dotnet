using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeactivateChildAccountSubscriptionSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DeactivateChildAccountSubscriptionSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Deactivates the subscription with ID = 20 and
        * subscription_finish_date = September 29th 2019.
        */
        [Fact]
        public void DeactivateChildAccountSubscription()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                
                var subscriptionFinishDate = new DateTime(2019, 9, 29, 0, 0, 0)
                    .ToUniversalTime();
            
                var result = voximplant.DeactivateChildAccountSubscription(new DeactivateChildAccountSubscriptionRequest 
                {
                    SubscriptionId = 20,
                    ChildAccountId = 10,
                    SubscriptionFinishDate = subscriptionFinishDate,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}