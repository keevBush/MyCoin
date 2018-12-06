using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoinServer.ViewModels
{
    using System.Windows.Input;

    public class DelegateCommand : ICommand
    {
        private Action<object> Action;

        private Func<bool> IfCanExecute;

        public DelegateCommand(Action<object> action)
        {
            this.Action = action;
            //this.IfCanExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.Action(parameter);
        }
    }
}
