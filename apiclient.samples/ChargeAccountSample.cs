using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class ChargeAccountSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public ChargeAccountSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Charge the all frozen phone numbers.
        */
        [Fact]
        public void ChargeAccount()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.ChargeAccount(new ChargeAccountRequest 
                {
                    PhoneNumber = new Argument<string>(),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}