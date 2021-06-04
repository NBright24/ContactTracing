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
using System.Runtime.InteropServices;


namespace Contact_Tracing_App
{
    public partial class DataReader : Form
    {
        public DataReader()
        {
            InitializeComponent();
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var DataInput = new ContactForm1();
            DataInput.Visible = true;
            this.Close();
        }

        private void PickDateFile_ValueChanged(object sender, EventArgs e)
        {

        }

        public void SubmitBTN_Click(object sender, EventArgs e)
        {
            string filedateread;
            filedateread = PickDateFile.Text;



            try
            {
                // Open the text file using a stream reader.
                using (var DataRead = new StreamReader(filedateread + ".txt"))
                {
                    DisplayBox.Text =  DataRead.ReadToEnd();
                }
            }
            catch (IOException X)
            {
                MessageBox.Show("The file could not be read or may not exist.\n\n"+ X.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void DataReader_Load(object sender, EventArgs e)
        {
          
        }

        
    }
}
