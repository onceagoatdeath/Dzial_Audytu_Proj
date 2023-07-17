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
using System.Windows.Input;
using System.Windows;

namespace DzialAudytu.ViewModels
{
    /// Represents a view model for managing users, providing functionality for displaying and editing the user table.
     public class UsersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// Initializes a new instance of the <see cref="UsersViewModel"/> class.
        public UsersViewModel(DADbContext context)
        {
            _context = context;
            DisplayTable();
            AddElement = new RelayCommand(Add);
            RemoveElement = new RelayCommand(Remove);
        }

        /// Removes a user from the table based on the provided ID.
        private void Remove()
        {
            if (ID == null)
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var buyer = _context.Users.Find(int.Parse(ID));
            if (buyer == null)
            {
                MessageBox.Show("Nie znaleziono rekordu o podanym ID!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            _context.Users.Remove(buyer);
            _context.SaveChanges();
            DisplayTable();
            ID = "";

        }

        public RelayCommand RemoveElement { get; set; }

        /// Adds a new user to the table using the provided username and password.
        private void Add()
        {
            if (Username == null || Password == null)
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var buyer = new User()
            {
                Username = Username,
                Password = Password
            };
            _context.Users.Add(buyer);
            _context.SaveChanges();
            DisplayTable();
            Username = "";
            Password = "";
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<User> _table;
        private readonly DADbContext _context;
        private string _username;
        private string _password;
        private string _Id;

        public ObservableCollection<User> Show
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

        public void DisplayTable()
        {
            Show = new ObservableCollection<User>(_context.Set<User>().ToList());
        }

        public ICommand AddElement { get; }

    }

    }
