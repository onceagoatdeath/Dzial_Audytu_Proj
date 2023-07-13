using System.Windows;
using DzialAudytu.ViewModels;
using DzialAudytuBazaDanych;

namespace DzialAudytu.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string userlogged)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(new DADbContext(), userlogged);
        }
    }
}
