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

    public class NodeDAO : IDataStore<Node>
    {
        private static NodeDAO _instance;

        public static NodeDAO Instance
        {
            get
            {
                if(_instance==null)
                    NodeDAO._instance= new NodeDAO();
                return _instance;
            }
        }
        public List<Node> AllItems()
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var nodes = db.GetCollection<Node>("Nodes");
                return nodes.FindAll();
            }
        }

        public void DeleteItem(Nodes item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var nodes = db.GetCollection<Node>("Nodes");
                nodes.Delete(u=>u.Id.Equals(item.Id));
            }
        }

        public void NewItem(Node item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var nodes = db.GetCollection<Node>("Nodes");
                nodes.Insert(new BsonValue(item.Id), item);
            }
        }

        public void UpdateItem(Node item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var nodes = db.GetCollection<Node>("Nodes");
                nodes.Update(new BsonValue(item.Id), item);
               
            }
        }

        

        public string Serialize(object item)
        {
            var json = JsonConvert.SerializeObject(item);
            return json;
        }

        public List<Node> DeserializeList(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(List<Node>));
            return (List<Node>)data;
        }

        public Node DeserializeObject(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(Node));
            return (Node)data;
        }
    }
}
