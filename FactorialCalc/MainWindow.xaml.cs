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

namespace FactorialCalc
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

        public void xCalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            Factorial();

        }

        public void Factorial()
        {
            double number = 0;
            int factorial = 1;
            Double.TryParse(xNumber.Text, out number);

            // Forumala to determine Factorial
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }

            // Display Answer
            xResponeBlock.Text = ($"{number}! =");
            xResponeBlock.FontSize = 32;
            xAnswerBlock.Text = factorial.ToString();
        }


        public void Permutations()
        {

        }
        

        private void xExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
