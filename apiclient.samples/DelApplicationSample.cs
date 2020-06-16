using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelApplicationSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelApplicationSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Delete the all applications.
        */
        [Fact]
        public void DelApplication()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelApplication(new DelApplicationRequest 
                {
                    ApplicationId = new Argument<long>(),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}