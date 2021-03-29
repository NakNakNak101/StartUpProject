using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Research_project
{
    public partial class ShowExistingData : Form
    {
        public ShowExistingData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton15_Click(object sender, EventArgs e)
        {
            ShowExistingData showExistingDataUI = new ShowExistingData();
            showExistingDataUI.ShowDialog();
        }

        private void siticoneButton17_Click(object sender, EventArgs e)
        {
            CreateDataUI createData = new CreateDataUI();
            createData.ShowDialog();

        }

        private void ShowExistingData_Load(object sender, EventArgs e)
        {

        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            CreateAdminUI createAdmin = new CreateAdminUI();
            createAdmin.ShowDialog();
        }

        private void siticoneButton18_Click(object sender, EventArgs e)
        {

        }
    }
}
