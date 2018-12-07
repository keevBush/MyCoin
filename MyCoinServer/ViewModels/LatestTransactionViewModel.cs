using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoinServer.ViewModels
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows;

    using MyCoinData.Models;

    public class LatestTransactionViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<User> LstActifUsers { get; set;}

        public DelegateCommand AddUserCommand { get; set; }

        public DelegateCommand DeleteUserCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LatestTransactionViewModel()
        {
            LstActifUsers= new ObservableCollection<User>
                               {
                                   new User()
                                       {
                                           Username = "username 1",
                                           DateCreation = DateTime.Now
                                       },
                                   new User()
                                       {
                                           Username = "username 1",
                                           DateCreation = DateTime.Today
                                       },
                                   new User()

                               };
            this.AddUserCommand=new DelegateCommand(ExecuteAddUserCommand);
        }

        private bool CanExecuteAddUserCommand()
        {
            return true;
        }

        private void ExecuteAddUserCommand(object obj)
        {

            MessageBox.Show($"{obj}");
        }
    }
}
