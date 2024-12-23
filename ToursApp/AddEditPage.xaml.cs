using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page {

        private Hotel currentHotel = new Hotel();

        public AddEditPage(Hotel selectedHotel) {

            if (selectedHotel != null)
            {
                currentHotel = selectedHotel;
            }

            InitializeComponent();
            DataContext = currentHotel;
            ComboCountries.ItemsSource = TourBaseEntities.getConext().Country.ToList();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e) {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentHotel.Name)) {
                errors.AppendLine("Укажите название отеля");
            }

            if (currentHotel.CountOfStars <1 || currentHotel.CountOfStars > 5) {
                errors.AppendLine("Количество звёзд - число от 1 до 5");
            }

            if (currentHotel.Country == null) {
                errors.AppendLine("Выберите страну");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }



            if (currentHotel.id == 0) {
                TourBaseEntities.getConext().Hotel.Add(currentHotel);
                MessageBox.Show(currentHotel.Name);
            }

            TourBaseEntities.getConext().SaveChanges();
            MessageBox.Show("Информация успешно сохранена");
            Manager.MainFrame.GoBack();

            try {

            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }


        }
    }
}
