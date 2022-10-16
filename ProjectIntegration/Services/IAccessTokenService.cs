using System.Threading.Tasks;

namespace ProjectIntegration.Services
{
    public interface IAccessTokenService
    {

        public Task<string> GetAccessToken();
    }
}
