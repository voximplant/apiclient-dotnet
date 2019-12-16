using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class GetAdminRolesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public GetAdminRolesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Get two admin roles attached to the admin_user_id=22.
        */
        [Fact]
        public void GetAdminRoles()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.GetAdminRoles(new GetAdminRolesRequest 
                {
                    WithEntries = true,
                    ShowingAdminUserId = 11,
                    IncludedAdminUserId = new Argument<long>(22L),
                    Count = 2,
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}