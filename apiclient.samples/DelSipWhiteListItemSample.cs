using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelSipWhiteListItemSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelSipWhiteListItemSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        
        [Fact]
        public void DelSipWhiteListItem()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelSipWhiteListItem(new DelSipWhiteListItemRequest 
                {
                    SipWhitelistId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}