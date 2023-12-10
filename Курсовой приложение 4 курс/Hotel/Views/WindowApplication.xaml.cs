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
    /// Interaction logic for WindowApplication.xaml
    /// </summary>
    public partial class WindowApplication : Window
    {
        private Application _currentApplication = new Application();
        public WindowApplication()
        {
            InitializeComponent();
            ComboBoxnumber.ItemsSource = HotelEntities.GetContext().Room.ToList();
            ComboBoxFullName.ItemsSource = HotelEntities.GetContext().Guest.ToList();
            DataContext = _currentApplication;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var c1 = ComboBoxnumber.SelectedItem as Room;
            var c4 = ComboBoxFullName.SelectedItem as Guest;
            StringBuilder Errors = new StringBuilder();
            if (textBoxPhoneNumber.Text == "")
                Errors.AppendLine("Введите номер!");

            if (Errors.Length > 0)
            {
                MessageBox.Show(Errors.ToString());
                return;
            }

            if (_currentApplication.ID >= 0)
            {
                HotelEntities.GetContext().Application.Add(_currentApplication);
            }

            try
            {
                HotelEntities.GetContext().SaveChanges();
                MessageBox.Show("Заявка добавлена");
                Close();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                    MessageBox.Show("");
                    foreach (DbValidationError err in validationError.ValidationErrors)
                    {
                        MessageBox.Show(err.ErrorMessage + "");
                    }
                }
            }
            /*catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/
        }

        private void ComboBoxnumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
