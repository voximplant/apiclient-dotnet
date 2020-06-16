using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddSipWhiteListItemSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddSipWhiteListItemSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        
        [Fact]
        public void AddSipWhiteListItem()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddSipWhiteListItem(new AddSipWhiteListItemRequest 
                {
                    SipWhitelistNetwork = "192.168.1.5/16",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}