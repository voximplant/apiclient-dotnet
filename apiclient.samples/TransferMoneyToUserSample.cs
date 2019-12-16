using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class TransferMoneyToUserSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public TransferMoneyToUserSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Transfer the all money from the user 1 to the parent account.
        */
        [Fact]
        public void TransferMoneyToUser()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.TransferMoneyToUser(new TransferMoneyToUserRequest 
                {
                    UserId = new Argument<long>(1L),
                    Amount = -10000000m,
                    StrictMode = false,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}