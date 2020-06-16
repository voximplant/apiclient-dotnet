using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class DelAdminRoleSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public DelAdminRoleSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Delete the admin role.
        */
        [Fact]
        public void DelAdminRole()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.DelAdminRole(new DelAdminRoleRequest 
                {
                    AdminRoleId = new Argument<long>(10L),
                }).Result;

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}