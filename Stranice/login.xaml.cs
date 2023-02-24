using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
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

namespace WPFprojekatSIMS
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        Repository.PacijentRepository pacijentRepository;
        public login()
        {
            InitializeComponent();
            pacijentRepository = new PacijentRepository();
            


        }

        private void prijava_button_click(object sender, RoutedEventArgs e)

        {

            pacijentRepository = new PacijentRepository();

            // uspesno_label.Visibility = Visibility.Hidden;
            // neuspesno_label.Visibility = Visibility.Hidden;


            string korisnicko = korisnicko_textbox.Text;
            string lozinka = lozinka_textbox.Password;

            string lekar = "lekar";
            string pacijent = "pacijent";
            string sekretar = "sekretar";
            string upravnik = "upravnik";
            
            //spojimo korisnicko , lozinku i ulogu u jedno

            string spojeno_lekar =    korisnicko + ',' + lozinka + ',' + lekar;
            string spojeno_pacijent = korisnicko + ',' + lozinka + ',' + pacijent;
            string spojeno_sekretar = korisnicko + ',' + lozinka + ',' + sekretar;
            string spojeno_upravnik = korisnicko + ',' + lozinka + ',' + upravnik;


            string path_login_csv = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\login.csv";
            string path_trenutno_ulogovani_csv = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\trenutno_ulogovani.csv";
            var DataContext = File.ReadAllLines(path_login_csv);
            foreach(var line in DataContext)
            {
                if(line.Equals(spojeno_lekar))
                {
                    Uri uri = new Uri("Stranice/LekarPocetna.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(uri);
                    break;
                }
                else if(line.Equals(spojeno_pacijent))
                {
                    Uri uri = new Uri("Stranice/PacijentPocetna.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(uri);
                    pacijentRepository.DodajPacijenta_u_trenutno_ulogovane(korisnicko, lozinka, path_trenutno_ulogovani_csv);

                    break;
                }

                else if(line.Equals(spojeno_sekretar))
                {
                    Uri uri = new Uri("Stranice/SekretarPocetna.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(uri);
                    break;
                }

                else if (line.Equals(spojeno_upravnik))
                {
                    Uri uri = new Uri("Stranice/UpravnikPocetna.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(uri);
                    break;
                }

                else
                {
                    neuspesno_logovanje_labela.Visibility = Visibility.Visible;
                }
            }

           /*if(uspesno_label.Visibility.Equals("Hidden"))
            {
                neuspesno_label.Visibility = Visibility.Visible;
            }
            */


            
           


        }

        private void registracija_button_click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Stranice/Registracija.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }


    
    }
}
