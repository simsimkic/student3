using Controller;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace WPFprojekatSIMS
{
    /// <summary>
    /// Interaction logic for Prostorije.xaml
    /// </summary>
    public partial class Prostorije : Page
    {
        //Model.Prostorija prostorija;
        ProstorijaController prostorijaController;
        public Prostorije()
        {
           
            InitializeComponent();
            prostorijaController = new ProstorijaController();
            datagrid_prostorije.DataContext = prostorijaController.IzlistajSveProstorije();
        }

        private void zakazi_renoviranje_button_Click(object sender, RoutedEventArgs e)
        {
            
            prostorijaController = new ProstorijaController();
            
            string id = id_prostorije_textbox.Text;
            string pocetak_renoviranja = pocetak_renov_datepicker.SelectedDate.ToString();
            string kraj_renoviranja = kraj_renov_datepicker.SelectedDate.ToString();
            string tip_renoviranja = combo_box_prostorije_renoviranje.SelectionBoxItem.ToString();

            datagrid_prostorije.DataContext = prostorijaController.ZakaziRenoviranje(id,pocetak_renoviranja,kraj_renoviranja,tip_renoviranja);
                
        }

        private void nazad_button_click(object sender, RoutedEventArgs e)
        {
            
            Uri uri = new Uri("Stranice/UpravnikPocetna.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

        }
    }
}
