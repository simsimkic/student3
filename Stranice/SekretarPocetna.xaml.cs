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

namespace WPFprojekatSIMS
{
    /// <summary>
    /// Interaction logic for SekretarPocetna.xaml
    /// </summary>
    public partial class SekretarPocetna : Page
    {
        public SekretarPocetna()
        {
            InitializeComponent();
        }

        private void zakazivanje_pregleda_click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Stranice/ZakazivanjePregledaSekretar.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Stranice/login.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
