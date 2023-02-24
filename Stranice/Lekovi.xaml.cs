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
    /// Interaction logic for Lekovi.xaml
    /// </summary>
    public partial class Lekovi : Page
    {
        public LekController lekController;

        public Lekovi()
        {

            InitializeComponent();
            lekController = new LekController();
            datagrid_lekovi.DataContext = lekController.IzlistajLekove();
        }

        private void pretrazi_lek_button_click(object sender, RoutedEventArgs e)
        {
            string naziv_unetog_leka = uneti_lek_textbox.Text;
           
            lekController = new LekController();
            datagrid_lekovi.DataContext = lekController.PronadjiLek(naziv_unetog_leka);
           // MessageBox.Show(naziv_unetog_leka);
        }

        private void vidi_sve_lekove_button_click(object sender, RoutedEventArgs e)
        {
            
            lekController = new LekController();
            datagrid_lekovi.DataContext = lekController.IzlistajLekove();
        }

        private void nazad_button_click(object sender, RoutedEventArgs e)
        {
            

            Uri uri = new Uri("Stranice/LekarPocetna.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);

        }
    }
}
