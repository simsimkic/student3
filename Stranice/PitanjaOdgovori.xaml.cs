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
using Controller;
using Model;
using Repository;

namespace WPFprojekatSIMS.Stranice
{
    /// <summary>
    /// Interaction logic for PitanjaOdgovori.xaml
    /// </summary>
    public partial class PitanjaOdgovori : Page
    {
        Controller.PacijentController pacijentController;
        Repository.PacijentRepository pacijentRepository;
        public PitanjaOdgovori()
        {
            InitializeComponent();
            pacijentController = new PacijentController();
            data_grid_komentari.DataContext = pacijentController.PrikaziKomentare();

        }

        private void ostavi_komentar_button_click(object sender, RoutedEventArgs e)
        {
            string uneti_komentar = uneti_komentar_textbox.Text;
            pacijentController = new PacijentController();
            data_grid_komentari.DataContext = pacijentController.DodajKomentar(uneti_komentar);
        }



        private void nazad_button_click(object sender, RoutedEventArgs e)
        {
            
            Uri uri = new Uri("Stranice/PacijentPocetna.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

        }
    }
}
