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

namespace ToursApp {
    /// <summary>
    /// Interaction logic for TourPage.xaml
    /// </summary>
    public partial class TourPage : Page {
        public TourPage() {
            InitializeComponent();

            var allTypes = TourBaseEntities.getConext().Type.ToList();
            allTypes.Insert(0, new Type
            {
                Name = "Все типы"
            });
            ComboType.ItemsSource = allTypes;

            checkActual.IsChecked = true;
            ComboType.SelectedIndex = 0;

            UpdateTours();
        }

        private void UpdateTours() {
            var currentTours = TourBaseEntities.getConext().Tour.ToList();

            if (ComboType.SelectedIndex > 0) {
                currentTours = currentTours.Where(p => p.Type.Contains(ComboType.SelectedItem as Type)).ToList();
            }

            currentTours = currentTours.Where(p => p.Name.ToLower().Contains(TBoxSea.Text.ToLower())).ToList();

            if ((bool)checkActual.IsChecked)
            {
                currentTours = currentTours.Where(p => (bool)p.isActual).ToList();
            }


            LViewTours.ItemsSource= currentTours.OrderBy(p => p.TicketCount).ToList();

        }


        private void TBoxSea_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
            UpdateTours();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            UpdateTours();
        }

        private void checkActual_Checked(object sender, RoutedEventArgs e) {
            UpdateTours();
        }

        private void checkActual_Unchecked(object sender, RoutedEventArgs e) {
            UpdateTours();
        }

        private void TBoxSea_TextChanged(object sender, TextChangedEventArgs e) {
            UpdateTours();
        }
    }
}
