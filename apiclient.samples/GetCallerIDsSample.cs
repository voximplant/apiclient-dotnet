using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCallerIDsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetCallerIDsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Try to find the 79997770044 CID.
        */
        [Fact]
        public void GetCallerIDs()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetCallerIDs(new GetCallerIDsRequest 
                {
                    CalleridNumber = "79997770044",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}