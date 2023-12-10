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
    /// Interaction logic for ApplicationPage.xaml
    /// </summary>
    public partial class ApplicationPage : Page
    {
        public ApplicationPage()
        {
            InitializeComponent();
            ApplicationPG.ItemsSource = HotelEntities.GetContext().Application.ToList();
        }

        private void Application_Click(object sender, RoutedEventArgs e)
        {
            WindowApplication WA = new WindowApplication();
            WA.Show();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var Removing = ApplicationPG.SelectedItems.Cast<Application>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {Removing.Count()} элеметнов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    HotelEntities.GetContext().Application.RemoveRange(Removing);
                    HotelEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удаленны");
                    ApplicationPG.ItemsSource = HotelEntities.GetContext().Application.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void UpdateGuest_Click(object sender, RoutedEventArgs e)
        {
            ApplicationPG.ItemsSource = HotelEntities.GetContext().Application.ToList();
        }
    }
}
