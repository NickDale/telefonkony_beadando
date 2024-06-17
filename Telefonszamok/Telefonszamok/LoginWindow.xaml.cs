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

namespace Telefonszamok
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private cnTelefonkony.Model _context;

        public LoginWindow()
        {
            InitializeComponent();
            _context = new cnTelefonkony.Model();
        }


        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var username = tbEmail.Text;
            var password = pbPassword.Password;

            var user = _context.enFelhasznalok.SingleOrDefault(u => u.email == username || u.nev == username);
            if (user != null && PasswordHelper.VerifyPassword(password, user.password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Érvénytelen email vagy jelszó", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
