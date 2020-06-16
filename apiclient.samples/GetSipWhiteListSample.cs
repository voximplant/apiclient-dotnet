using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetSipWhiteListSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetSipWhiteListSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get two networks, but skip the first one.
        */
        [Fact]
        public void GetSipWhiteList()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetSipWhiteList(new GetSipWhiteListRequest 
                {
                    Offset = 1,
                    Count = 2,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}