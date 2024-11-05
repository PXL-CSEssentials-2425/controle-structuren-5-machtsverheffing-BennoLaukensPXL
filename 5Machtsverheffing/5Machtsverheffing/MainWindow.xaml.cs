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

namespace _5Machtsverheffing
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
        StringBuilder sb = new StringBuilder();
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            double.TryParse(numberTextBox.Text, out double number);
            double power;
            if (number > 84 || number < -84)
            {
                resultTextBox.Text = $"Geef een getal tussen -84 en 84";
            }
            else
            {
                for (double loop = 1; loop <= 10; loop++)
                {
                    power = Math.Pow(number, loop);



                    sb.AppendLine($"Macht {loop} van {number} is {power}");
                }
                resultTextBox.Text = sb.ToString();
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Text = "1";
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
