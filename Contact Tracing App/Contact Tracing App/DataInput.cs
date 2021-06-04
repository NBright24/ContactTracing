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
        //Variables
        string FirstName;
        string LastName;
        //UNSURE
        string DateVisit;
        //UNSURE
        string TimeVisit;
        string symps;
        string ContactNo;
        string emailadd;
        string address1;
        string address2;
        string StoreBranch;
        byte InformationCount = 0;

        public void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void PickDate_ValueChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void PickTime_ValueChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void NumberBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void EmailBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void AddressLineBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void CityProvinceBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void BranchVisitBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        private void SymptomList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            InformationCount++;
        }

        public void SubmitBTN_Click(object sender, EventArgs e)
        {
            if(InformationCount == 10)
            {
                FirstName = FirstNameBox.Text;
                LastName = LastNameBox.Text;

                //symps = SymptomList.CheckedItems.ToString;

                DateVisit = PickDate.Text;
                TimeVisit = PickTime.Text;

                ContactNo = NumberBox.Text;
                emailadd = EmailBox.Text;

                address1 = AddressLineBox.Text;
                address2 = CityProvinceBox.Text;
                StoreBranch = BranchVisitBox.Text;

                StreamWriter DataAdd;
                DataAdd = File.AppendText("OutputSample.txt");
                DataAdd.WriteLine("\n==========CONFIDENTIAL DATA! FOR AUTHORIZED YourCompany PERSONNEL USE ONLY!==========");
                DataAdd.Write(FirstName);
                DataAdd.WriteLine(LastName);
                DataAdd.WriteLine(DateVisit);
                DataAdd.WriteLine(TimeVisit);
                DataAdd.WriteLine(ContactNo);
                DataAdd.WriteLine(emailadd);
                DataAdd.WriteLine(address1);
                DataAdd.WriteLine(address2);
                DataAdd.WriteLine(StoreBranch);
                DataAdd.Close();

                MessageBox.Show("Form submitted.\nPlease follow the health protocol implemented within the store." +
               "\nThank you for your cooperation and have a good day!");

                FirstNameBox.Text = "";
                LastNameBox.Text = "";
                //PickDate.Value;
            }
            else
            {
                MessageBox.Show("You supplied an insufficient amount of information.\nPlease double check and try again." +
                    "\nShould there be any concerns, please ask a YourCompany Staff near you.");
            }

           
        }

        private void HelpBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "FOR QUESTIONS AND CONCERNS, PLEASE APPROACH A YourCompany STAFF OR REACH US THROUGH THE FOLLOWING\n\n1800 5485 SAFE\nYourCompany@CustomerCareSafe.com" +
                "\n\nClick Help for the Privacy Policy.",
                "Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                0,
                "https://bit.ly/3x0CGWV",
                "Privacy Policy");
        }
    }
}
