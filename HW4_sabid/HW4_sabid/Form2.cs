using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW4_sabid
{
    public partial class Form2 : Form
    {
        public Form2(string mobile, string firstName, string lastName, string sex,
                     string status, string birthdate, string location, Image profileImage)
        {
            InitializeComponent();

            lblMobileValue.Text = mobile;
            lblFirstNameValue.Text = firstName;
            lblLastNameValue.Text = lastName;
            lblSexValue.Text = sex;
            lblStatusValue.Text = status;
            lblBirthdateValue.Text = birthdate;
            lblLocationValue.Text = location;
            picProfile2.Image = profileImage;
        }
    }
}
