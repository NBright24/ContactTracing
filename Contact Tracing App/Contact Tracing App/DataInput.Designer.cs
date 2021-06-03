﻿
namespace Contact_Tracing_App
{
    partial class ContactForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm1));
            this.Greeting = new System.Windows.Forms.Label();
            this.HelpBTN = new System.Windows.Forms.Button();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LabelName1 = new System.Windows.Forms.Label();
            this.LabelName2 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelAdress1 = new System.Windows.Forms.Label();
            this.LabelAddress2 = new System.Windows.Forms.Label();
            this.LabelBranch = new System.Windows.Forms.Label();
            this.AddressLineBox = new System.Windows.Forms.TextBox();
            this.CityProvinceBox = new System.Windows.Forms.TextBox();
            this.BranchVisitBox = new System.Windows.Forms.TextBox();
            this.PickDate = new System.Windows.Forms.DateTimePicker();
            this.PickTime = new System.Windows.Forms.DateTimePicker();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.AttentionLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Neil = new System.Windows.Forms.PictureBox();
            this.Symptoms = new System.Windows.Forms.Label();
            this.SymptomList = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Neil)).BeginInit();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Greeting.Location = new System.Drawing.Point(128, 25);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(409, 44);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Good day! We would like you to answer this form\r\nfor everyone\'s safety throughout" +
    " these times.";
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpBTN
            // 
            this.HelpBTN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpBTN.Location = new System.Drawing.Point(632, 483);
            this.HelpBTN.Name = "HelpBTN";
            this.HelpBTN.Size = new System.Drawing.Size(54, 31);
            this.HelpBTN.TabIndex = 1;
            this.HelpBTN.Text = "Help";
            this.HelpBTN.UseVisualStyleBackColor = true;
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitBTN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBTN.Location = new System.Drawing.Point(611, 439);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(92, 38);
            this.SubmitBTN.TabIndex = 2;
            this.SubmitBTN.Text = "SUBMIT";
            this.SubmitBTN.UseVisualStyleBackColor = false;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameBox.Location = new System.Drawing.Point(128, 88);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.PlaceholderText = "Juan Nicolas";
            this.FirstNameBox.Size = new System.Drawing.Size(575, 29);
            this.FirstNameBox.TabIndex = 3;
            this.FirstNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // LabelName1
            // 
            this.LabelName1.AutoSize = true;
            this.LabelName1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName1.Location = new System.Drawing.Point(23, 92);
            this.LabelName1.Name = "LabelName1";
            this.LabelName1.Size = new System.Drawing.Size(89, 19);
            this.LabelName1.TabIndex = 4;
            this.LabelName1.Text = "First Name";
            // 
            // LabelName2
            // 
            this.LabelName2.AutoSize = true;
            this.LabelName2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName2.Location = new System.Drawing.Point(25, 126);
            this.LabelName2.Name = "LabelName2";
            this.LabelName2.Size = new System.Drawing.Size(87, 19);
            this.LabelName2.TabIndex = 5;
            this.LabelName2.Text = "Last Name";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameBox.Location = new System.Drawing.Point(128, 122);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.PlaceholderText = "Dela Cruz";
            this.LastNameBox.Size = new System.Drawing.Size(575, 29);
            this.LastNameBox.TabIndex = 6;
            this.LastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTime.Location = new System.Drawing.Point(16, 164);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(96, 19);
            this.LabelTime.TabIndex = 7;
            this.LabelTime.Text = "Time of Visit";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDate.Location = new System.Drawing.Point(334, 164);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(95, 19);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "Date of Visit";
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNumber.Location = new System.Drawing.Point(16, 303);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(92, 19);
            this.LabelNumber.TabIndex = 9;
            this.LabelNumber.Text = "Contact No.";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelEmail.Location = new System.Drawing.Point(302, 303);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(51, 19);
            this.LabelEmail.TabIndex = 10;
            this.LabelEmail.Text = "Email";
            // 
            // LabelAdress1
            // 
            this.LabelAdress1.AutoSize = true;
            this.LabelAdress1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAdress1.Location = new System.Drawing.Point(6, 338);
            this.LabelAdress1.Name = "LabelAdress1";
            this.LabelAdress1.Size = new System.Drawing.Size(113, 19);
            this.LabelAdress1.TabIndex = 11;
            this.LabelAdress1.Text = "Address Line 1";
            // 
            // LabelAddress2
            // 
            this.LabelAddress2.AutoSize = true;
            this.LabelAddress2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelAddress2.Location = new System.Drawing.Point(6, 373);
            this.LabelAddress2.Name = "LabelAddress2";
            this.LabelAddress2.Size = new System.Drawing.Size(116, 19);
            this.LabelAddress2.TabIndex = 12;
            this.LabelAddress2.Text = "Address Line 2";
            this.LabelAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBranch
            // 
            this.LabelBranch.AutoSize = true;
            this.LabelBranch.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelBranch.Location = new System.Drawing.Point(9, 408);
            this.LabelBranch.Name = "LabelBranch";
            this.LabelBranch.Size = new System.Drawing.Size(113, 19);
            this.LabelBranch.TabIndex = 13;
            this.LabelBranch.Text = "Branch Visited";
            this.LabelBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressLineBox
            // 
            this.AddressLineBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLineBox.Location = new System.Drawing.Point(128, 334);
            this.AddressLineBox.Name = "AddressLineBox";
            this.AddressLineBox.PlaceholderText = "Your House Number, Street, Subdivision, and Barangay";
            this.AddressLineBox.Size = new System.Drawing.Size(575, 29);
            this.AddressLineBox.TabIndex = 14;
            this.AddressLineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CityProvinceBox
            // 
            this.CityProvinceBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityProvinceBox.Location = new System.Drawing.Point(128, 369);
            this.CityProvinceBox.Name = "CityProvinceBox";
            this.CityProvinceBox.PlaceholderText = "Your Municipality, City, Province, and ZIP Code";
            this.CityProvinceBox.Size = new System.Drawing.Size(575, 29);
            this.CityProvinceBox.TabIndex = 15;
            this.CityProvinceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BranchVisitBox
            // 
            this.BranchVisitBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchVisitBox.Location = new System.Drawing.Point(128, 404);
            this.BranchVisitBox.Name = "BranchVisitBox";
            this.BranchVisitBox.PlaceholderText = "Example: MyCompany Store Mall of Asia 1, please ask staff for exact details.";
            this.BranchVisitBox.Size = new System.Drawing.Size(575, 29);
            this.BranchVisitBox.TabIndex = 16;
            this.BranchVisitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PickDate
            // 
            this.PickDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickDate.Location = new System.Drawing.Point(445, 157);
            this.PickDate.Name = "PickDate";
            this.PickDate.Size = new System.Drawing.Size(258, 29);
            this.PickDate.TabIndex = 17;
            this.PickDate.Value = new System.DateTime(2021, 6, 1, 22, 56, 58, 0);
            // 
            // PickTime
            // 
            this.PickTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickTime.Location = new System.Drawing.Point(128, 157);
            this.PickTime.Name = "PickTime";
            this.PickTime.Size = new System.Drawing.Size(158, 29);
            this.PickTime.TabIndex = 18;
            this.PickTime.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberBox.Location = new System.Drawing.Point(128, 299);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.PlaceholderText = "09XXXXXXXX";
            this.NumberBox.Size = new System.Drawing.Size(132, 29);
            this.NumberBox.TabIndex = 19;
            this.NumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailBox.Location = new System.Drawing.Point(369, 299);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PlaceholderText = "YourMail@YourProvider.com";
            this.EmailBox.Size = new System.Drawing.Size(334, 29);
            this.EmailBox.TabIndex = 20;
            this.EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttentionLabel
            // 
            this.AttentionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AttentionLabel.AutoSize = true;
            this.AttentionLabel.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttentionLabel.Location = new System.Drawing.Point(9, 444);
            this.AttentionLabel.Name = "AttentionLabel";
            this.AttentionLabel.Size = new System.Drawing.Size(594, 70);
            this.AttentionLabel.TabIndex = 21;
            this.AttentionLabel.Text = resources.GetString("AttentionLabel.Text");
            this.AttentionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AttentionLabel.Click += new System.EventHandler(this.AttentionLabel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Neil
            // 
            this.Neil.Image = ((System.Drawing.Image)(resources.GetObject("Neil.Image")));
            this.Neil.Location = new System.Drawing.Point(562, 9);
            this.Neil.Name = "Neil";
            this.Neil.Size = new System.Drawing.Size(141, 73);
            this.Neil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Neil.TabIndex = 22;
            this.Neil.TabStop = false;
            // 
            // Symptoms
            // 
            this.Symptoms.AutoSize = true;
            this.Symptoms.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Symptoms.Location = new System.Drawing.Point(6, 210);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(406, 66);
            this.Symptoms.TabIndex = 23;
            this.Symptoms.Text = "Do you have any of the following symptoms\r\nin the last 14 days? Please check all " +
    "that applies.\r\nScroll to see more items.";
            this.Symptoms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SymptomList
            // 
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
            this.SymptomList.SelectedIndexChanged += new System.EventHandler(this.SymptomList_SelectedIndexChanged);
            // 
            // ContactForm1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(718, 526);
            this.Controls.Add(this.SymptomList);
            this.Controls.Add(this.Symptoms);
            this.Controls.Add(this.Neil);
            this.Controls.Add(this.AttentionLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.PickTime);
            this.Controls.Add(this.PickDate);
            this.Controls.Add(this.BranchVisitBox);
            this.Controls.Add(this.CityProvinceBox);
            this.Controls.Add(this.AddressLineBox);
            this.Controls.Add(this.LabelBranch);
            this.Controls.Add(this.LabelAddress2);
            this.Controls.Add(this.LabelAdress1);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.LabelName2);
            this.Controls.Add(this.LabelName1);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SubmitBTN);
            this.Controls.Add(this.HelpBTN);
            this.Controls.Add(this.Greeting);
            this.MaximizeBox = false;
            this.Name = "ContactForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Form";
            ((System.ComponentModel.ISupportInitialize)(this.Neil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Button HelpBTN;
        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label LabelName1;
        private System.Windows.Forms.Label LabelName2;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelAdress1;
        private System.Windows.Forms.Label LabelAddress2;
        private System.Windows.Forms.Label LabelBranch;
        private System.Windows.Forms.TextBox AddressLineBox;
        private System.Windows.Forms.TextBox CityProvinceBox;
        private System.Windows.Forms.TextBox BranchVisitBox;
        private System.Windows.Forms.DateTimePicker PickDate;
        private System.Windows.Forms.DateTimePicker PickTime;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label AttentionLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Neil;
        private System.Windows.Forms.Label Symptoms;
        private System.Windows.Forms.CheckedListBox SymptomList;
    }
}
