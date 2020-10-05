namespace Institute_Management_System_Report
{
    partial class Student_Attendence_Summery
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_sub = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_nic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student Attendence Summery";
            // 
            // pic_rlogo
            // 
            this.pic_rlogo.Image = global::Institute_Management_System_Report.Properties.Resources.Logo;
            this.pic_rlogo.Location = new System.Drawing.Point(14, 19);
            this.pic_rlogo.Name = "pic_rlogo";
            this.pic_rlogo.Size = new System.Drawing.Size(163, 146);
            this.pic_rlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rlogo.TabIndex = 13;
            this.pic_rlogo.TabStop = false;
            this.pic_rlogo.Click += new System.EventHandler(this.pic_rlogo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(339, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(339, 233);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "NIC";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(339, 287);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Mark";
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(432, 364);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 15;
            this.btn_sub.Text = "Submit";
            this.btn_sub.UseSelectable = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // txt_mark
            // 
            this.txt_mark.Location = new System.Drawing.Point(488, 286);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(100, 20);
            this.txt_mark.TabIndex = 16;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(488, 180);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(488, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            // 
            // txt_nic
            // 
            this.txt_nic.Location = new System.Drawing.Point(488, 232);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(100, 20);
            this.txt_nic.TabIndex = 16;
            // 
            // Student_Attendence_Summery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 627);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pic_rlogo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Student_Attendence_Summery";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Student_Attendence_Summery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_rlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_rlogo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_sub;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_nic;
    }
}