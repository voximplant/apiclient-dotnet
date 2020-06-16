using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSipWhiteListItemSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetSipWhiteListItemSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        
        [Fact]
        public void SetSipWhiteListItem()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetSipWhiteListItem(new SetSipWhiteListItemRequest 
                {
                    SipWhitelistId = 1,
                    SipWhitelistNetwork = "192.168.1.5/16",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}