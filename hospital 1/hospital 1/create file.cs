using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using File = System.IO.File;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;

namespace hospital_1
{
    public partial class create_file : Form
    {
        public create_file()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Info.filename = "D:\\" + FilenametextBox.Text + ".txt"; // Get the file 
                                                                    // name from user if I insert file1 in FilenameTextBox ,filename = E:\\file1.txt
            if (!File.Exists(Info.filename)) // if the file does not exists 
            {
                File.Create(Info.filename).Close();// We Should include using 
                                                   // System.IO;
                MessageBox.Show("File is Created Successfully", "Note",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                errorLabel.Visible = true; // Lable2 : visible = false 
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Info.filename = "D:\\" + FilenametextBox.Text + ".txt";
            File.Delete(Info.filename);
            MessageBox.Show("File is Deleted ");
            FilenametextBox.Clear();
            errorLabel.Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBtn.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBtn.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewExistingStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Display().Show();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Insert().Show();
        }
    }
}
