using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetChildAccountSubscriptionsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetChildAccountSubscriptionsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the subscription with ID = 20.
        */
        [Fact]
        public void GetChildAccountSubscriptions()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetChildAccountSubscriptions(new GetChildAccountSubscriptionsRequest 
                {
                    ChildAccountId = 10,
                    SubscriptionId = 20,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}