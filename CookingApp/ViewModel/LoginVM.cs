using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CookingApp.ViewModel
{
    class LoginVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // если событие PropertyChanged не null, то вызываем событие и передаём имя свойства
        }

        private string _login;
        public string login
        {
            get { return _login; }
            set
            {
                _login = value;
            }
        }
    }
}
