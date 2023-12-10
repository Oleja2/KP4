using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

namespace Hotel.Views
{
    /// <summary>
    /// Interaction logic for WindowEditRoom.xaml
    /// </summary>
    public partial class WindowEditRoom : Window
    {
        private Room _currentRoom = new Room();
        public WindowEditRoom(Room room)
        {
            InitializeComponent();
            if (room != null )
            {
                _currentRoom = room;
                EditRoom.Content = "Сохранить";
            }
            DataContext = _currentRoom;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder Errors = new StringBuilder();
            if (textBoxNumber.Text == "")
                Errors.AppendLine("Введите номер!");
            if (textBoxCategory.Text == "")
                Errors.AppendLine("Введите категорию");
            if (textBoxPrice.Text == "")
                Errors.AppendLine("Введите цену");

            if (Errors.Length > 0)
            {
                MessageBox.Show(Errors.ToString());
                return;
            }

            if (_currentRoom.ID == 0)
            {
                HotelEntities.GetContext().Room.Add(_currentRoom);
            }

            try
            {
                HotelEntities.GetContext().SaveChanges();
                MessageBox.Show("Номер добавлен");
                Close();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
