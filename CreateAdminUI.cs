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
    public partial class CreateAdminUI : Form
    {
        public CreateAdminUI()
        {
            InitializeComponent();
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            LogInForm formLogin = new LogInForm();
            formLogin.ShowDialog(); 
        }
    }
}
