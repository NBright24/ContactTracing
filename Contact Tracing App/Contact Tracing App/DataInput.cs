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
        string Age;
        string Gender;
        string DateVisit;
        string TimeVisit;
        string ContactNo;
        string emailadd;
        string address1;
        string address2;
        string StoreBranch;
        byte InformationCount = 1;

        public void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        public void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        private void GenderBox_TextChanged(object sender, EventArgs e)
        {
            InformationCount++;
        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
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
            if ((InformationCount >= 12) || (GenderBox.Text.Contains("m")) || (GenderBox.Text.Contains("f")) )
            {
                FirstName = FirstNameBox.Text;
                LastName = LastNameBox.Text;
                Age = AgeBox.Text;
                Gender = GenderBox.Text;

                string conditon = "";

                if (SymptomList.CheckedItems.Count != 0)
                {
                    for (byte x = 0; x < SymptomList.CheckedItems.Count; x++)
                    {
                        conditon = conditon + "Customer Condition" + (x + 1).ToString() + " : " + SymptomList.CheckedItems[x].ToString() + "\n";
                    }
                }

               
                DateVisit = PickDate.Text;
                TimeVisit = PickTime.Text;

                ContactNo = NumberBox.Text;
                emailadd = EmailBox.Text;

                address1 = AddressLineBox.Text;
                address2 = CityProvinceBox.Text;
                StoreBranch = BranchVisitBox.Text;

                //FILE Name
                string filedate;
                filedate = DateTime.Now.ToLongDateString();

                //FILE WRITE
                StreamWriter DataAdd;
                DataAdd = File.AppendText(filedate + ".txt");
                DataAdd.WriteLine("==========CONFIDENTIAL DATA! FOR AUTHORIZED YourCompany PERSONNEL USE ONLY!==========");
                DataAdd.WriteLine("\nCustomer Name:\n" + FirstName);
                DataAdd.WriteLine(LastName);
                DataAdd.WriteLine("\nAge & Sex:\n" + Age + " " + Gender);
                DataAdd.WriteLine("\nFOR SYMPTOMS\n" + conditon);
                DataAdd.WriteLine("Date:\n" + DateVisit);
                DataAdd.WriteLine("Time:\n" + TimeVisit);
                DataAdd.WriteLine("\nContact Details:\n" + ContactNo);
                DataAdd.WriteLine(emailadd);
                DataAdd.WriteLine("\nAddress:\n" + address1);
                DataAdd.WriteLine(address2);
                DataAdd.WriteLine("\nBRANCH:\n" + StoreBranch);
                DataAdd.WriteLine("");
                DataAdd.Close();

                MessageBox.Show("Please follow the health protocol implemented by the store." +
               "\nThank you for your cooperation and have a good day!","Form Submitted", MessageBoxButtons.OK , MessageBoxIcon.Information);

                //VALUE RESET
                FirstNameBox.Text = "";
                LastNameBox.Text = "";
                AgeBox.Text = "";
                GenderBox.Text = "";
                this.PickDate.Value = new System.DateTime(2021, 6, 1, 22, 56, 58, 0);
                this.PickTime.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
                SymptomList.Items.Clear();

                //THE LIST IS REDONE
                this.SymptomList.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.SymptomList.FormattingEnabled = true;
                this.SymptomList.Items.AddRange(new object[] {
            "None, I\'m good",
            "Fever",
            "Dry Cough",
            "Tiredness",
            "Aches and Pains",
            "Sore Throat",
            "Diarrhoea",
            "Conjuctivities",
            "Headache",
            "Loss of smell or taste",
            "Skin rash",
            "Difficulty in Breathing",
            "Chest Pain",
            "Loss of Speech"});
                this.SymptomList.Location = new System.Drawing.Point(418, 209);
                this.SymptomList.Name = "SymptomList";
                this.SymptomList.Size = new System.Drawing.Size(285, 67);
                this.SymptomList.TabIndex = 24;
                this.SymptomList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SymptomList_ItemCheck);

                NumberBox.Text = "";
                EmailBox.Text = "";
                AddressLineBox.Text = "";
                CityProvinceBox.Text = "";
                BranchVisitBox.Text = "";

                InformationCount = 1;
            }
            else
            {
                MessageBox.Show("You supplied either an insufficient amount of information or incorrect information.\nPlease double check then try again." +
                    "\nApproach our staff for any concerns.","INSUFFICIENT INFORMATION",MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

        private void ReaderButton_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("YOU ARE ABOUT TO ACCESS A CONFIDENTIAL FEATURE" +
                "\nPLEASE CONFIRM THAT YOU'RE AN AUTHORIZED PERSONNEL" +
                "\nUNAUTHORIZED ACTIONS ARE PUNISHABLE BY LAW", "WARNING", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var ReaderForm = new DataReader();
                ReaderForm.Show();

                this.Visible = false;
            }
        }
    }
}
