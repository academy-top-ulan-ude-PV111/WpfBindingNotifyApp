using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBindingNotifyApp
{
    internal class DataSource : INotifyPropertyChanged
    {
        private int value = 1;

        public int Value
        {
            get => value;
            set
            {
                this.value = value;
                OnPropertyChanged(nameof(this.Value));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
            PropertyChanged?.Invoke(this, args);
        }
    }
}
