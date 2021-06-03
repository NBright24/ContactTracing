
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
            ((System.ComponentModel.ISupportInitialize)(this.Neil)).BeginInit();
            this.SuspendLayout();
            // 
            // Neil
            // 
            this.Neil.Image = ((System.Drawing.Image)(resources.GetObject("Neil.Image")));
            this.Neil.Location = new System.Drawing.Point(647, 59);
            this.Neil.Name = "Neil";
            this.Neil.Size = new System.Drawing.Size(141, 73);
            this.Neil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Neil.TabIndex = 23;
            this.Neil.TabStop = false;
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Greeting.Location = new System.Drawing.Point(12, 19);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(612, 154);
            this.Greeting.TabIndex = 24;
            this.Greeting.Text = resources.GetString("Greeting.Text");
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.Greeting);
            this.Controls.Add(this.Neil);
            this.Name = "DataReader";
            this.Text = "(DATA READER) YourCompany Philippines Contact Tracing Form";
            ((System.ComponentModel.ISupportInitialize)(this.Neil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Neil;
        private System.Windows.Forms.Label Greeting;
    }
}