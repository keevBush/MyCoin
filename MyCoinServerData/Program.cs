using System;

namespace MyCoinServerData
{
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
            var values = new UserDAO ().Mapper();
            Console.WriteLine(values);
            Console.ReadKey();
        }
    }
}
