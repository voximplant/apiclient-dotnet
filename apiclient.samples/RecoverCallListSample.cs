using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class RecoverCallListSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public RecoverCallListSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Restore list with id = 1
        */
        [Fact]
        public void RecoverCallList()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.RecoverCallList(new RecoverCallListRequest 
                {
                    ListId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}