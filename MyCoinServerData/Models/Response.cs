using System;
using System.Collections.Generic;
using System.Text;

namespace MyCoinServerData.Models
{
    using Newtonsoft.Json;
    [JsonObject]
    public class Response
    {
        [JsonProperty("entete")]
        public string Entete { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
