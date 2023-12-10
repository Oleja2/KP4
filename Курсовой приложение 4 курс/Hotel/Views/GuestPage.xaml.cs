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

namespace Hotel.Views
{
    /// <summary>
    /// Interaction logic for GuestPage.xaml
    /// </summary>
    public partial class GuestPage : Page
    {
        public GuestPage()
        {
            InitializeComponent();
            if (MainWindow.Globals.userrole == 1)
            {
                Editguest.Visibility = Visibility.Visible;

            }
            else { Editguest.Visibility = Visibility.Collapsed; }
            GuestPG.ItemsSource = HotelEntities.GetContext().Guest.ToList();
        }

        private void Application_Click(object sender, RoutedEventArgs e)
        {
             WindowEditGuest WEG = new WindowEditGuest(null);
             WEG.Show();
        }

        private void DeleteGutest_Click(object sender, RoutedEventArgs e)
        {
            var Removing = GuestPG.SelectedItems.Cast<Guest>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элеметнов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    HotelEntities.GetContext().Guest.RemoveRange(Removing);
                    HotelEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удаленны");
                    GuestPG.ItemsSource = HotelEntities.GetContext().Room.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void UpdateGuest_Click(object sender, RoutedEventArgs e)
        {
            GuestPG.ItemsSource = HotelEntities.GetContext().Guest.ToList();
        }

        private void editGuest_Click(object sender, RoutedEventArgs e)
        {
            if (GuestPG.SelectedItem !=  null)
            {
                Window editGuest = new WindowEditGuest(GuestPG.SelectedItem as Guest);
                editGuest.ShowDialog();
                HotelEntities.GetContext().SaveChanges();
            }
            else
            {
                MessageBox.Show("Выбери что-то");
            }
        }
    }
}
