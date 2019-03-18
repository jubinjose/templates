using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SnackMachine.UI.WPF
{
    public class Command : ICommand
    {
        public delegate void ExecuteMethod();
        private ExecuteMethod meth;
        public Command(ExecuteMethod exec)
        {
            meth = exec;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            meth();
        }
    }
}
