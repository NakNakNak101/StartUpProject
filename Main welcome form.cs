using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; 

namespace Research_project
{
    public partial class Main_welcome_form : Form
    {
        public Main_welcome_form()
        {
            InitializeComponent();
        }

        private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            CreateAdminUI createAdmin = new CreateAdminUI();
            createAdmin.ShowDialog(); 
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel8_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            ShowExistingData showExistingDataUI = new ShowExistingData();
            showExistingDataUI.ShowDialog();
                
        }

        private void siticoneCirclePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCreateData_Click(object sender, EventArgs e)
        {
            CreateDataUI createData = new CreateDataUI();
            createData.ShowDialog();
        }

        private void Main_welcome_form_Load(object sender, EventArgs e)
        {

        }

        private void Main_welcome_form_Load_1(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void siticonePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton17_Click(object sender, EventArgs e)
        {
            CreateDataUI createData = new CreateDataUI();
            createData.ShowDialog();
        }

        private void siticoneButton25_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            CreateAdminUI createAdmin = new CreateAdminUI();
            createAdmin.ShowDialog();
        }

        private void ButtonShowData_Click(object sender, EventArgs e)
        {
            ShowExistingData showExistingDataUI = new ShowExistingData();
            showExistingDataUI.ShowDialog();
        }
    }
}
