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
using Telefonszamok.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
            grHelyseg.Visibility = Visibility.Hidden;
            dgAdatok.Visibility = Visibility.Visible;

            var data = (from x in _context.enSzemlyek.Include(x => x.enHelyseg).Include(x => x.enTelefonszamok)
                        select new
                        {
                            Vezeteknév = x.vezeteknev,
                            Utónév = x.utonev,
                            Irányítószám = x.enHelyseg.IRSZ,
                            Helységnév = x.enHelyseg.nev,
                            Lakcim = x.lakcim,
                            Telefonszámok = x.Telefonszamok
                        }
                       ).ToList();

            dgAdatok.ItemsSource = data;
        }

        private void miHelysegek_Click(object sender, RoutedEventArgs e)
        {
            grHelyseg.Visibility = Visibility.Hidden;
            dgAdatok.Visibility = Visibility.Visible;
            var er = (from x in _context.enHelysegek select new { Irányítószám = x.IRSZ, Város = x.nev }).ToList();
            dgAdatok.ItemsSource = er;
        }

        private void miHelysegekAM_Click(object sender, RoutedEventArgs e)
        {
            dgAdatok.Visibility = Visibility.Collapsed;
            grHelyseg.Visibility = Visibility.Visible;

            grHelyseg.DataContext = _context.enHelysegek.ToList();

            cbIrsz.SelectedItem = 0;
        }

        private void btUjHelyseg_Click(object sender, RoutedEventArgs e)
        {
            Beallit(false);
            tbIrsz.Text = "";
            tbHelysegnev.Text = "";
        }

        private void Beallit(bool enabled)
        {
            btUjHelyseg.IsEnabled = enabled;
            cbIrsz.IsEnabled = enabled;
            cbHelysegnev.IsEnabled = enabled;
        }

        private void btVissza_Click(object sender, RoutedEventArgs e)
        {
            grHelyseg.Visibility = Visibility.Hidden;
        }

        private void cbIrsz_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var enAktualis = ((ComboBox)sender).SelectedItem as enHelyseg;
            if (enAktualis != null)
            {
                cbHelysegnev.SelectedItem = enAktualis;
                tbIrsz.Text = enAktualis.IRSZ.ToString();
                tbHelysegnev.Text = enAktualis.nev;
            }
        }

        private void btRogzit_Click(object sender, RoutedEventArgs e)
        {
            var enAktualis = cbIrsz.SelectedItem as enHelyseg;
            if (enAktualis == null)
            {
                return;
            }

            try
            {
                if (!btUjHelyseg.IsEnabled)
                {
                    enAktualis = new enHelyseg();
                    _context.enHelysegek.Add(enAktualis);
                }
                enAktualis.IRSZ = tbIrsz.Text;
                enAktualis.nev = tbHelysegnev.Text;
                grHelyseg.Visibility = Visibility.Hidden;
                _context.SaveChanges();
                MessageBox.Show("A módosítás sikeresen mentésre került", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a mentés során", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void miKilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void miMentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Minden adatok mentettünk", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a mentés során", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}