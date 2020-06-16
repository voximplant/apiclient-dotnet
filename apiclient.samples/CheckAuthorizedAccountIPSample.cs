using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class CheckAuthorizedAccountIPSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public CheckAuthorizedAccountIPSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        
        [Fact]
        public void CheckAuthorizedAccountIP()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.CheckAuthorizedAccountIP(new CheckAuthorizedAccountIPRequest 
                {
                    AuthorizedIp = "92.255.220.0/24",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}