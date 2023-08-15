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

namespace FootballList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches= new List<Match>();
            matches.Add(new Match() { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 });
            matches.Add(new Match() { Team1 = "Barcelona", Team2 = "Arsenal", Score1 = 2, Score2 = 1, Completion = 68 });
            matches.Add(new Match() { Team1 = "Milan", Team2 = "Ajax", Score1 = 0, Score2 = 0, Completion = 5 });
            matches.Add(new Match() { Team1 = "Liverpool", Team2 = "Juventus", Score1 = 1, Score2 = 1, Completion = 43 });            

            IbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IbMatches.SelectedItem != null)
            {
                MessageBox.Show($"Selected Match: " +
                    $"{(IbMatches.SelectedItem as Match).Team1}  {(IbMatches.SelectedItem as Match).Score1} : " +
                    $"{(IbMatches.SelectedItem as Match).Score2} {(IbMatches.SelectedItem as Match).Team2}");
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }

        public string Team1 { get; set; }

        public int Score2 { get; set; }

        public string Team2 { get; set; }

        public int Completion { get; set; }
    }
}
