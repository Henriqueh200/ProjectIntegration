using Microsoft.AspNetCore.Mvc;
using ProjectIntegration.Models;
using System;
using System.Threading.Tasks;
using System.Web;

namespace ProjectIntegration.Services
{
    public class LoginServices : ILoginService
    {
        private const string API_ID_QUERY_KEY = "app_id";
        private const string URI_QUERY_KEY = "redirect_uri";
        private const string PERMS_KEY = "perms";
        private const string PERMS_VALUE = "listening_history,email";

        private readonly AppSettings _appSettings;

        public LoginServices(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task<string> Login()
        {
            string loungurl = _appSettings.DeezerSettings.BaseUrl;

            var uriBuilder = new UriBuilder(loungurl);

            var query =  HttpUtility.ParseQueryString(uriBuilder.Query);

            query[API_ID_QUERY_KEY] = _appSettings.DeezerSettings.AppId;
            query[URI_QUERY_KEY] = _appSettings.DeezerSettings.RedirectUrl;
            query[PERMS_KEY] = PERMS_VALUE;
            uriBuilder.Query = query.ToString();
            loungurl = uriBuilder.ToString();

            
            return loungurl;

        }
     
    }
}
