using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace MyCoinData.Models
{

    public class Block
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
        [JsonProperty("hash_precedent")]
        public string HashPrecedent { get; set; }
        [JsonProperty("ListTransactions")]
        public List<Transaction> ListTransactions { get; set; }
    }
}
