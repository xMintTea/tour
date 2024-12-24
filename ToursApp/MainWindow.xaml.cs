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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private bool shouldClearNavHistory = false;
        public MainWindow() {

            InitializeComponent();
            UserBox.SelectedIndex = 0;
            MainFrame.Navigate(new TourPage());
            //MainFrame.Navigate(new HotelsPage(UserBox.SelectedIndex));
            Manager.MainFrame = MainFrame;



        }

        private void backBtn_Click(object sender, RoutedEventArgs e) {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e) {

            if (shouldClearNavHistory)
            {
                while (MainFrame.CanGoBack)
                {
                    try
                    {
                        MainFrame.RemoveBackEntry();
                    }
                    catch (Exception ex)
                    {
                        break;
                    }
                }

                this.shouldClearNavHistory = false;
            }

            if (MainFrame.CanGoBack) { 
                backBtn.Visibility = Visibility.Visible;
            } else
            {
                backBtn.Visibility = Visibility.Hidden;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            MainFrame.Navigate(new HotelsPage(UserBox.SelectedIndex));
            Manager.MainFrame = MainFrame;
            this.shouldClearNavHistory = true;
        }
    }
}
