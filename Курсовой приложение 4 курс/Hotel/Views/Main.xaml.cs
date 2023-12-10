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
using System.Windows.Shapes;
using Hotel.Views;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;

namespace Hotel.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            Frame1.Navigate(new GuestPage());
            Manager.Frame1 = Frame1;

            if (MainWindow.Globals.userrole == 1)
            {
                World.Visibility = Visibility.Visible;

            }
            else { World.Visibility = Visibility.Collapsed; }
        }

        private void Room_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame1.Navigate(new RoomPage());
        }

        private void Application_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame1.Navigate(new ApplicationPage());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Auth = new MainWindow();
            Auth.Show();
            Close();
        }

        private void Guest_Click(object sender, RoutedEventArgs e)
        {
            Manager.Frame1.Navigate(new GuestPage());
        }

        private void Word_Click(object sender, RoutedEventArgs e)
        {
            var allRequest = HotelEntities.GetContext().Application.ToList();

            var application = new Word.Application();

            Word.Document document = application.Documents.Add();

            Word.Paragraph userParagraph = document.Paragraphs.Add();
            Word.Range userRange = userParagraph.Range;
            userRange.Text = "Отчёт по заявке";

            userRange.InsertParagraphAfter();

            Word.Paragraph tableParagraph = document.Paragraphs.Add();
            Word.Range tableRange = tableParagraph.Range;
            Word.Table paymentsTable = document.Tables.Add(tableRange, allRequest.Count() + 1, 6);
            paymentsTable.Borders.InsideLineStyle = paymentsTable.Borders.OutsideLineStyle
                = Word.WdLineStyle.wdLineStyleSingle;
            paymentsTable.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

            Word.Range cellRange;

            cellRange = paymentsTable.Cell(1, 1).Range;
            cellRange.Text = "ID Заявки";
            cellRange = paymentsTable.Cell(1, 2).Range;
            cellRange.Text = "Номер заявки";
            cellRange = paymentsTable.Cell(1, 3).Range;
            cellRange.Text = "Цена за сутки";
            cellRange = paymentsTable.Cell(1, 4).Range;
            cellRange.Text = "Категория номера";
            cellRange = paymentsTable.Cell(1, 5).Range;
            cellRange.Text = "ФИО";
            cellRange = paymentsTable.Cell(1, 6).Range;
            cellRange.Text = "Номер телефона";


            paymentsTable.Rows[1].Range.Bold = 1;
            paymentsTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            for (int i = 0; i < allRequest.Count(); i++)
            {
                var currentCategory = allRequest[i];
                cellRange = paymentsTable.Cell(i + 2, 1).Range;
                cellRange.Text = Convert.ToString(currentCategory.ID);
                cellRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                cellRange = paymentsTable.Cell(i + 2, 2).Range;
                cellRange.Text = Convert.ToString(currentCategory.Room.Number);

                cellRange = paymentsTable.Cell(i + 2, 3).Range;
                cellRange.Text = Convert.ToString(currentCategory.Room.Price);

                cellRange = paymentsTable.Cell(i + 2, 4).Range;
                cellRange.Text = Convert.ToString(currentCategory.Room.Category);

                cellRange = paymentsTable.Cell(i + 2, 5).Range;
                cellRange.Text = Convert.ToString(currentCategory.Guest.FullName);
                cellRange = paymentsTable.Cell(i + 2, 6).Range;
                cellRange.Text = Convert.ToString(currentCategory.PhoneNumber);
            }
            application.Visible = true;
        }
    }
}


