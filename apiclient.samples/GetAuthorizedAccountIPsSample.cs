using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAuthorizedAccountIPsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetAuthorizedAccountIPsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Show the all items.
        */
        [Fact]
        public void GetAuthorizedAccountIPs()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetAuthorizedAccountIPs(new GetAuthorizedAccountIPsRequest 
                {
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}