using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class ContactForm1 : Form
    {
        public ContactForm1()
        {
            InitializeComponent();
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            string FirstName;
            FirstName = FirstNameBox.Text;
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void SymptomList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrivcyPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AttentionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
