using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new create_file().Show();
        }

        private void DisplayBtn_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            new create_file().Show();
        }
    }
}

