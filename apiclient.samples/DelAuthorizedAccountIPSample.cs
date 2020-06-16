using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelAuthorizedAccountIPSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelAuthorizedAccountIPSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Delete the 92.255.220.0/24 network from all the lists.
        */
        [Fact]
        public void DelAuthorizedAccountIP()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelAuthorizedAccountIP(new DelAuthorizedAccountIPRequest 
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