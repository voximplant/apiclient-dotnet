using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetChildAccountInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetChildAccountInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Disable the child account.
        */
        [Fact]
        public void SetChildAccountInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetChildAccountInfo(new SetChildAccountInfoRequest 
                {
                    ChildAccountId = new Argument<long>(1321L),
                    Active = false,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}