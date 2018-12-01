using System;

namespace MyCoinServerData.Models
{
    using Newtonsoft.Json;

    public class Transaction
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("public_key_dest")]
        public string PublcKeyDest { get; set; }
        [JsonProperty("type")]
        public Type Type { get; set; }
        [JsonProperty("etat")]
        public Etat Etat { get; set; }
        [JsonProperty("value")]
        public double Value { get; set; }

        private string _signature;
        [JsonProperty("signature")]
        public string Signature
        {
            get
            {
                return this._signature;
            }
            set
            {
                HashSignature();
                this._signature = value;
            }
        }

        private void HashSignature()
        {
            throw new NotImplementedException();
        }
    }
    public enum Type {

    }

    public enum Etat
    {

    }
}
