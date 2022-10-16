using Microsoft.AspNetCore.Mvc;
using ProjectIntegration.Models;
using ProjectIntegration.Services;
using ProjectIntegration.Services.RestEase;
using System.Threading.Tasks;

namespace ProjectIntegration.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        
        private readonly ILoginService _loginServices;
        private readonly IAccessTokenService _accessTokenService;
        private readonly IPlayListsService _playListsService;

        public HomeController(ILoginService loginServices, IAccessTokenService accessTokenService, IPlayListsService playListsService)
        {
            
            _loginServices = loginServices;
            _accessTokenService = accessTokenService;
            _playListsService = playListsService;
        }

        [HttpGet]
        [Route("[Controller]/login")]
        public async Task<RedirectResult> Login()
        {

            return Redirect(await _loginServices.Login());

        }

        [HttpGet]
        [Route("[Controller]/setaccesstoken")]
        public async Task<IActionResult> setacesstoken()
        {

            return Redirect(await _accessTokenService.GetAccessToken());


        }

        [HttpGet]
        [Route("[Controller]/getplaylists/{user}")]
        public async Task<IActionResult> GetPlayLists([FromRoute] string user)
        {
            var repository = await _playListsService.GetPlayListsRepository(user);
            return Ok(repository);

        }

    }
}
