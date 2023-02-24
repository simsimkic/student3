using Controller;
using Model;
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
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Page
    {
        PacijentController pacijentController;
        public Registracija()
        {
            InitializeComponent();
            
        }


        


        private void registracija_button_click(object sender, RoutedEventArgs e)
        {

            pacijentController = new PacijentController();
            Uri uri = new Uri("Stranice/login.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
           // string lozinka = textBox7.Password;
            pacijentController.RegistrujPacijenta(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox6.Text);
            
            
            

        }

        private void otkazi_button_click(object sender, RoutedEventArgs e)
        {
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Password = String.Empty;
            textBox8.Password = String.Empty;
        }

        private void hyperlink_click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Stranice/login.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
