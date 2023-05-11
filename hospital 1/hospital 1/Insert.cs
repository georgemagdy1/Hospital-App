using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_1
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void displayFNtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(Info.filename,
FileMode.Open, FileAccess.Write)); // We Should include using System.IO;
            int length = (int)bw.BaseStream.Length;
            if (length != 0) //If the file is not empty hymshy 32 byte (record 
                             // size) w b3d keda yktb
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);

            }



            NametextBox.Text = NametextBox.Text.PadRight(9); // Name 
            bw.Write(NametextBox.Text.Substring(0, 9));
            TeltextBox.Text = TeltextBox.Text.PadRight(11); //Tel 
            bw.Write(TeltextBox.Text.Substring(0, 11));
            bw.Write(int.Parse(YeartextBox.Text)); //Year 
            bw.Write(GendertextBox.Text.Substring(0, 1)); // Gender

            length += Info.rec_size;

            YeartextBox.Clear(); GendertextBox.Clear();
            NumOfRecLabel.Text = (length / Info.rec_size).ToString(); // update number of records label
            FileSizeLabel.Text = length.ToString();//update file length label
            MessageBox.Show(" Data is Saved Successfully ");
            bw.Close();




        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new create_file().Show();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;
        }
    }
    }
    
