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

namespace Bug_Adoption
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri page = new Uri("mantis.xaml", UriKind.Relative);
            NavigationService.Navigate(page);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uri page = new Uri("stag beetle.xaml", UriKind.Relative);
            NavigationService.Navigate(page);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Uri page = new Uri("ant.xaml", UriKind.Relative);
            NavigationService.Navigate(page);
        }
    }
}
