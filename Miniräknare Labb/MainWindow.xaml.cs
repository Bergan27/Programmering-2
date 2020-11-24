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

namespace Miniräknare_Labb
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
        private void OkButton_Klick(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                OkText.Text += button.Content;
            }
        }
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (OkText.Text.Contains("+"))
            {
                OkText.Text = Addition();
            }

            else if (OkText.Text.Contains("-"))
            {
                OkText.Text = Substraction();
            }
            else if (OkText.Text.Contains("/"))
            {
                OkText.Text = Division();
            }
            else if (OkText.Text.Contains("*"))
            {
                OkText.Text = Times();
            }
        }
        private string Substraction()
        {
            var numbers = OkText.Text.Split("-");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 - number2;
            return sum + "";
        }

        private string Addition()
        {
            var numbers = OkText.Text.Split("+");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 + number2;
            return sum + "";
        }
        private string Division()
        {
            var numbers = OkText.Text.Split("/");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 / number2;
            return sum + "";
        }
        private string Times()
        {
            var numbers = OkText.Text.Split("*");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 * number2;
            return sum + "";
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
             OkText.Text = "" ;
        }
        

    }
}
