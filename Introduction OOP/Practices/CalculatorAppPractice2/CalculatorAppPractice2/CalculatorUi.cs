using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        public CalculatorUi()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Addition().ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Subtracton().ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Multiply().ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.firstNumber = Convert.ToDecimal(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToDecimal(secondNumberTextBox.Text);

            resultTextBox.Text = calculator.Divide().ToString();
        }
    }
}
