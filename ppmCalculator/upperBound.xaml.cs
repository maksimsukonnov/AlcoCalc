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
    /// Логика взаимодействия для upperBound.xaml
    /// </summary>
    public partial class upperBound : Window
    {
        public double upDoseMale = 0.0;
        public double upDoseFemale = 0.0;
        public upperBound()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartMenu obj = new StartMenu();
            obj.Show();
            this.Close();
        }


        private void Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            upDoseMale = e.NewValue * 0.06;
            upDoseFemale = e.NewValue * 0.055;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (male.IsChecked == false && female.IsChecked == false)
                MessageBox.Show("Укажите ваш пол");
            if (male.IsChecked == true && female.IsChecked == false)
            {
                var str = string.Format("{0:0.#}", upDoseMale);
                dose.Content = str;
            }
            if (male.IsChecked == false && female.IsChecked == true)
            {
                var str = string.Format("{0:0.#}", upDoseFemale);
                dose.Content = str;
            }
        }
    }
}
