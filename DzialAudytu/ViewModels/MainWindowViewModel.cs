using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DzialAudytu.Windows;
using DzialAudytuBazaDanych;
using DzialAudytuBazaDanych.Tabele;

namespace DzialAudytu.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel(DADbContext context, string userLogged)
        {
            _context = context;
            DisplayComputerTable();
            _userLogged = userLogged;
            BuyersView = new RelayCommand(CustomersTableShow);
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

        private ObservableCollection<Computer> _computersTable;
        private readonly DADbContext _context;
        private string _userLogged;

        public ObservableCollection<Computer> ComputersTable
        {
            get => _computersTable;
            set
            {
                _computersTable = value;
                OnPropertyChanged();
            }
        }

        public string UserLogged
        {
            get
            {
                return "You are logged as "+_userLogged;
            }set
            {
                if (_userLogged != value)
                {
                    _userLogged = value;
                    OnPropertyChanged(nameof(UserLogged));
                }
            }
        }

        public void DisplayComputerTable()
        {
            ComputersTable = new ObservableCollection<Computer>(_context.Set<Computer>().ToList());
        }

        private void CustomersTableShow()
        {
            var window = new BuyersView();
            Application.Current.MainWindow = window;
            window.Show();
        }
        public ICommand BuyersView { get; }

    }
}
