using DzialAudytu.Windows;
using DzialAudytuBazaDanych.Tabele;
using DzialAudytuBazaDanych;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Security.Cryptography;


namespace DzialAudytu.ViewModels
{
    public class BuyerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public BuyerViewModel(DADbContext context)
        {
            _context = context;
            DisplayComputerTable();
            AddElement = new RelayCommand(Add);
            RemoveElement = new RelayCommand(Remove);
        }

        private void Remove()
        {
            if (ID == null)
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var buyer = _context.Buyers.Find(int.Parse(ID));
            if (buyer == null)
            {
                MessageBox.Show("Nie znaleziono rekordu o podanym ID!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            _context.Buyers.Remove(buyer);
            _context.SaveChanges();
            DisplayComputerTable();
            ID = "";

        }

        public RelayCommand RemoveElement { get; set; }

        private void Add()
        {
            if (Username == null || Password == null)
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var buyer = new Buyer()
            {
                Username = Username,
                Password = Password
            };
            _context.Buyers.Add(buyer);
            _context.SaveChanges();
            DisplayComputerTable();
            Username = "";
            Password = "";
        }

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

        private ObservableCollection<Buyer> _table;
        private readonly DADbContext _context;
        private string _username;
        private string _password;
        private string _Id;

        public ObservableCollection<Buyer> Show
        {
            get => _table;
            set
            {
                _table = value;
                OnPropertyChanged();
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public string ID
        {
            get
            {
                return _Id;
            }set
            {
                if (_Id != value)
                {
                    _Id = value;
                    OnPropertyChanged(nameof(ID));
                }
            }
        }

        public void DisplayComputerTable()
        {
            Show = new ObservableCollection<Buyer>(_context.Set<Buyer>().ToList());
        }

        public ICommand AddElement { get; }

    }
}
