using ProjectIntegration.Models;
using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectIntegration.Services.RestEase
{
    
    public interface IPlayListRestEase
    {

        [Get("{user}/playlists?access_token=fruQCh7JvQsNsZfxw8boClzCTUaruHgmCZwgoUVbAPz17HNlUPX")]       
        Task<Repository> GetRepositoriesAsync([Path] string user);
    }
}
