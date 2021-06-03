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

namespace Contact_Tracing_App
{
    public partial class ContactForm1 : Form
    {
        public ContactForm1()
        {
            InitializeComponent();
        }

        public void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            string FirstName;
            FirstName = FirstNameBox.Text;
        }

        public void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            string LastName;
            LastName = LastNameBox.Text;
        }

        public void PickDate_ValueChanged(object sender, EventArgs e)
        {
            //UNSURE
            string DateVisit;
            DateVisit = PickDate.Text;
        }

        public void PickTime_ValueChanged(object sender, EventArgs e)
        {
            //UNSURE
            string TimeVisit;
            TimeVisit = PickTime.Text;
        }

        public void NumberBox_TextChanged(object sender, EventArgs e)
        {
            string ContactNo;
            ContactNo = NumberBox.Text;
        }

        public void EmailBox_TextChanged(object sender, EventArgs e)
        {
            string emailadd;
            emailadd = EmailBox.Text;
        }

        public void AddressLineBox_TextChanged(object sender, EventArgs e)
        {
            string address1;
            address1 = AddressLineBox.Text;
        }

        public void CityProvinceBox_TextChanged(object sender, EventArgs e)
        {
            string address2;
            address2 = CityProvinceBox.Text;
        }

        public void BranchVisitBox_TextChanged(object sender, EventArgs e)
        {
            string StoreBranch;
            StoreBranch = BranchVisitBox.Text;
        }

        public void SubmitBTN_Click(object sender, EventArgs e)
        {
            string FirstName;
            FirstName = FirstNameBox.Text;

            string LastName;
            LastName = LastNameBox.Text;

            //string symps;
            //symps = SymptomList.CheckedItems.ToString;

            StreamWriter DataAdd;
            DataAdd = File.AppendText("OutputSample.txt");
            DataAdd.WriteLine("=======================================");
            DataAdd.WriteLine(FirstName);
            DataAdd.Write(LastName);

        }

        private void SymptomList_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
