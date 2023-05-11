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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hospital_1
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            displayFNtextBox.Text = Info.filename;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new create_file().Show();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open(Info.filename,
FileMode.Open, FileAccess.Read));
            int num_of_records = (int)br.BaseStream.Length / Info.rec_size;
            if (num_of_records > 0) // If The file Not Empty
            {
                DisplayBtn.Text = "Next";// Change the Button Text

                br.BaseStream.Seek(Info.count, SeekOrigin.Begin);
               
 NametextBox.Text = br.ReadString(); // Read Name 
                TeltextBox.Text = br.ReadString(); // Read Tel
                YeartextBox.Text = br.ReadInt32().ToString(); // Read Year
                GendertextBox.Text = br.ReadString(); // Read Gender
                NumOfRecLabel.Text = num_of_records.ToString();
                FileSizeLabel.Text = br.BaseStream.Length.ToString();
                if ((Info.count / Info.rec_size) >= (num_of_records - 1))
                    // If I reach the End of file , Go to the Beginning of file
                    Info.count = 0;
                else
                    Info.count += Info.rec_size;
            }
            else MessageBox.Show("Empty File");
            br.Close();
        }
    }
        }

    