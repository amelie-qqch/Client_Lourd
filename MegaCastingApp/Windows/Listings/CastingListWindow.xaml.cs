﻿using MegaCastingApp.ViewModel.Listings;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCastingApp.Windows.Listings
{
    /// <summary>
    /// Logique d'interaction pour CastingListWindow.xaml
    /// </summary>
    public partial class CastingListWindow : UserControl
    {
        public CastingListWindow()
        {
            InitializeComponent();
            this.DataContext = new CastingListViewModel();
        }
    }
}
