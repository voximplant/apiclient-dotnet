using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetPstnBlackListItemSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetPstnBlackListItemSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        
        [Fact]
        public void SetPstnBlackListItem()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetPstnBlackListItem(new SetPstnBlackListItemRequest 
                {
                    PstnBlacklistPhone = "123456789",
                    PstnBlacklistId = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}