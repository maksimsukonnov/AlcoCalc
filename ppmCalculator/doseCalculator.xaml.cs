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
    /// Логика взаимодействия для doseCalculator.xaml
    /// </summary>
    public partial class doseCalculator : Window
    {
        public double dose = 0;

        //количество единиц алкоголя = количество(литры) х крепость(%) х 0,789
        //Для расчета количества единиц алкоголя в конкретном напитке нужно умножить объем напитка в литрах на его
        //крепость, а затем умножить полученный результат на удельный вес алкоголя, т.е.на 0,789
        //(соотношение между плотностью алкоголя и плотностью воды).
        
        public doseCalculator()
        {
            InitializeComponent();
        }

        private void beer28_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.33 * 2.8 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void beer47033_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.33 * 4.7 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void beer4705_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.5 * 4.7 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void beer54033_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.33 * 5.4 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void beer5405_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.5 * 5.4 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void sidr47033_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.33 * 4.7 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void sidr4705_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.5 * 4.7 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void strongsidr58033_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.33 * 5 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void strongsidr5805_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.5 * 5 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void coctail55033_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.33 * 5.5 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void coctail5505_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.5 * 5.5 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void whitewine101512_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.12 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void whitewine101516_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.16 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void whitewine101524_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.24 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void whitewine1015075_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.75 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void redwine101512_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.12 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void redwine101516_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.16 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void redwine101524_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.24 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void redwine1015075_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.75 * 10 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void champagne11510_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.1 * 11.5 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void fortifiedwine16228_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.08 * 16 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void liquor164_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.04 * 16 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void cognac404_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.04 * 40 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void rum404_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.04 * 40 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void whiskey404_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.04 * 40 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void strongspirt404_Click(object sender, RoutedEventArgs e)
        {
            dose += 0.04 * 40 * 0.789;
            var str = string.Format("{0:0.#}", dose);
            doseRes.Content = str;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartMenu obj = new StartMenu();
            obj.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dose = 0;
            doseRes.Content = dose;
        }
    }
}
