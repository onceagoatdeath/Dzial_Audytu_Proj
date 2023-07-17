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
    /// Represents a view model for the MainWindow view, providing functionality for displaying computer tables and navigating to other views.
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        public MainWindowViewModel(DADbContext context, string userLogged)
        {
            _context = context;
            DisplayComputerTable();
            _userLogged = userLogged;
            BuyersView = new RelayCommand(CustomersTableShow);
            UsersView = new RelayCommand(UsersTableShow);
            AuctionView = new RelayCommand(AuctionsTableShow);
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private ObservableCollection<Computer> _computersTable;
        private readonly DADbContext _context;
        private string _userLogged;

        /// Gets or sets the collection of computers to display in the table.
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

        /// Displays the computer table by fetching the data from the DADbContext.
        public void DisplayComputerTable()
        {
            ComputersTable = new ObservableCollection<Computer>(_context.Set<Computer>().ToList());
        }

        /// Navigates to the BuyersView to display the list of buyers.
        private void CustomersTableShow()
        {
            var window = new BuyersView();
            Application.Current.MainWindow = window;
            window.Show();
        }

        /// Navigates to the UsersView to display the list of users.
        private void UsersTableShow()
        {
            var window = new UsersView();
            Application.Current.MainWindow = window;
            window.Show();
        }

        /// Navigates to the AuctionView to display the list of auctions.
        private void AuctionsTableShow()
        {
            var window = new AuctionView();
            Application.Current.MainWindow = window;
            window.Show();
        }

        /// Gets the command to navigate to the BuyersView.
        public ICommand BuyersView { get; }

        /// Gets the command to navigate to the UsersView.
        public ICommand UsersView { get; }

        /// Gets the command to navigate to the AuctionView.
        public ICommand AuctionView { get; }

    }
}
