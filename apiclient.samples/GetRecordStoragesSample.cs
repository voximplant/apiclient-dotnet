using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetRecordStoragesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetRecordStoragesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the record storage with name = ru1.
        */
        [Fact]
        public void GetRecordStorages()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetRecordStorages(new GetRecordStoragesRequest 
                {
                    RecordStorageName = new Argument<string>("ru1"),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}