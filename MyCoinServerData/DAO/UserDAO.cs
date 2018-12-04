using System;
using System.Collections.Generic;
using System.Text;
using MyCoinServerData.IData;
using MyCoinServerData.Models;

namespace MyCoinServerData.DAO
{
    using System.Linq;

    using LiteDB;

    using Newtonsoft.Json;

    public class UserDAO : IDataStore<User>
    {
        public List<User> AllItems()
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var users = db.GetCollection<User>("Users");
                return users.FindAll().ToList();
            }
        }

        public void DeleteItem(User item)
        {
            throw new NotImplementedException();
        }

        public void NewItem(User item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var users = db.GetCollection<User>("Users");
                users.Insert(new BsonValue(item.Id), item);
            }
        }

        public void UpdateItem(User item)
        {
            using (var db = new LiteDatabase(@"DataBase.db"))
            {
                var users = db.GetCollection<User>("Users");
                users.Update(new BsonValue(item.Id), item);
            }
        }

        

        public string Serialize(object item)
        {
            var json = JsonConvert.SerializeObject(item);
            return json;
        }

        public List<User> DeserializeList(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(List<User>));
            return (List<User>)data;
        }

        public User DeserializeObject(string value)
        {
            var data = JsonConvert.DeserializeObject(value, typeof(User));
            return (User)data;
        }
    }
}
