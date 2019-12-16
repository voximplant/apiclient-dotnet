using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class AttachAdminRoleSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public AttachAdminRoleSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Bind the all admin users with the admin roles 1, 2 and 3.
        */
        [Fact]
        public void AttachAdminRole()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.AttachAdminRole(new AttachAdminRoleRequest 
                {
                    RequiredAdminUserId = new Argument<long>(),
                    AdminRoleId = new Argument<long>(new[] {1L, 2L, 3L}),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}