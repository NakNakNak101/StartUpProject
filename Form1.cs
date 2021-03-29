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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

      

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Main_welcome_form welcome = new Main_welcome_form();
            welcome.ShowDialog(); 
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
