using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DeleteRecordSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DeleteRecordSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Try remove link with record_id is 1.
        */
        [Fact]
        public void DeleteRecord()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DeleteRecord(new DeleteRecordRequest 
                {
                    RecordId = 1,
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}