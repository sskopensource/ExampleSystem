using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExampleSystem
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        private Model model;

        public Command(Model curModel)
        {
            model = curModel;
        }

        public void Execute(object parameter)
        {
            //Execute Button command
            if (model.Counter < 9)
            {
                model.Counter++;
            }
            else
            {
                model.Counter = 0;
            }
        }

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
