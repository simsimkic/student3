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

namespace WPFprojekatSIMS.Stranice
{
    /// <summary>
    /// Interaction logic for ZakazivanjeOperacije.xaml
    /// </summary>
    public partial class ZakazivanjeOperacije : Page
    {
        PacijentController pacijentController;
        public ZakazivanjeOperacije()
        {
            InitializeComponent();
            pacijentController = new PacijentController();
            datagrid_operacija.DataContext = pacijentController.IzlistajPacijente();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pacijentController = new PacijentController();

            string ime = ImePacijenta.Text;
            string prezime = PrezimePacijenta.Text;
            string datumoperacije = Datum.SelectedDate.ToString();
            string vremeoperacije = Vreme.Text;
            string oznaka = Oznaka.Text;

            datagrid_operacija.DataContext = pacijentController.ZakaziOperaciju(ime, prezime, datumoperacije, vremeoperacije, oznaka);

        }

        private void nazad_button_click(object sender, RoutedEventArgs e)
        {
          

            Uri uri = new Uri("Stranice/LekarPocetna.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

        }
    }
}
