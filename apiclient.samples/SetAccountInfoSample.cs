using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetAccountInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetAccountInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Set the notification settings.
        */
        [Fact]
        public void SetAccountInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetAccountInfo(new SetAccountInfoRequest 
                {
                    LanguageCode = "en",
                    Location = "GMT-8",
                    MinBalanceToNotify = 1.50m,
                    TariffChangingNotifications = true,
                    NewsNotifications = true,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}