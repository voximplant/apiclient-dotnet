using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetZIPCodesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetZIPCodesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Search zip codes in Germany
        */
        [Fact]
        public void GetZIPCodes()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetZIPCodes(new GetZIPCodesRequest 
                {
                    CountryCode = "DE",
                    Count = 1,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}