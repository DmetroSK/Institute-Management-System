namespace Institute_management_system
{
    partial class Staff_Registration
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
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_submit = new MetroFramework.Controls.MetroTile();
            this.cmb_dep = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.txt_staffid = new MetroFramework.Controls.MetroTextBox();
            this.txt_qualifi = new MetroFramework.Controls.MetroTextBox();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 69);
            this.label1.TabIndex = 21;
            this.label1.Text = "Registration Form";
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = global::Institute_management_system.Properties.Resources.back;
            this.pictureBox_back.Location = new System.Drawing.Point(1313, 46);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_back.TabIndex = 23;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(1423, 46);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_home.TabIndex = 24;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(12, 27);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(217, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 22;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.ActiveControl = null;
            this.btn_submit.Location = new System.Drawing.Point(647, 583);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(140, 52);
            this.btn_submit.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_submit.TabIndex = 55;
            this.btn_submit.Text = "Submit";
            this.btn_submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_submit.UseSelectable = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cmb_dep
            // 
            this.cmb_dep.FormattingEnabled = true;
            this.cmb_dep.ItemHeight = 24;
            this.cmb_dep.Items.AddRange(new object[] {
            "Lecture",
            "Account",
            "Examination",
            "MIS"});
            this.cmb_dep.Location = new System.Drawing.Point(609, 236);
            this.cmb_dep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_dep.Name = "cmb_dep";
            this.cmb_dep.Size = new System.Drawing.Size(193, 30);
            this.cmb_dep.TabIndex = 54;
            this.cmb_dep.UseSelectable = true;
            this.cmb_dep.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(325, 241);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(120, 25);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel14.TabIndex = 34;
            this.metroLabel14.Text = "Department";
            // 
            // metroDateTime
            // 
            this.metroDateTime.CustomFormat = "yyyy-MM-dd";
            this.metroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime.Location = new System.Drawing.Point(609, 289);
            this.metroDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime.Name = "metroDateTime";
            this.metroDateTime.Size = new System.Drawing.Size(265, 30);
            this.metroDateTime.TabIndex = 81;
            // 
            // txt_staffid
            // 
            // 
            // 
            // 
            this.txt_staffid.CustomButton.Image = null;
            this.txt_staffid.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.txt_staffid.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_staffid.CustomButton.Name = "";
            this.txt_staffid.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_staffid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_staffid.CustomButton.TabIndex = 1;
            this.txt_staffid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_staffid.CustomButton.UseSelectable = true;
            this.txt_staffid.CustomButton.Visible = false;
            this.txt_staffid.Lines = new string[0];
            this.txt_staffid.Location = new System.Drawing.Point(609, 442);
            this.txt_staffid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_staffid.MaxLength = 32767;
            this.txt_staffid.Name = "txt_staffid";
            this.txt_staffid.PasswordChar = '\0';
            this.txt_staffid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_staffid.SelectedText = "";
            this.txt_staffid.SelectionLength = 0;
            this.txt_staffid.SelectionStart = 0;
            this.txt_staffid.ShortcutsEnabled = true;
            this.txt_staffid.Size = new System.Drawing.Size(177, 28);
            this.txt_staffid.TabIndex = 77;
            this.txt_staffid.UseSelectable = true;
            this.txt_staffid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_staffid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_qualifi
            // 
            // 
            // 
            // 
            this.txt_qualifi.CustomButton.Image = null;
            this.txt_qualifi.CustomButton.Location = new System.Drawing.Point(753, 2);
            this.txt_qualifi.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_qualifi.CustomButton.Name = "";
            this.txt_qualifi.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_qualifi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qualifi.CustomButton.TabIndex = 1;
            this.txt_qualifi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qualifi.CustomButton.UseSelectable = true;
            this.txt_qualifi.CustomButton.Visible = false;
            this.txt_qualifi.Lines = new string[0];
            this.txt_qualifi.Location = new System.Drawing.Point(609, 395);
            this.txt_qualifi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_qualifi.MaxLength = 32767;
            this.txt_qualifi.Name = "txt_qualifi";
            this.txt_qualifi.PasswordChar = '\0';
            this.txt_qualifi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qualifi.SelectedText = "";
            this.txt_qualifi.SelectionLength = 0;
            this.txt_qualifi.SelectionStart = 0;
            this.txt_qualifi.ShortcutsEnabled = true;
            this.txt_qualifi.Size = new System.Drawing.Size(591, 28);
            this.txt_qualifi.TabIndex = 79;
            this.txt_qualifi.UseSelectable = true;
            this.txt_qualifi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qualifi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(753, 2);
            this.txt_name.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(609, 185);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(591, 28);
            this.txt_name.TabIndex = 80;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(325, 294);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 72;
            this.metroLabel3.Text = "Join  Date";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(325, 393);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(125, 25);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel12.TabIndex = 73;
            this.metroLabel12.Text = "Qualification";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(323, 442);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(79, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel11.TabIndex = 74;
            this.metroLabel11.Text = "Staff ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(325, 185);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 76;
            this.metroLabel1.Text = "Full Name";
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(671, 2);
            this.txt_email.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(609, 347);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(529, 28);
            this.txt_email.TabIndex = 83;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(325, 345);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(135, 25);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel13.TabIndex = 82;
            this.metroLabel13.Text = "Email Address";
            // 
            // Staff_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 905);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroDateTime);
            this.Controls.Add(this.txt_staffid);
            this.Controls.Add(this.txt_qualifi);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cmb_dep);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Staff_Registration";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Staff_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btn_submit;
        private MetroFramework.Controls.MetroComboBox cmb_dep;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroDateTime metroDateTime;
        private MetroFramework.Controls.MetroTextBox txt_staffid;
        private MetroFramework.Controls.MetroTextBox txt_qualifi;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}