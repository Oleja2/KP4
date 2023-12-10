using Hotel.Views;
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
using System.Threading;
using System.Windows.Threading;
using System.Security.Cryptography;

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string Pas_and_Log_E(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] b = Encoding.UTF8.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));

            return Convert.ToString(sb);
        }

        DispatcherTimer timer = new DispatcherTimer();
        string code;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public static class Globals
        {
            public static int userrole;
            public static User userinfo { get; set; }
        }
        private void gencode()
        {
            code = null;
            Random random = new Random();
            string[] massiveCharacters = new string[] { "2", "6", "7", "8", };
            for (int i = 0; i < 3; i++)
            {
                code += massiveCharacters[random.Next(0, massiveCharacters.Length)];
            }
            textBoxCodSpawn.Text = code;
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
            textBoxCod.IsEnabled = true;
            Vhod.IsEnabled = true;
            Cod.IsEnabled = true;
            Cod.Visibility = Visibility.Visible;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            code = null;
            MessageBox.Show("Время написания кода вышло. Повторите попытку");
            timer.Stop();
        }

        private void Cod_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            gencode();
            Cod.Focus();
        }

        private void LogBlock_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using (var db = new HotelEntities())
                {
                    var LoginH = Pas_and_Log_E(textBoxLogin.Text);
                    var login = db.User.AsNoTracking().FirstOrDefault(l => l.Login == LoginH);
                    if (login == null)
                    {
                        MessageBox.Show("Неверный логин");
                    }
                    else
                    {
                        textBoxPassword.IsEnabled = true;
                        textBoxLogin.IsEnabled = false;
                        textBoxPassword.Focus();
                    }
                }
            }
        }

        private void PassBlock_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using (var db = new HotelEntities())
                {
                    var LoginH = Pas_and_Log_E(textBoxLogin.Text);
                    var PassH = Pas_and_Log_E(textBoxPassword.Text);
                    var login = db.User.AsNoTracking().FirstOrDefault(l => l.Login == LoginH & l.Password == PassH);
                    if (login == null)
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                    else
                    {
                        textBoxPassword.IsEnabled = false;
                        gencode();
                        textBoxCod.Focus();
                    }
                }
            }
        }

        private void CodeBlock_Up(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Vhod_Click(sender, e); 
            }
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new HotelEntities())
            {
                var LoginH = Pas_and_Log_E(textBoxLogin.Text);
                var PassH = Pas_and_Log_E(textBoxPassword.Text);
                var auth = db.User.AsNoTracking().FirstOrDefault(m => m.Login == LoginH && m.Password ==PassH);
                if (auth != null & code == textBoxCod.Text)
                {
                    timer.Stop();
                    Globals.userrole = auth.RoleID;
                    Globals.userinfo = auth;
                    if (Globals.userrole == 1)
                    {
                        MessageBox.Show("Вы вошли с правами Администратора ИС");
                    }
                    else
                    {
                        MessageBox.Show("Вы вошли с правами Администратора");
                    }
                    Main Mwin = new Main();
                    Mwin.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверно написанн код, повторите снова!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    timer.Stop();
                }
            }
        }

        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxCod.Clear();
            textBoxLogin.IsEnabled = true;
            textBoxPassword.IsEnabled = false;
            textBoxCod.IsEnabled = false;
        }
    }
}
