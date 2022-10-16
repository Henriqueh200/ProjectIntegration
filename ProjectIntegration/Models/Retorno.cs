
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProjectIntegration.Models
{
    public class Retorno
    {

        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("title")]
        public string Title { get; set; }


        [JsonProperty("link")]
        public string Link { get; set; }

    }
}
