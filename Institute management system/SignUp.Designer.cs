namespace Institute_management_system
{
    partial class Sign_Up
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
            this.components = new System.ComponentModel.Container();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stuid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_pw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_conpw = new MetroFramework.Controls.MetroTextBox();
            this.btn_signup = new MetroFramework.Controls.MetroTile();
            this.EP_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_emailadd = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_pw = new System.Windows.Forms.ErrorProvider(this.components);
            this.EP_conpw = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_paycode = new MetroFramework.Controls.MetroTextBox();
            this.btn_check = new MetroFramework.Controls.MetroTile();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EP_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_emailadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_pw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_conpw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1401, 859);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign Up";
            // 
            // txt_stuid
            // 
            // 
            // 
            // 
            this.txt_stuid.CustomButton.Image = null;
            this.txt_stuid.CustomButton.Location = new System.Drawing.Point(493, 2);
            this.txt_stuid.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_stuid.CustomButton.Name = "";
            this.txt_stuid.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_stuid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_stuid.CustomButton.TabIndex = 1;
            this.txt_stuid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_stuid.CustomButton.UseSelectable = true;
            this.txt_stuid.CustomButton.Visible = false;
            this.txt_stuid.Lines = new string[0];
            this.txt_stuid.Location = new System.Drawing.Point(359, 186);
            this.txt_stuid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_stuid.MaxLength = 32767;
            this.txt_stuid.Name = "txt_stuid";
            this.txt_stuid.PasswordChar = '\0';
            this.txt_stuid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stuid.SelectedText = "";
            this.txt_stuid.SelectionLength = 0;
            this.txt_stuid.SelectionStart = 0;
            this.txt_stuid.ShortcutsEnabled = true;
            this.txt_stuid.Size = new System.Drawing.Size(396, 28);
            this.txt_stuid.TabIndex = 0;
            this.txt_stuid.UseSelectable = true;
            this.txt_stuid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_stuid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(133, 186);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Student ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(133, 290);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Password";
            // 
            // txt_pw
            // 
            // 
            // 
            // 
            this.txt_pw.CustomButton.Image = null;
            this.txt_pw.CustomButton.Location = new System.Drawing.Point(493, 2);
            this.txt_pw.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pw.CustomButton.Name = "";
            this.txt_pw.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pw.CustomButton.TabIndex = 1;
            this.txt_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pw.CustomButton.UseSelectable = true;
            this.txt_pw.CustomButton.Visible = false;
            this.txt_pw.Lines = new string[0];
            this.txt_pw.Location = new System.Drawing.Point(359, 290);
            this.txt_pw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pw.MaxLength = 32767;
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '\0';
            this.txt_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pw.SelectedText = "";
            this.txt_pw.SelectionLength = 0;
            this.txt_pw.SelectionStart = 0;
            this.txt_pw.ShortcutsEnabled = true;
            this.txt_pw.Size = new System.Drawing.Size(396, 28);
            this.txt_pw.TabIndex = 2;
            this.txt_pw.UseSelectable = true;
            this.txt_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(133, 348);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(175, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Confirm Password";
            // 
            // txt_conpw
            // 
            // 
            // 
            // 
            this.txt_conpw.CustomButton.Image = null;
            this.txt_conpw.CustomButton.Location = new System.Drawing.Point(493, 2);
            this.txt_conpw.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_conpw.CustomButton.Name = "";
            this.txt_conpw.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_conpw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_conpw.CustomButton.TabIndex = 1;
            this.txt_conpw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_conpw.CustomButton.UseSelectable = true;
            this.txt_conpw.CustomButton.Visible = false;
            this.txt_conpw.Lines = new string[0];
            this.txt_conpw.Location = new System.Drawing.Point(359, 348);
            this.txt_conpw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_conpw.MaxLength = 32767;
            this.txt_conpw.Name = "txt_conpw";
            this.txt_conpw.PasswordChar = '\0';
            this.txt_conpw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_conpw.SelectedText = "";
            this.txt_conpw.SelectionLength = 0;
            this.txt_conpw.SelectionStart = 0;
            this.txt_conpw.ShortcutsEnabled = true;
            this.txt_conpw.Size = new System.Drawing.Size(396, 28);
            this.txt_conpw.TabIndex = 3;
            this.txt_conpw.UseSelectable = true;
            this.txt_conpw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_conpw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_signup
            // 
            this.btn_signup.ActiveControl = null;
            this.btn_signup.Location = new System.Drawing.Point(543, 418);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(140, 52);
            this.btn_signup.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_signup.TabIndex = 8;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_signup.UseSelectable = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // EP_username
            // 
            this.EP_username.ContainerControl = this;
            // 
            // EP_emailadd
            // 
            this.EP_emailadd.ContainerControl = this;
            // 
            // EP_pw
            // 
            this.EP_pw.ContainerControl = this;
            // 
            // EP_conpw
            // 
            this.EP_conpw.ContainerControl = this;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(133, 238);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(141, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Payment Code";
            // 
            // txt_paycode
            // 
            // 
            // 
            // 
            this.txt_paycode.CustomButton.Image = null;
            this.txt_paycode.CustomButton.Location = new System.Drawing.Point(493, 2);
            this.txt_paycode.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_paycode.CustomButton.Name = "";
            this.txt_paycode.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_paycode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_paycode.CustomButton.TabIndex = 1;
            this.txt_paycode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_paycode.CustomButton.UseSelectable = true;
            this.txt_paycode.CustomButton.Visible = false;
            this.txt_paycode.Lines = new string[0];
            this.txt_paycode.Location = new System.Drawing.Point(359, 238);
            this.txt_paycode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_paycode.MaxLength = 32767;
            this.txt_paycode.Name = "txt_paycode";
            this.txt_paycode.PasswordChar = '\0';
            this.txt_paycode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_paycode.SelectedText = "";
            this.txt_paycode.SelectionLength = 0;
            this.txt_paycode.SelectionStart = 0;
            this.txt_paycode.ShortcutsEnabled = true;
            this.txt_paycode.Size = new System.Drawing.Size(396, 28);
            this.txt_paycode.TabIndex = 1;
            this.txt_paycode.UseSelectable = true;
            this.txt_paycode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_paycode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_check
            // 
            this.btn_check.ActiveControl = null;
            this.btn_check.Location = new System.Drawing.Point(383, 418);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(140, 52);
            this.btn_check.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_check.TabIndex = 12;
            this.btn_check.Text = "Check";
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_check.UseSelectable = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(11, 18);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(164, 132);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 5;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = global::Institute_management_system.Properties.Resources.back;
            this.pictureBox_back.Location = new System.Drawing.Point(759, 33);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(49, 46);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_back.TabIndex = 27;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(815, 33);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(49, 46);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_home.TabIndex = 28;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 551);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_conpw);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_paycode);
            this.Controls.Add(this.txt_stuid);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Sign_Up";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_emailadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_pw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_conpw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_logo;
        private MetroFramework.Controls.MetroTextBox txt_stuid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_pw;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_conpw;
        private MetroFramework.Controls.MetroTile btn_signup;
        private System.Windows.Forms.ErrorProvider EP_username;
        private System.Windows.Forms.ErrorProvider EP_emailadd;
        private System.Windows.Forms.ErrorProvider EP_pw;
        private System.Windows.Forms.ErrorProvider EP_conpw;
        private MetroFramework.Controls.MetroTextBox txt_paycode;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile btn_check;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.PictureBox pictureBox_home;
    }
}