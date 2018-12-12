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

    public class BlockDAO : IDataStore<Block>
    {
        private static BlockDAO _instance;

        public static BlockDAO Instance
        {
            get
            {
                if(_instance==null)
                    BlockDAO._instance= new BlockDAO();
                return _instance;
            }
        }
        public List<Block> AllItems()
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var blocks = db.GetCollection<Block>("Blocks");
                return blocks.FindAll();
            }
        }

        public void DeleteItem(Block item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var blocks = db.GetCollection<Block>("Blocks");
                blocks.Delete(u=>u.Id.Equals(item.Id));
            }
        }

        public void NewItem(Block item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var blocks = db.GetCollection<Block>("Blocks");
                blocks.Insert(new BsonValue(item.Id), item);
            }
        }

        public void UpdateItem(Block item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var blocks = db.GetCollection<Block>("Blocks");
                blocks.Update(new BsonValue(item.Id), item);
               
            }
        }

        

        public string Serialize(object item)
        {
            var json = JsonConvert.SerializeObject(item);
            return json;
        }

        public List<Block> DeserializeList(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(List<Block>));
            return (List<Block>)data;
        }

        public Block DeserializeObject(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(Block));
            return (Block)data;
        }
    }
}
