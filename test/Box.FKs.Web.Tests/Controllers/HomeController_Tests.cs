using System.Threading.Tasks;
using Box.FKs.Models.TokenAuth;
using Box.FKs.Web.Controllers;
using Shouldly;
using Xunit;

namespace Box.FKs.Web.Tests.Controllers
{
    public class HomeController_Tests: FKsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}