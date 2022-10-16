
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProjectIntegration.Models
{
  
    public class Repository
    {
        [JsonProperty("data")]
        public List<Retorno>  data { get; set; }

        [JsonProperty("total")]
        public int total { get; set; }


    }


}
