using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoinServer.ViewModels
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    using MyCoinData.Models;

    public class AllUserViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<User> LesUtilisateurs { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public AllUserViewModel()
        {
            LesUtilisateurs= new ObservableCollection<User>
                                 {
                                     new User()
                                         {
                                             Id = Guid.NewGuid().ToString(),
                                             DateCreation = DateTime.Now,
                                             Fullname = "BUSHIRI KEVIN",
                                             PublicKey = Guid.NewGuid().ToString(),
                                             Sold = 1200,
                                             State = false,
                                             Username = "kevB"
                                         },
                                     new User()
                                          {
                                               Id = Guid.NewGuid().ToString(),
                                               DateCreation = DateTime.Now,
                                               Fullname = "BUSHIRI KEVIN",
                                               PublicKey = Guid.NewGuid().ToString(),
                                               Sold = 1200,
                                               State = false,
                                               Username = "kevB"
                                           },
                                     new User()
                                           {
                                               Id = Guid.NewGuid().ToString(),
                                               DateCreation = DateTime.Now,
                                               Fullname = "BUSHIRI KEVIN",
                                               PublicKey = Guid.NewGuid().ToString(),
                                               Sold = 1200,
                                               State = false,
                                               Username = "kevB"
                                           }
                                 };
        }
    }
}
