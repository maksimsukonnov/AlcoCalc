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

namespace ppmCalculator
{
    /// <summary>
    /// Логика взаимодействия для calorieCalculator.xaml
    /// </summary>
    public partial class calorieCalculator : Window
    {
        public int calorie = 0;
        public calorieCalculator()
        {
            InitializeComponent();
        }

        private void beer28_Click(object sender, RoutedEventArgs e)
        {
            calorie += 99;
            calorieRes.Content = calorie;
        }

        private void beer47033_Click(object sender, RoutedEventArgs e)
        {
            calorie += 132;
            calorieRes.Content = calorie;
        }

        private void beer4705_Click(object sender, RoutedEventArgs e)
        {
            calorie += 200;
            calorieRes.Content = calorie;
        }

        private void beer54033_Click(object sender, RoutedEventArgs e)
        {
            calorie += 149;
            calorieRes.Content = calorie;
        }

        private void beer5405_Click(object sender, RoutedEventArgs e)
        {
            calorie += 225;
            calorieRes.Content = calorie;
        }

        private void sidr47033_Click(object sender, RoutedEventArgs e)
        {
            calorie += 132;
            calorieRes.Content = calorie;
        }

        private void sidr4705_Click(object sender, RoutedEventArgs e)
        {
            calorie += 200;
            calorieRes.Content = calorie;
        }

        private void strongsidr58033_Click(object sender, RoutedEventArgs e)
        {
            calorie += 180;
            calorieRes.Content = calorie;
        }

        private void strongsidr5805_Click(object sender, RoutedEventArgs e)
        {
            calorie += 300;
            calorieRes.Content = calorie;
        }

        private void coctail55033_Click(object sender, RoutedEventArgs e)
        {
            calorie += 182;
            calorieRes.Content = calorie;
        }

        private void coctail5505_Click(object sender, RoutedEventArgs e)
        {
            calorie += 276;
            calorieRes.Content = calorie;
        }

        private void whitewine101512_Click(object sender, RoutedEventArgs e)
        {
            calorie += 90;
            calorieRes.Content = calorie;
        }

        private void whitewine101516_Click(object sender, RoutedEventArgs e)
        {
            calorie += 120;
            calorieRes.Content = calorie;
        }

        private void whitewine101524_Click(object sender, RoutedEventArgs e)
        {
            calorie += 180;
            calorieRes.Content = calorie;
        }

        private void whitewine1015075_Click(object sender, RoutedEventArgs e)
        {
            calorie += 450;
            calorieRes.Content = calorie;
        }

        private void redwine101512_Click(object sender, RoutedEventArgs e)
        {
            calorie += 84;
            calorieRes.Content = calorie;
        }

        private void redwine101516_Click(object sender, RoutedEventArgs e)
        {
            calorie += 112;
            calorieRes.Content = calorie;
        }

        private void redwine101524_Click(object sender, RoutedEventArgs e)
        {
            calorie += 168;
            calorieRes.Content = calorie;
        }

        private void redwine1015075_Click(object sender, RoutedEventArgs e)
        {
            calorie += 420;
            calorieRes.Content = calorie;
        }

        private void champagne11510_Click(object sender, RoutedEventArgs e)
        {
            calorie += 90;
            calorieRes.Content = calorie;
        }

        private void fortifiedwine16228_Click(object sender, RoutedEventArgs e)
        {
            calorie += 120;
            calorieRes.Content = calorie;
        }

        private void liquor164_Click(object sender, RoutedEventArgs e)
        {
            calorie += 112;
            calorieRes.Content = calorie;
        }

        private void cognac404_Click(object sender, RoutedEventArgs e)
        {
            calorie += 112;
            calorieRes.Content = calorie;
        }

        private void rum404_Click(object sender, RoutedEventArgs e)
        {
            calorie += 112;
            calorieRes.Content = calorie;
        }

        private void strongspirt404_Click(object sender, RoutedEventArgs e)
        {
            calorie += 88;
            calorieRes.Content = calorie;
        }

        private void whiskey404_Click(object sender, RoutedEventArgs e)
        {
            calorie += 92;
            calorieRes.Content = calorie;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartMenu obj = new StartMenu();
            obj.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            calorie = 0;
            calorieRes.Content = calorie;
        }
    }
}
