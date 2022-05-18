
using System.Windows;




namespace ppmCalculator
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double weigth = 0;
        public double ppm = 0;
        public MainWindow()
        {
            InitializeComponent();
        }


        //C=A/(m* r), где
        //С – концентрация алкоголя в промилле,
        //A – выпитый чистый алкоголь(можно рассчитать, взяв указанный на этикетке напитка процент),
        //m – вес тела,
        //r – коэффициент, который равняется 0,7 для мужчин и 0,6 для женщин.

      
        private void beer28_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 9.24;
            weigth = Weight.Value;
            if(male.IsChecked==false&&female.IsChecked==false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked==true)
            {
                ppm +=  clearAlc/ (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if(female.IsChecked==true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }        
        }

        private void beer47033_Click(object sender, RoutedEventArgs e)
        {

            double clearAlc = 15.51;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void beer4705_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 23.5;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void beer54033_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 17.82;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void beer5405_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 27;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void sidr47033_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 15.51;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void sidr4705_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 23.5;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void strongsidr58033_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 16.5;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void strongsidr5805_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 25;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void coctail55033_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 18.15;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void coctail5505_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 27.5;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void whitewine101512_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 12;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void whitewine101516_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 16;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void whitewine101524_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 24;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void whitewine1015075_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 75;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void redwine101512_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 12;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void redwine101516_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 16;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void redwine101524_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 24;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void redwine1015075_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 75;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void champagne11510_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 11.5;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void fortifiedwine16228_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 12.8;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void liquor164_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 6.4;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void cognac404_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 16;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void rum404_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 16;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void strongspirt404_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 16;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void whiskey404_Click(object sender, RoutedEventArgs e)
        {
            double clearAlc = 16;
            weigth = Weight.Value;
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true)
            {
                ppm += clearAlc / (0.7 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
            if (female.IsChecked == true)
            {
                ppm += clearAlc / (0.6 * weigth);
                var str = string.Format("{0:0.#}", ppm);
                result.Content = str;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ppm = 0.0;
            result.Content = ppm;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StartMenu obj = new StartMenu();
            obj.Show();
            this.Close();
        }
    }
}
