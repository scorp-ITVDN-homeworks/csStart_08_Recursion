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

namespace Task_03
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

        private void justDoItButton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)getReminder.IsChecked)
            {
                GetReminder();
            }

            if ((bool)numberToPower.IsChecked)
            {
                NumberToPower();
            }

            if ((bool)concatanate.IsChecked)
            {
                result.Text = operandOne.Text + operandTwo.Text;
            }

            if ((bool)doDivision.IsChecked)
            {
                DoDivision();
            }
        }

        private void GetReminder()
        {
            int firstNumber = 0;
            int secondNumber = 0;

            if (!NumbersHandler(ref firstNumber, ref secondNumber)) return;
            if (secondNumber == 0)
            {
                MessageBox.Show("ERROR!!! - Divide by zero");
                return;
            }

            result.Text = (firstNumber % secondNumber).ToString();
        }

        private void NumberToPower()
        {
            int firstNumber = 0;
            int secondNumber = 0;

            if (!NumbersHandler(ref firstNumber, ref secondNumber)) return;

            result.Text = Math.Pow(firstNumber, secondNumber).ToString();
        }

        private void DoDivision()
        {
            int firstNumber = 0;
            int secondNumber = 0;

            if (!NumbersHandler(ref firstNumber, ref secondNumber)) return;

            if(secondNumber == 0)
            {
                MessageBox.Show("ERROR!!! - Divide by zero");
                return;
            }

            result.Text = (firstNumber / secondNumber).ToString();
        }

        private bool NumbersHandler(ref int firstNumber, ref int secondNumber)
        {
            if (!Int32.TryParse(operandOne.Text, out firstNumber))
            {
                MessageBox.Show("ERROR!!! first operand must be an integer number \nmake correct input");
                return false;
            }
            if (!Int32.TryParse(operandTwo.Text, out secondNumber))
            {
                MessageBox.Show("ERROR!!! second operand must be an integer number \nmake correct input");
                return false;
            }

            firstNumber = Convert.ToInt32(operandOne.Text);
            secondNumber = Convert.ToInt32(operandTwo.Text);

            return true;
        }
    }
}
