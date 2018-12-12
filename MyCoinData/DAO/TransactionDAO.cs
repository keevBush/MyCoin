using System;
using System.Collections.Generic;
using System.Text;
using MyCoinData.IData;
using MyCoinData.Models;

namespace MyCoinData.DAO
{
    using System.Linq;

    using LiteDB;

    using Newtonsoft.Json;

    public class TransactionDAO : IDataStore<Transaction>
    {
        private static TransactionDAO _instance;

        public static TransactionDAO Instance
        {
            get
            {
                if(_instance==null)
                    TransactionDAO._instance= new TransactionDAO();
                return _instance;
            }
        }
        public List<Transaction> AllItems()
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var transactions = db.GetCollection<Transaction>("Transactions");
                return transactions.FindAll();
            }
        }

        public void DeleteItem(Transaction item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var transactions = db.GetCollection<Transaction>("Transactions");
                transactions.Delete(u=>u.Id.Equals(item.Id));
            }
        }

        public void NewItem(Transaction item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var transactions = db.GetCollection<Transaction>("Transactions");
                transactions.Insert(new BsonValue(item.Id), item);
            }
        }

        public void UpdateItem(Transaction item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var transactions = db.GetCollection<Transaction>("Transactions");
                transactions.Update(new BsonValue(item.Id), item);
               
            }
        }

        

        public string Serialize(object item)
        {
            var json = JsonConvert.SerializeObject(item);
            return json;
        }

        public List<Transaction> DeserializeList(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(List<Transaction>));
            return (List<Transaction>)data;
        }

        public Transaction DeserializeObject(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(Transaction));
            return (Transaction)data;
        }
    }
}
