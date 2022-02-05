using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSystem
{
    public class Model
    {
        public int _counter;
        public int Counter
        {
            get
            {
                return _counter;
            }
            set
            {
                _counter = value;
                OnTxtChanged();
            }
        }

        public event Action TxtChanged;

        private void OnTxtChanged()
        {
            //Invoke event when Counter property is changed
            TxtChanged?.Invoke();
        }
    }
}
