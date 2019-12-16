using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class SetSubUserRolesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public SetSubUserRolesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Add the roles 1, 2, 3 to the subuser with id = 12
        */
        [Fact]
        public void SetSubUserRoles()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.SetSubUserRoles(new SetSubUserRolesRequest 
                {
                    SubuserId = 12,
                    RoleId = new Argument<long>(1L),
                });

                _outputHelper.WriteLine("OK");
            } catch (Exception e) {
                _outputHelper.WriteLine($"Error: {e.Message}");
            }
        }
    }
}