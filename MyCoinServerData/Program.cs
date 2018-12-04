using System;

namespace MyCoinServerData
{
    using System.Collections.Generic;

    using MyCoinServerData.DAO;
    using MyCoinServerData.Models;

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
                            {
                                Id = Guid.NewGuid().ToString(),
                                DateCreation = DateTime.Today,
                                Password = "Mot de pass Hashee",
                                Sold = 1200,
                                State = true,
                                Username = "myUserName"
                            };
            
            var values = new UserDAO().Serialize(new List<User>(){user,user,user});
            var data = new UserDAO().DeserializeList(values);
            foreach (var d in data)
            {
                Console.WriteLine($"{d}");
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine(values);
            Console.ReadKey();
        }
    }
}
