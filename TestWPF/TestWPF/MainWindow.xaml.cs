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

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;

            Button button = new Button();            
            button.FontSize= 16;
            button.Height= 50;
            button.Width= 200;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            TextBlock txt2 = new TextBlock();
            TextBlock txt3 = new TextBlock();

            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;
            wrapPanel.Children.Add(txt);

            txt2.Text = "Color";
            txt2.Foreground = Brushes.Green;
            wrapPanel.Children.Add(txt2);

            txt3.Text = "Button";
            txt3.Foreground = Brushes.Red;
            wrapPanel.Children.Add(txt3);

            button.Content = wrapPanel;
            grid.Children.Add(button);
        }
    }
}
