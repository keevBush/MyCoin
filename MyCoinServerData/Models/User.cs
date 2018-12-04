﻿using System;
using System.Collections.Generic;
using System.Text;
using  Newtonsoft.Json;

namespace MyCoinServerData.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("user_name")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("sold")]
        public double Sold { get; set; }
        [JsonProperty("state")]
        public bool State { get; set; }
        [JsonProperty("date_creation")]
        public DateTime DateCreation { get; set; }
    }
}