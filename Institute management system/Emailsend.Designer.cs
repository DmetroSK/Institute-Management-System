namespace Institute_management_system
{
    partial class Emailsend
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
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_body = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_pw = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(1074, 31);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_home.TabIndex = 20;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(16, 16);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(163, 146);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 18;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(300, 299);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(32, 25);
            this.metroLabel3.TabIndex = 64;
            this.metroLabel3.Text = "To";
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(435, 303);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(307, 20);
            this.txt_to.TabIndex = 65;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(300, 349);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 25);
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "Subject";
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(435, 353);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(307, 20);
            this.txt_sub.TabIndex = 65;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(300, 400);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 25);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "Message";
            // 
            // txt_body
            // 
            this.txt_body.Location = new System.Drawing.Point(435, 400);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.Size = new System.Drawing.Size(307, 132);
            this.txt_body.TabIndex = 65;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(524, 581);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 66;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click_2);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(300, 210);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 25);
            this.metroLabel4.TabIndex = 64;
            this.metroLabel4.Text = "Email Address";
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(435, 214);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(307, 20);
            this.txt_add.TabIndex = 65;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(300, 260);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 25);
            this.metroLabel5.TabIndex = 64;
            this.metroLabel5.Text = "Password";
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(435, 264);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(307, 20);
            this.txt_pw.TabIndex = 65;
            // 
            // Emailsend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 735);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_body);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Name = "Emailsend";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "To";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txt_to;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txt_sub;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox txt_body;
        private System.Windows.Forms.Button btn_send;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txt_add;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txt_pw;
    }
}