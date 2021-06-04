
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
            this.Neil = new System.Windows.Forms.PictureBox();
            this.Greeting = new System.Windows.Forms.Label();
            this.DONEBTN = new System.Windows.Forms.Button();
            this.readerHelpBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Neil)).BeginInit();
            this.SuspendLayout();
            // 
            // Neil
            // 
            this.Neil.Image = ((System.Drawing.Image)(resources.GetObject("Neil.Image")));
            this.Neil.Location = new System.Drawing.Point(578, 22);
            this.Neil.Name = "Neil";
            this.Neil.Size = new System.Drawing.Size(155, 80);
            this.Neil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Neil.TabIndex = 23;
            this.Neil.TabStop = false;
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
            // DONEBTN
            // 
            this.DONEBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DONEBTN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DONEBTN.Location = new System.Drawing.Point(12, 138);
            this.DONEBTN.Name = "DONEBTN";
            this.DONEBTN.Size = new System.Drawing.Size(92, 38);
            this.DONEBTN.TabIndex = 25;
            this.DONEBTN.Text = "DONE";
            this.DONEBTN.UseVisualStyleBackColor = false;
            // 
            // readerHelpBTN
            // 
            this.readerHelpBTN.BackColor = System.Drawing.Color.FloralWhite;
            this.readerHelpBTN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readerHelpBTN.Location = new System.Drawing.Point(110, 142);
            this.readerHelpBTN.Name = "readerHelpBTN";
            this.readerHelpBTN.Size = new System.Drawing.Size(54, 31);
            this.readerHelpBTN.TabIndex = 26;
            this.readerHelpBTN.Text = "Help";
            this.readerHelpBTN.UseVisualStyleBackColor = false;
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.readerHelpBTN);
            this.Controls.Add(this.DONEBTN);
            this.Controls.Add(this.Greeting);
            this.Controls.Add(this.Neil);
            this.MaximizeBox = false;
            this.Name = "DataReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(DATA READER) YourCompany Philippines Contact Tracing Form";
            ((System.ComponentModel.ISupportInitialize)(this.Neil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Neil;
        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Button DONEBTN;
        private System.Windows.Forms.Button readerHelpBTN;
    }
}