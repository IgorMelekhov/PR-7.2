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
using System.Windows.Shapes;

namespace PR_7._2
{
    /// <summary>
    /// Логика взаимодействия для Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        public double rad { get; set; }
        public double corner { get; set; }
        public int act { get; set; }
        public int act2 { get; set; }
        public int act3 { get; set; }
        public Calc()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (act == 1)
            {
                Square.Text = Calcul.SquareFunc(rad).ToString();
            }
            if (act2 == 1)
            {
                Lenght.Text = Calcul.LenghtFunc(rad).ToString();
            }
            if (act3 == 1)
            {
                Sector.Text = Calcul.SectorAreaFunc(rad, corner).ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
