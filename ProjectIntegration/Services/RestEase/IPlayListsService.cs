using ProjectIntegration.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectIntegration.Services.RestEase
{
    public interface IPlayListsService
    {

        public Task<Repository> GetPlayListsRepository(string user);
    }
}
