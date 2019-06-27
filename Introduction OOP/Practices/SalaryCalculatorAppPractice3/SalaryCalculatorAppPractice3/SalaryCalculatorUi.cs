using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.employeeName = employeeNameTextBox.Text;
            employee.basicAmount = Convert.ToDecimal(basicAmountTextBox.Text);

            MessageBox.Show(employee.employeeName + " your salary is " + employee.GetTotalSalary(Convert.ToDecimal(homeRentTextBox.Text), Convert.ToDecimal(medicalAllowanceTextBox.Text)));
        }
    }
}
