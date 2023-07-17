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

    /// Represents a view model for the Auction view, providing functionality for interacting with the DADbContext.

    public class AuctionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

   
        /// Initializes a new instance of the <see cref="AuctionViewModel"/> class.
        public AuctionViewModel(DADbContext context)
        {
            _context = context;
            DisplayComputerTable();
            AddElement = new RelayCommand(Add);
            RemoveElement = new RelayCommand(Remove);
        }

        /// Handles the removal of an existing auction element.

        private void Remove()
        {
            if (ID == null)
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var buyer = _context.Auctions.Find(int.Parse(ID));
            if (buyer == null)
            {
                MessageBox.Show("Nie znaleziono rekordu o podanym ID!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            _context.Auctions.Remove(buyer);
            _context.SaveChanges();
            DisplayComputerTable();
            ID = "";

        }

        public RelayCommand RemoveElement { get; set; }

        /// Handles the addition of a new auction element.
        private void Add()
        {
            if (Opis == null || CenaPodgladowa == null)
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (String.IsNullOrWhiteSpace(Opis) || String.IsNullOrWhiteSpace(CenaPodgladowa))
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!int.TryParse(CenaPodgladowa, out int result))
            {
                MessageBox.Show("Cena musi być liczbą!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var buyer = new Auction()
            {
                Opis = Opis,
                CenaPogladowa = Convert.ToInt32(CenaPodgladowa)
            };
            _context.Auctions.Add(buyer);
            _context.SaveChanges();
            DisplayComputerTable();
            Opis = "";
            CenaPodgladowa = "";
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Auction> _table;
        private readonly DADbContext _context;
        private string _Id;
        private string _opis;
        private string _cena;

        public ObservableCollection<Auction> Show
        {
            get => _table;
            set
            {
                _table = value;
                OnPropertyChanged();
            }
        }

        public string Opis
        {
            get
            {
                return _opis;
            }set
            {
                if (_opis != value)
                {
                    _opis = value;
                    OnPropertyChanged(nameof(Opis));
                }
            }
        }

        public string CenaPodgladowa
        {
            get
            {
                return _cena;
            }set
            {
                if (_cena != value)
                {
                    _cena = value;
                    OnPropertyChanged(nameof(CenaPodgladowa));
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

        /// Displays the list of auctions in the view.
        public void DisplayComputerTable()
        {
            Show = new ObservableCollection<Auction>(_context.Set<Auction>().ToList());
        }

        public ICommand AddElement { get; }

    }

}
