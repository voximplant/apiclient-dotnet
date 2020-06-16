using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetAdminRoleInfoSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetAdminRoleInfoSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Allow the all permissions except the DelUser and DelApplication.
        */
        [Fact]
        public void SetAdminRoleInfo()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetAdminRoleInfo(new SetAdminRoleInfoRequest 
                {
                    AdminRoleId = 1,
                    EntryModificationMode = "set",
                    AllowedEntries = new Argument<string>(),
                    DeniedEntries = new Argument<string>(new[] {"DelUser", "DelApplication"}),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}