using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationAppWalkthrough2
{
    public partial class PersonInformationUi : Form
    {
        public PersonInformationUi()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                person.firstName = firstNameTextBox.Text;
                person.middleName = middleNameTextBox.Text;
                person.lastName = lastNameTextBox.Text;

                fullNameTextBox.Text = person.GetFullName();
                reverseNameTextBox.Text = person.GetReverseName();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
