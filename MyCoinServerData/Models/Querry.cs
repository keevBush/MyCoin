using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MyCoinServerData.Models
{
    [JsonObject]
    public class Querry
    {
        [JsonProperty("entete")]
        public string Entete { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
