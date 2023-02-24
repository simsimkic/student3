using Controller;
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

namespace WPFprojekatSIMS.Stranice
{
    /// <summary>
    /// Interaction logic for ZakazivanjePregledaSekretar.xaml
    /// </summary>
    public partial class ZakazivanjePregledaSekretar : Page
    {
        PregledController pregledController;
        public ZakazivanjePregledaSekretar()
        {
            InitializeComponent();
            pregledController = new PregledController();
            data_grid_zakazivanje_pregleda_pacijentu_od_sekretara.DataContext = pregledController.IzlistajPreglede();
        }

        private void zakazi_pregled_button_click(object sender, RoutedEventArgs e)
        {
            pregledController = new PregledController();

            string ime_pacijenta = ime_pacijenta_textbox.Text;
            string prezime_pacijenta = prezime_pacijenta_textbox.Text;
            string datum_pregleda = datum_pregleda_datepicker.SelectedDate.ToString();
            string vreme_pregleda = vreme_pregleda_combobox.SelectionBoxItem.ToString();

            string[] parts = datum_pregleda.Split(new char[] { ' ' });
            datum_pregleda = parts[0];  ////isekli smo deo u datumu pregleda gde se navodi vreme

            if (!(ime_pacijenta.Equals("") & prezime_pacijenta.Equals("") & datum_pregleda_datepicker.DisplayDate == null & vreme_pregleda_combobox.SelectedIndex == -1)) {
                prazna_polja_label.Visibility = Visibility.Hidden;
                data_grid_zakazivanje_pregleda_pacijentu_od_sekretara.DataContext = pregledController.ZakaziPregled(ime_pacijenta, prezime_pacijenta, datum_pregleda, vreme_pregleda);
            }   
            else
            {
                prazna_polja_label.Visibility = Visibility.Visible;
            }
         }

        private void nazad_button_click(object sender, RoutedEventArgs e)
        {
            

            Uri uri = new Uri("Stranice/SekretarPocetna.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

        }
    }
}
