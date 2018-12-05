using System;
using Newtonsoft.Json;

namespace MyCoinData.Models
{

    public class Transaction
    {
        [JsonProperty("id")]//Id de la transaction
        public int Id { get; set; }
        [JsonProperty("public_key_dest")]
        public string PublcKeyDest { get; set; }//Key de Destination
        [JsonProperty("public_key_dest")]
        public string PublcProvKey { get; set; }//Key de provenance
        [JsonProperty("type")]
        public Type Type { get; set; }//le type de transfert
        [JsonProperty("etat")]
        public Etat Etat { get; set; }//l'etat du transfert
        [JsonProperty("value")]
        public double Value { get; set; }//la valeur du transfert

        private string _signature;
        [JsonProperty("signature")]
        public string Signature //Signature de la transaction
        {
            get
            {
                return this._signature;
            }
            private set
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
        Dépot,Transfert
    }

    public enum Etat
    {
        Encours,Effectuer,Annuler 
    }
}
