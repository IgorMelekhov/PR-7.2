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
    /// Логика взаимодействия для Input.xaml
    /// </summary>
    public partial class Input : Window
    {
       
        public static double rad;
        public static double corner;
        public static double Squ;
        public static double len;
        public static double sec;
        public static int act;
        public static int act2;
        public static int act3;
        MainWindow mainWindow = new MainWindow();
        public static void Message(string msg) 
        {
            MessageBoxButton buttons = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(msg, "Warning", buttons, icon);
        }
        public Input()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rad = Convert.ToDouble(Radius.Text);
                corner = Convert.ToDouble(Сorner.Text);
                if (rad <= 0)
                { 
                    Message("The radius cannot be less than or equal to zero");
                }
                else if (corner < 0)
                {

                    Message("The corner cannot be less than zero");
                }
                else if (String.IsNullOrEmpty(Radius.Text))
                {
                    Message("The radius string cannot be empty");
                }
                else if (String.IsNullOrEmpty(Сorner.Text))
                {

                    Message("The corner string cannot be empty,if you do not need to count the area of the circle sector, then put zero in the field");
                }
                else if (corner>360)
                {
                    Message("The corner cannot be more than 360 degrees");
                }
                else 
                {
                    mainWindow.rad = rad;
                    mainWindow.corner = corner;
                    
                    
                    
                    mainWindow.Show();
                    Close();
                }               
            }
            catch 
            {
                MessageBoxButton buttons = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show("The string had an incorrect format", "Warning", buttons, icon);
            }
        }

        private void Square_Checked(object sender, RoutedEventArgs e)
        {
            act = 1;
            mainWindow.act = act;
        }

        private void Lenght_Checked(object sender, RoutedEventArgs e)
        {
            act2 = 1;
            mainWindow.act2 = act2;
        }

        private void SectorArea_Checked(object sender, RoutedEventArgs e)
        {
            act3 = 1;
            mainWindow.act3 = act3;
        }
        private void Square_Unchecked(object sender, RoutedEventArgs e)
        {
            act = 0;
            mainWindow.act = act;
        }

        private void Lenght_Unchecked(object sender, RoutedEventArgs e)
        {
            act2 = 0;
            mainWindow.act2 = act2;
        }

        private void SectorArea_Unchecked(object sender, RoutedEventArgs e)
        {
            act3 = 0;
            mainWindow.act3 = act3;
        }
    }
}
