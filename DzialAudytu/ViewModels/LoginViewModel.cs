using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DzialAudytu.Windows;
using DzialAudytuBazaDanych;

namespace DzialAudytu.ViewModels
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public LoginViewModel(DADbContext context)
        {
            _context = context;
            LoginCommand = new RelayCommand(Login);
        }

        private string _login;
        public string LOGIN
        {
            get
            {
                return _login;
            }set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged(nameof(LOGIN));
                }
            }
        }

        private string _password;
        private readonly DADbContext _context;

        public string PASSWORD
        {
            get
            {
                return _password;
            }set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(PASSWORD));
                }
            }
        }

        public ICommand LoginCommand { get; }
        private void Login()
        {
            var user = _context.Users.FirstOrDefault(x => x.Username == LOGIN && x.Password == PASSWORD);
            if (user != null)
            {
                MessageBox.Show("Zalogowano");
                var window = new MainWindow(LOGIN);
                if (Application.Current.MainWindow != null)
                {
                    Application.Current.MainWindow.Close();
                }
                Application.Current.MainWindow = window;
                window.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane");
            }
        }
    }


}
