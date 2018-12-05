using System;
using System.Collections.Generic;
using System.Text;

namespace MyCoinData.Models
{
    using Newtonsoft.Json;

    public class Node
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("previews_node")]
        public Node PreviewNode { get; set; }
    }
}
