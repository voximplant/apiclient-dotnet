using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetChildrenAccountsSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetChildrenAccountsSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get the particular child.
        */
        [Fact]
        public void GetChildrenAccounts()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetChildrenAccounts(new GetChildrenAccountsRequest 
                {
                    ChildAccountEmail = "mychild@gmail.com",
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}