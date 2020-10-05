namespace Institute_management_system
{
    partial class Student
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
            this.tile_email = new MetroFramework.Controls.MetroTile();
            this.tile_examresult = new MetroFramework.Controls.MetroTile();
            this.tile_examdate = new MetroFramework.Controls.MetroTile();
            this.tile_attendence = new MetroFramework.Controls.MetroTile();
            this.tile_lecshedule = new MetroFramework.Controls.MetroTile();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 69);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student";
            // 
            // tile_email
            // 
            this.tile_email.ActiveControl = null;
            this.tile_email.Location = new System.Drawing.Point(555, 538);
            this.tile_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_email.Name = "tile_email";
            this.tile_email.Size = new System.Drawing.Size(396, 220);
            this.tile_email.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_email.TabIndex = 6;
            this.tile_email.Text = "Email";
            this.tile_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_email.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_email.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_email.UseSelectable = true;
            this.tile_email.Click += new System.EventHandler(this.tile_email_Click);
            // 
            // tile_examresult
            // 
            this.tile_examresult.ActiveControl = null;
            this.tile_examresult.Location = new System.Drawing.Point(123, 538);
            this.tile_examresult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_examresult.Name = "tile_examresult";
            this.tile_examresult.Size = new System.Drawing.Size(396, 220);
            this.tile_examresult.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_examresult.TabIndex = 7;
            this.tile_examresult.Text = "Examination Result";
            this.tile_examresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_examresult.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_examresult.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_examresult.UseSelectable = true;
            this.tile_examresult.Click += new System.EventHandler(this.tile_examresult_Click);
            // 
            // tile_examdate
            // 
            this.tile_examdate.ActiveControl = null;
            this.tile_examdate.Location = new System.Drawing.Point(987, 287);
            this.tile_examdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_examdate.Name = "tile_examdate";
            this.tile_examdate.Size = new System.Drawing.Size(396, 220);
            this.tile_examdate.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_examdate.TabIndex = 8;
            this.tile_examdate.Text = "Examination Date";
            this.tile_examdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_examdate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_examdate.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_examdate.UseSelectable = true;
            this.tile_examdate.Click += new System.EventHandler(this.tile_examdate_Click);
            // 
            // tile_attendence
            // 
            this.tile_attendence.ActiveControl = null;
            this.tile_attendence.Location = new System.Drawing.Point(555, 287);
            this.tile_attendence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_attendence.Name = "tile_attendence";
            this.tile_attendence.Size = new System.Drawing.Size(396, 220);
            this.tile_attendence.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_attendence.TabIndex = 9;
            this.tile_attendence.Text = "Attendence";
            this.tile_attendence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_attendence.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_attendence.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_attendence.UseSelectable = true;
            this.tile_attendence.Click += new System.EventHandler(this.tile_attendence_Click);
            // 
            // tile_lecshedule
            // 
            this.tile_lecshedule.ActiveControl = null;
            this.tile_lecshedule.Location = new System.Drawing.Point(123, 287);
            this.tile_lecshedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_lecshedule.Name = "tile_lecshedule";
            this.tile_lecshedule.Size = new System.Drawing.Size(396, 220);
            this.tile_lecshedule.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_lecshedule.TabIndex = 10;
            this.tile_lecshedule.Text = "Lecture Shedules";
            this.tile_lecshedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_lecshedule.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_lecshedule.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_lecshedule.UseSelectable = true;
            this.tile_lecshedule.Click += new System.EventHandler(this.tile_lecshedule_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(1412, 68);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_home.TabIndex = 13;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(19, 23);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(217, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 12;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 905);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tile_email);
            this.Controls.Add(this.tile_examresult);
            this.Controls.Add(this.tile_examdate);
            this.Controls.Add(this.tile_attendence);
            this.Controls.Add(this.tile_lecshedule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Student";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Studentcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile tile_email;
        private MetroFramework.Controls.MetroTile tile_examresult;
        private MetroFramework.Controls.MetroTile tile_examdate;
        private MetroFramework.Controls.MetroTile tile_attendence;
        private MetroFramework.Controls.MetroTile tile_lecshedule;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pictureBox_home;
    }
}