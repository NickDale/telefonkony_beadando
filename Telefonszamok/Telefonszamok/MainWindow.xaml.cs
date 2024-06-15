using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using enTelefonkony;
using cnTelefonkony;

namespace Telefonszamok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        cnTelefonkony.Model _context;
        public MainWindow()
        {
            InitializeComponent();
            _context = new cnTelefonkony.Model();
        }

        private void miMindenAdat_Click(object sender, RoutedEventArgs e)
        {
            var adatok = _context.enHelysegek.ToList();
            dgAdatok.ItemsSource = adatok;

        }

        private void miHelyseg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}