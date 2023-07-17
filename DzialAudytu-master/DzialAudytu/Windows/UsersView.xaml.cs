﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DzialAudytu.ViewModels;
using DzialAudytuBazaDanych;

namespace DzialAudytu.Windows
{

    /// Interaction logic for UsersView.xaml

    public partial class UsersView : Window
    {
        public UsersView()
        {
            InitializeComponent();
            DataContext = new UsersViewModel(new DADbContext());
        }
    }
}
