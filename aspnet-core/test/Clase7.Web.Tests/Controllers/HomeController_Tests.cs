using System.Threading.Tasks;
using Clase7.Models.TokenAuth;
using Clase7.Web.Controllers;
using Shouldly;
using Xunit;

namespace Clase7.Web.Tests.Controllers
{
    public class HomeController_Tests: Clase7WebTestBase
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