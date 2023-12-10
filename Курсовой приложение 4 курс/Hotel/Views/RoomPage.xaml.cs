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
    /// Interaction logic for RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        public RoomPage()
        {
            InitializeComponent();
            if (MainWindow.Globals.userrole == 1)
            {
                EditRoom1.Visibility = Visibility.Visible;

            }
            else { EditRoom1.Visibility = Visibility.Collapsed; }
            RoomPG.ItemsSource = HotelEntities.GetContext().Room.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            WindowEditRoom WER = new WindowEditRoom(null);
            WER.Show();
        }

        private void DelR_Click(object sender, RoutedEventArgs e)
        {
            var Removing = RoomPG.SelectedItems.Cast<Room>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элеметнов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    HotelEntities.GetContext().Room.RemoveRange(Removing);
                    HotelEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удаленны");
                    RoomPG.ItemsSource = HotelEntities.GetContext().Room.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void OBT_Click(object sender, RoutedEventArgs e)
        {
            RoomPG.ItemsSource = HotelEntities.GetContext().Room.ToList();
        }

        private void editGuest_Click(object sender, RoutedEventArgs e)
        {
            if (RoomPG.SelectedItem != null)
            {
                WindowEditRoom editRoom = new WindowEditRoom(RoomPG.SelectedItem as Room);
                editRoom.ShowDialog();
                HotelEntities.GetContext().SaveChanges();
            }
            else
            {
                MessageBox.Show("Выбери что-то");
            }
        }
    }
}
