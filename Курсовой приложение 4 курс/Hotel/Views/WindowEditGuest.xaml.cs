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
    /// Interaction logic for WindowEditGuest.xaml
    /// </summary>
    public partial class WindowEditGuest : Window
    {
        private Guest _currentGuest = new Guest();
        public WindowEditGuest(Guest guest)
        {
            InitializeComponent();
            if (guest != null )
            {
                _currentGuest = guest;
                GuestEdit.Content = "Сохранить";
            }
            DataContext = _currentGuest;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder Errors = new StringBuilder();
            if (textBoxPhoneNumber.Text == "")
                Errors.AppendLine("ФИО!");
            if (textBoxFullName.Text == "")
                Errors.AppendLine("Телефон");
            if (textBoxPassportData.Text == "")
                Errors.AppendLine("Паспорт");

            if (Errors.Length > 0)
            {
                MessageBox.Show(Errors.ToString());
                return;
            }

            if (_currentGuest.ID == 0)
            {
                HotelEntities.GetContext().Guest.Add(_currentGuest);
            }

            try
            {
                HotelEntities.GetContext().SaveChanges();
                MessageBox.Show("Гость добавлен");
                Close();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
