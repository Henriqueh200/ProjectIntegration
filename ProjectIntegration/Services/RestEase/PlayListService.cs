using Newtonsoft.Json;
using ProjectIntegration.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Helpers;
using Newtonsoft.Json;
using System.Linq;


namespace ProjectIntegration.Services.RestEase
{
    public class PlayListService : IPlayListsService
    {

        private readonly IPlayListRestEase _playListRestEase;

        public PlayListService(IPlayListRestEase playListRestEase)
        {
            _playListRestEase = playListRestEase;
        }


        

        public async Task<Repository> GetPlayListsRepository(string user)
        {
           var response = await _playListRestEase.GetRepositoriesAsync(user);

            return response;


        }
    
    }
}
