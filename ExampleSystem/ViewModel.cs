using System.ComponentModel;
using System.Windows.Input;

namespace ExampleSystem
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Model _model;

        public Model Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public ICommand command { get; set; }

        public ViewModel()
        {
            //Creating Model Instance
            Model = new Model() { Counter = 0 };

            //Subscribing to model TxtChanged event in viewModel
            Model.TxtChanged += OnTextChanged;

            //Creating Command for button
            command = new Command(Model);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void OnTextChanged()
        {
            OnPropertyChanged(nameof(Label));
        }

        public int Label => Model.Counter;
    }
} 
