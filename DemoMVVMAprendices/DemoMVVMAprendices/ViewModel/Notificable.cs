using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoMVVMAprendices.ViewModel
{ 
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    public class Notificable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
