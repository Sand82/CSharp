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

namespace PizzaPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllChekedChanged(object sender, RoutedEventArgs e)
        {
            bool newVall = allTopings.IsChecked == true;
            Salami.IsChecked = newVall;
            Mozzarella.IsChecked = newVall;
            Mushrooms.IsChecked = newVall;
        }

        private void SingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            allTopings.IsChecked = null;

            if (Salami.IsChecked == true && Mushrooms.IsChecked == true && Mozzarella.IsChecked == true)
            {
                allTopings.IsChecked = true;
            }

            if (Salami.IsChecked == false && Mushrooms.IsChecked == false && Mozzarella.IsChecked == false)
            {
                allTopings.IsChecked = false;
            }
        }
        
    }
}
