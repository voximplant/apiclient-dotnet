using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetCallListDetailsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetCallListDetailsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get all lists registered by user
        */
        [Fact]
        public void GetCallListDetails()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetCallListDetails(new GetCallListDetailsRequest 
                {
                    ListId = 1,
                    Output = "json",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}