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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToursApp {
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page {
        public HotelsPage() {
            InitializeComponent();
            DGridHotels.ItemsSource = TourBaseEntities.getConext().Hotel.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
               Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e) {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e) {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e) {

        }
    }
}
