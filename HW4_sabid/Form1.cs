using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW4_sabid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Select a Profile Picture";
                openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    picProfile.Image = Image.FromFile(openFile.FileName);
                    picProfile.SizeMode = PictureBoxSizeMode.StretchImage; 
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sex = rdoMale.Checked ? "Male" : (rdoFemale.Checked ? "Female" : "");

            Form2 f2 = new Form2(
                mtxtMobile.Text,
                txtFirstName.Text,
                txtLastName.Text,
                sex,
                txtStatus.Text,
                dtpBirthdate.Value.ToShortDateString(),
                txtLocation.Text,
                picProfile.Image
            );

            f2.Show();
            this.Hide();
        }


    }
}
