using System;
using System.Collections.Generic;
using System.Text;
using  Newtonsoft.Json;

namespace MyCoinData.Models
{
    [JsonObject]
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("user_name")]
        public string Username { get; set; }
        [JsonProperty("fullname")]
        public string Fullname { get; set; }
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("sold")]
        public double Sold { get; set; }
        [JsonProperty("state")]
        public bool State { get; set; }
        [JsonProperty("date_creation")]
        public DateTime DateCreation { get; set; }

        //public override string ToString()
        //{
        //    return $"{this.Id} {this.Username} {this.Password} {this.Sold} {this.DateCreation}";
        //}
    }
}
