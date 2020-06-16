using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AddAuthorizedAccountIPSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AddAuthorizedAccountIPSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add the 92.255.220.0/24 network to the white list.
        */
        [Fact]
        public void AddAuthorizedAccountIP()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AddAuthorizedAccountIP(new AddAuthorizedAccountIPRequest 
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