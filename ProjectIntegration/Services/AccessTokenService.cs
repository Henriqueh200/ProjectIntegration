using ProjectIntegration.Models;
using System.Threading.Tasks;

namespace ProjectIntegration.Services
{
    public class AccessTokenService : IAccessTokenService
    {
        private readonly AppSettings _appSettings;

        public AccessTokenService(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task<string> GetAccessToken()
        {
            var url = ($"https://connect.deezer.com/oauth/access_token.php?app_id={_appSettings.DeezerSettings.AppId}&secret={_appSettings.DeezerSettings.SecretKey}&code={_appSettings.DeezerSettings.code}");
            return url;
            
        }
    }
}
