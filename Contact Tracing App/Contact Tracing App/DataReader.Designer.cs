
namespace Contact_Tracing_App
{
    partial class DataReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataReader));
            this.Greeting = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.YourCompanyLogo = new System.Windows.Forms.PictureBox();
            this.PickDateFile = new System.Windows.Forms.DateTimePicker();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.DisplayBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.YourCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Greeting.Location = new System.Drawing.Point(44, 9);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(528, 112);
            this.Greeting.TabIndex = 24;
            this.Greeting.Text = resources.GetString("Greeting.Text");
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Location = new System.Drawing.Point(658, 139);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 49);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileLabel.Location = new System.Drawing.Point(95, 154);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(143, 19);
            this.FileLabel.TabIndex = 28;
            this.FileLabel.Text = "Enter Date for File";
            // 
            // YourCompanyLogo
            // 
            this.YourCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("YourCompanyLogo.Image")));
            this.YourCompanyLogo.Location = new System.Drawing.Point(616, 24);
            this.YourCompanyLogo.Name = "YourCompanyLogo";
            this.YourCompanyLogo.Size = new System.Drawing.Size(172, 85);
            this.YourCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YourCompanyLogo.TabIndex = 29;
            this.YourCompanyLogo.TabStop = false;
            // 
            // PickDateFile
            // 
            this.PickDateFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PickDateFile.Location = new System.Drawing.Point(244, 147);
            this.PickDateFile.Name = "PickDateFile";
            this.PickDateFile.Size = new System.Drawing.Size(258, 29);
            this.PickDateFile.TabIndex = 30;
            this.PickDateFile.Value = new System.DateTime(2021, 6, 1, 22, 56, 58, 0);
            this.PickDateFile.ValueChanged += new System.EventHandler(this.PickDateFile_ValueChanged);
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitBTN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitBTN.Location = new System.Drawing.Point(560, 144);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(92, 38);
            this.SubmitBTN.TabIndex = 31;
            this.SubmitBTN.Text = "SUBMIT";
            this.SubmitBTN.UseVisualStyleBackColor = false;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayBox.Location = new System.Drawing.Point(12, 194);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(776, 381);
            this.DisplayBox.TabIndex = 32;
            this.DisplayBox.Text = "";
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.ControlBox = false;
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.SubmitBTN);
            this.Controls.Add(this.PickDateFile);
            this.Controls.Add(this.YourCompanyLogo);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Greeting);
            this.MaximizeBox = false;
            this.Name = "DataReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(DATA READER) YourCompany Philippines Contact Tracing Form";
            this.Load += new System.EventHandler(this.DataReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YourCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Greeting;
        public System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.PictureBox YourCompanyLogo;
        private System.Windows.Forms.DateTimePicker PickDateFile;
        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.RichTextBox DisplayBox;
    }
}