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
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page {
        private int userId;
        public HotelsPage(int userId) {
            this.userId = userId;
            InitializeComponent();

            if (this.userId == 0 || this.userId == 1)
            {
                AddBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;

            }

            

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e) {

            if (this.userId == 0)
            {
                MessageBox.Show("Недостаточно прав");
                return;
            }

            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Hotel));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e) {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e) {
            var hotelsForRemoving = DGridHotels.SelectedItems.Cast<Hotel>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементов?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TourBaseEntities.getConext().Hotel.RemoveRange(hotelsForRemoving);
                    TourBaseEntities.getConext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridHotels.ItemsSource = TourBaseEntities.getConext().Hotel.ToList();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e) {
            if (Visibility == Visibility.Visible)
            {
                TourBaseEntities.getConext().ChangeTracker.Entries().ToList().ForEach(entry => entry.Reload());
                    DGridHotels.ItemsSource = TourBaseEntities.getConext().Hotel.ToList();
                
            }
        }
    }
}
