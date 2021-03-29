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
    public partial class CreateDataUI : Form
    {
        public CreateDataUI()
        {
            InitializeComponent();
        }

        private void ButtonCreateData_Click(object sender, EventArgs e)
        {
            CreateDataUI createData = new CreateDataUI();
            createData.ShowDialog();
        }

        private void ButtonShowData_Click(object sender, EventArgs e)
        {
            ShowExistingData showExistingDataUI = new ShowExistingData();
            showExistingDataUI.ShowDialog();
        }

        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            LogInForm formLogin = new LogInForm();
            formLogin.ShowDialog();
        }

        private void CreateDataUI_Load(object sender, EventArgs e)
        {

        }
    }
}
