namespace Institute_management_system
{
    partial class LectureShedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_clear = new System.Windows.Forms.PictureBox();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.txt_course = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid_stushedule = new MetroFramework.Controls.MetroGrid();
            this.txt_batch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkbox_view = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_stushedule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lecture Shedule";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(24, 22);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(217, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 6;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = global::Institute_management_system.Properties.Resources.back;
            this.pictureBox_back.Location = new System.Drawing.Point(1333, 41);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_back.TabIndex = 17;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(1443, 41);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_home.TabIndex = 18;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // pictureBox_clear
            // 
            this.pictureBox_clear.Image = global::Institute_management_system.Properties.Resources.clear;
            this.pictureBox_clear.Location = new System.Drawing.Point(947, 206);
            this.pictureBox_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_clear.Name = "pictureBox_clear";
            this.pictureBox_clear.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_clear.TabIndex = 29;
            this.pictureBox_clear.TabStop = false;
            this.pictureBox_clear.Click += new System.EventHandler(this.pictureBox_clear_Click);
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = global::Institute_management_system.Properties.Resources.search;
            this.pictureBox_search.Location = new System.Drawing.Point(859, 204);
            this.pictureBox_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_search.TabIndex = 30;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.Click += new System.EventHandler(this.pictureBox_search_Click);
            // 
            // txt_course
            // 
            // 
            // 
            // 
            this.txt_course.CustomButton.Image = null;
            this.txt_course.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txt_course.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_course.CustomButton.Name = "";
            this.txt_course.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_course.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_course.CustomButton.TabIndex = 1;
            this.txt_course.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_course.CustomButton.UseSelectable = true;
            this.txt_course.CustomButton.Visible = false;
            this.txt_course.Lines = new string[0];
            this.txt_course.Location = new System.Drawing.Point(539, 199);
            this.txt_course.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_course.MaxLength = 32767;
            this.txt_course.Name = "txt_course";
            this.txt_course.PasswordChar = '\0';
            this.txt_course.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_course.SelectedText = "";
            this.txt_course.SelectionLength = 0;
            this.txt_course.SelectionStart = 0;
            this.txt_course.ShortcutsEnabled = true;
            this.txt_course.Size = new System.Drawing.Size(165, 28);
            this.txt_course.TabIndex = 27;
            this.txt_course.UseSelectable = true;
            this.txt_course.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_course.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(421, 206);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 25);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Course";
            // 
            // metroGrid_stushedule
            // 
            this.metroGrid_stushedule.AllowUserToResizeRows = false;
            this.metroGrid_stushedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_stushedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_stushedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_stushedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_stushedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_stushedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_stushedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_stushedule.EnableHeadersVisualStyles = false;
            this.metroGrid_stushedule.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_stushedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_stushedule.Location = new System.Drawing.Point(256, 334);
            this.metroGrid_stushedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroGrid_stushedule.Name = "metroGrid_stushedule";
            this.metroGrid_stushedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_stushedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_stushedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_stushedule.RowTemplate.Height = 24;
            this.metroGrid_stushedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_stushedule.Size = new System.Drawing.Size(1037, 500);
            this.metroGrid_stushedule.TabIndex = 24;
            // 
            // txt_batch
            // 
            // 
            // 
            // 
            this.txt_batch.CustomButton.Image = null;
            this.txt_batch.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txt_batch.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_batch.CustomButton.Name = "";
            this.txt_batch.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txt_batch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_batch.CustomButton.TabIndex = 1;
            this.txt_batch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_batch.CustomButton.UseSelectable = true;
            this.txt_batch.CustomButton.Visible = false;
            this.txt_batch.Lines = new string[0];
            this.txt_batch.Location = new System.Drawing.Point(539, 154);
            this.txt_batch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_batch.MaxLength = 32767;
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.PasswordChar = '\0';
            this.txt_batch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_batch.SelectedText = "";
            this.txt_batch.SelectionLength = 0;
            this.txt_batch.SelectionStart = 0;
            this.txt_batch.ShortcutsEnabled = true;
            this.txt_batch.Size = new System.Drawing.Size(165, 28);
            this.txt_batch.TabIndex = 32;
            this.txt_batch.UseSelectable = true;
            this.txt_batch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_batch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(421, 158);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 25);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Batch";
            // 
            // metroDateTime
            // 
            this.metroDateTime.CustomFormat = "yyyy-MM-dd";
            this.metroDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime.Location = new System.Drawing.Point(539, 255);
            this.metroDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroDateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime.Name = "metroDateTime";
            this.metroDateTime.Size = new System.Drawing.Size(265, 30);
            this.metroDateTime.TabIndex = 34;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(421, 254);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 25);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Date";
            // 
            // chkbox_view
            // 
            this.chkbox_view.AutoSize = true;
            this.chkbox_view.Location = new System.Drawing.Point(1095, 286);
            this.chkbox_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkbox_view.Name = "chkbox_view";
            this.chkbox_view.Size = new System.Drawing.Size(69, 17);
            this.chkbox_view.TabIndex = 35;
            this.chkbox_view.Text = "View All";
            this.chkbox_view.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(960, 290);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 25);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "Clear";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(859, 290);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 25);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Search";
            // 
            // LectureShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 905);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.chkbox_view);
            this.Controls.Add(this.metroDateTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_batch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox_clear);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroGrid_stushedule);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LectureShedule";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.LectureShedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_stushedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_clear;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private MetroFramework.Controls.MetroTextBox txt_course;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid metroGrid_stushedule;
        private MetroFramework.Controls.MetroTextBox txt_batch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkbox_view;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}