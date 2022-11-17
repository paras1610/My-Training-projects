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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for StandardCalculator.xaml
    /// </summary>
    public partial class StandardCalculator : Window
    {

        int  number1=0;
        int  number2 = 0;
        string operation="";
        public StandardCalculator()
        {
            InitializeComponent();
        }

        private void Button_0(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                textbox.Text=number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                textbox.Text = number2.ToString();
            }


        }

        

        private void Button_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_3(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                textbox.Text = number2.ToString();
            }
        }

        private void Button_7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_9(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                textbox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                textbox.Text = number2.ToString();
            }

        }

        private void Button_plus(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textbox.Text = "";
        }

        private void Button_minus(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textbox.Text = "";
        }

        private void Button_multiply(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textbox.Text = "";
        }

        private void Button_divide(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textbox.Text = "";
        }

        private void Button_equals(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                textbox.Text = (number1 + number2).ToString();
            }

            if (operation == "-")
            {
                textbox.Text = (number1 - number2).ToString();
            }
            if (operation == "/")
            {
                textbox.Text = (number1 / number2).ToString();
            }
            if (operation == "*")
            {
                textbox.Text = (number1 * number2).ToString();
            }

        }

        private void Button_dot(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textbox.Text = "";
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            textbox.Text = "";
        }
    }
}
