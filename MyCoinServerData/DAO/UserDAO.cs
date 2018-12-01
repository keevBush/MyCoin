using System;
using System.Collections.Generic;
using System.Text;
using MyCoinServerData.IData;
using MyCoinServerData.Models;

namespace MyCoinServerData.DAO
{

    public class UserDAO : IDataStore<User>
    {
        public List<User> AllItems()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(User item)
        {
            throw new NotImplementedException();
        }

        public void NewItem(User item)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(User item)
        {
            throw new NotImplementedException();
        }
    }
}
