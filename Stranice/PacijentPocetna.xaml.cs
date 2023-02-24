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
using Model;
using Repository;

namespace WPFprojekatSIMS
{
    /// <summary>
    /// Interaction logic for PacijentPocetna.xaml
    /// </summary>
    public partial class PacijentPocetna : Page
    {
        Repository.PacijentRepository pacijentRepository;
        public PacijentPocetna()
        {
            InitializeComponent();
        }

        private void pitanja_odgovori_button_click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Stranice/PitanjaOdgovori.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void odjava_button_click(object sender, RoutedEventArgs e)
        {
            pacijentRepository = new PacijentRepository();
            pacijentRepository.ObrisiTrenutnoUlogovani();
            Uri uri = new Uri("Stranice/login.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
