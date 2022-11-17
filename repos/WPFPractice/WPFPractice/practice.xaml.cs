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
    /// Interaction logic for practice.xaml
    /// </summary>
    public partial class practice : Window
    {
        public practice()
        {
            InitializeComponent();
        }

        private void myimp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void green_button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Stylecolor"] = new SolidColorBrush(Colors.Green);
        }
      

        private void red_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Resources["Stylecolor"] = new SolidColorBrush(Colors.Red);
        }
    }
}
