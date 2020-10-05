namespace Institute_Management_System_Report
{
    partial class Examination_Result_Summery
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
            this.label1 = new System.Windows.Forms.Label();
            this.pic_rlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Examination Result Summery";
            // 
            // pic_rlogo
            // 
            this.pic_rlogo.Image = global::Institute_Management_System_Report.Properties.Resources.Logo;
            this.pic_rlogo.Location = new System.Drawing.Point(14, 19);
            this.pic_rlogo.Name = "pic_rlogo";
            this.pic_rlogo.Size = new System.Drawing.Size(163, 146);
            this.pic_rlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rlogo.TabIndex = 14;
            this.pic_rlogo.TabStop = false;
            this.pic_rlogo.Click += new System.EventHandler(this.pic_rlogo_Click);
            // 
            // Examination_Result_Summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 627);
            this.Controls.Add(this.pic_rlogo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Examination_Result_Summery";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Examination_Result_Summery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_rlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_rlogo;
    }
}