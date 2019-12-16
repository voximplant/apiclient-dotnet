using System;
using Voximplant.API;
using Voximplant.API.Response;
using Voximplant.API.Request;
using Xunit;
using Xunit.Abstractions;

namespace apiclient.samples
{
    [Collection("Samples")]
    public class RemoveSubUserRolesSample
    {
        private readonly ITestOutputHelper _outputHelper;
        
        public RemoveSubUserRolesSample(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        
        /**
        * Remove roles 1,2,3 from the subuser with id = 12
        */
        [Fact]
        public void RemoveSubUserRoles()
        {
            try
            {
                var voximplant = new VoximplantAPI();
            
                            
                var result = voximplant.RemoveSubUserRoles(new RemoveSubUserRolesRequest 
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