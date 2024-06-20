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

namespace PR_7._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double rad { get; set; }
        public double corner { get; set; }
        public int act {  get; set; }
        public int act2 { get; set; }
        public int act3 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            Input input = new Input();
            input.Show();
            Close();
        }

        private void Calc_Click_1(object sender, RoutedEventArgs e)
        {
            Calc calc = new Calc();
            calc.rad = rad;
            calc.corner = corner;   
            calc.act = act;
            calc.act2 = act2;
            calc.act3 = act3;
            calc.Show();
        }

        private void Exit_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Radius2.Text = rad.ToString();
            Corner2.Text = corner.ToString();

        }

        
    }
}
