using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm()
        {
            InitializeComponent();
        }
        string firstName;
        string lastName;
        string fullName;
        string fathersName;
        string mothersName;
        string address;
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                fullName = firstName + " " + lastName;
                fathersName = fathersNameTextBox.Text;
                mothersName = mothersNameTextBox.Text;
                address = addressTextBox.Text;

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                fathersNameTextBox.Text = "";
                mothersNameTextBox.Text = "";
                addressTextBox.Text = "";
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tShow Your All Information" + Environment.NewLine + Environment.NewLine + "Full Name : " + fullName + Environment.NewLine + "Father's Name : " + fathersName + Environment.NewLine + "Mother's Name : " + mothersName + Environment.NewLine + "Address : " + address);
        }

        private void FathersNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tShow Your Father's Name" + Environment.NewLine + Environment.NewLine + "Father's Name : " + fathersName);
        }

        private void MothersNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tShow Your Mother's Name" + Environment.NewLine + Environment.NewLine + "Mother's Name : " + mothersName);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tShow Your Address" + Environment.NewLine + Environment.NewLine + "Your Current Address : " + address);
        }
    }
}
