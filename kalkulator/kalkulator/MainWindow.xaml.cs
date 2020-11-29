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

namespace kalkulator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button number)
            {
                switch (number.Content)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "+":
                    case "4":
                    case "5":
                    case "6":
                    case "-":
                    case "7":
                    case "8":
                    case "9":
                    case "/":
                    case ".":
                    case "0":
                    case "#":
                    case "*":

                        Display.Text += number.Content;
                        break;
                    default:
                        break;
                }

            }
        }
        private void ButtonEq_Click(object sender, RoutedEventArgs e)
        {
            double svare = 0;
            string [] numbreros;
            numbreros = Display.Text.Split('+','-','/','*');
            double numberouno = Convert.ToDouble(numbreros[0]);
            double numberodoseso = Convert.ToDouble(numbreros[1]);

            if (Display.Text.Contains('+'))
            {
                svare = numberouno + numberodoseso;
            }
            if (Display.Text.Contains('-'))
            {
                svare = numberouno - numberodoseso;
            }
            if (Display.Text.Contains('*'))
            {
                svare = numberouno * numberodoseso;
            }
            if (Display.Text.Contains('/'))
            {
                svare = numberouno / numberodoseso;
            }

            Display.Text += " " + "=" + " " + svare;
        }

        private void ButtonCler_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = string.Empty;        
        }

     }
}

