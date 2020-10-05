namespace Institute_management_system
{
    partial class Student_Details
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
            this.metroGrid_stuDetails = new MetroFramework.Controls.MetroGrid();
            this.txt_stuid = new MetroFramework.Controls.MetroTextBox();
            this.txt_batch = new MetroFramework.Controls.MetroTextBox();
            this.txt_course = new MetroFramework.Controls.MetroTextBox();
            this.rbn_stuid = new MetroFramework.Controls.MetroRadioButton();
            this.rbn_course = new MetroFramework.Controls.MetroRadioButton();
            this.rbn_batch = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_stuDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "Student Details";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(14, 25);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(163, 146);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 17;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = global::Institute_management_system.Properties.Resources.back;
            this.pictureBox_back.Location = new System.Drawing.Point(993, 36);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_back.TabIndex = 18;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(1075, 36);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_home.TabIndex = 19;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // pictureBox_clear
            // 
            this.pictureBox_clear.Image = global::Institute_management_system.Properties.Resources.clear;
            this.pictureBox_clear.Location = new System.Drawing.Point(719, 188);
            this.pictureBox_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pictureBox_search.Location = new System.Drawing.Point(651, 188);
            this.pictureBox_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_search.TabIndex = 30;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.Click += new System.EventHandler(this.pictureBox_search_Click);
            // 
            // metroGrid_stuDetails
            // 
            this.metroGrid_stuDetails.AllowUserToResizeRows = false;
            this.metroGrid_stuDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_stuDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_stuDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_stuDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_stuDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_stuDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_stuDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_stuDetails.EnableHeadersVisualStyles = false;
            this.metroGrid_stuDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_stuDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_stuDetails.Location = new System.Drawing.Point(208, 282);
            this.metroGrid_stuDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroGrid_stuDetails.Name = "metroGrid_stuDetails";
            this.metroGrid_stuDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_stuDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_stuDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_stuDetails.RowTemplate.Height = 24;
            this.metroGrid_stuDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_stuDetails.Size = new System.Drawing.Size(778, 439);
            this.metroGrid_stuDetails.TabIndex = 24;
            // 
            // txt_stuid
            // 
            // 
            // 
            // 
            this.txt_stuid.CustomButton.Image = null;
            this.txt_stuid.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txt_stuid.CustomButton.Name = "";
            this.txt_stuid.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_stuid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_stuid.CustomButton.TabIndex = 1;
            this.txt_stuid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_stuid.CustomButton.UseSelectable = true;
            this.txt_stuid.CustomButton.Visible = false;
            this.txt_stuid.Lines = new string[0];
            this.txt_stuid.Location = new System.Drawing.Point(482, 143);
            this.txt_stuid.MaxLength = 32767;
            this.txt_stuid.Name = "txt_stuid";
            this.txt_stuid.PasswordChar = '\0';
            this.txt_stuid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stuid.SelectedText = "";
            this.txt_stuid.SelectionLength = 0;
            this.txt_stuid.SelectionStart = 0;
            this.txt_stuid.ShortcutsEnabled = true;
            this.txt_stuid.Size = new System.Drawing.Size(124, 23);
            this.txt_stuid.TabIndex = 60;
            this.txt_stuid.UseSelectable = true;
            this.txt_stuid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_stuid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_batch
            // 
            // 
            // 
            // 
            this.txt_batch.CustomButton.Image = null;
            this.txt_batch.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txt_batch.CustomButton.Name = "";
            this.txt_batch.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_batch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_batch.CustomButton.TabIndex = 1;
            this.txt_batch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_batch.CustomButton.UseSelectable = true;
            this.txt_batch.CustomButton.Visible = false;
            this.txt_batch.Lines = new string[0];
            this.txt_batch.Location = new System.Drawing.Point(482, 219);
            this.txt_batch.MaxLength = 32767;
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.PasswordChar = '\0';
            this.txt_batch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_batch.SelectedText = "";
            this.txt_batch.SelectionLength = 0;
            this.txt_batch.SelectionStart = 0;
            this.txt_batch.ShortcutsEnabled = true;
            this.txt_batch.Size = new System.Drawing.Size(124, 23);
            this.txt_batch.TabIndex = 58;
            this.txt_batch.UseSelectable = true;
            this.txt_batch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_batch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_course
            // 
            // 
            // 
            // 
            this.txt_course.CustomButton.Image = null;
            this.txt_course.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txt_course.CustomButton.Name = "";
            this.txt_course.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_course.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_course.CustomButton.TabIndex = 1;
            this.txt_course.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_course.CustomButton.UseSelectable = true;
            this.txt_course.CustomButton.Visible = false;
            this.txt_course.Lines = new string[0];
            this.txt_course.Location = new System.Drawing.Point(482, 180);
            this.txt_course.MaxLength = 32767;
            this.txt_course.Name = "txt_course";
            this.txt_course.PasswordChar = '\0';
            this.txt_course.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_course.SelectedText = "";
            this.txt_course.SelectionLength = 0;
            this.txt_course.SelectionStart = 0;
            this.txt_course.ShortcutsEnabled = true;
            this.txt_course.Size = new System.Drawing.Size(124, 23);
            this.txt_course.TabIndex = 54;
            this.txt_course.UseSelectable = true;
            this.txt_course.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_course.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbn_stuid
            // 
            this.rbn_stuid.AutoSize = true;
            this.rbn_stuid.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbn_stuid.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbn_stuid.Location = new System.Drawing.Point(361, 146);
            this.rbn_stuid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbn_stuid.Name = "rbn_stuid";
            this.rbn_stuid.Size = new System.Drawing.Size(119, 25);
            this.rbn_stuid.TabIndex = 62;
            this.rbn_stuid.Text = "Student ID";
            this.rbn_stuid.UseSelectable = true;
            // 
            // rbn_course
            // 
            this.rbn_course.AutoSize = true;
            this.rbn_course.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbn_course.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbn_course.Location = new System.Drawing.Point(361, 184);
            this.rbn_course.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbn_course.Name = "rbn_course";
            this.rbn_course.Size = new System.Drawing.Size(86, 25);
            this.rbn_course.TabIndex = 62;
            this.rbn_course.Text = "Course";
            this.rbn_course.UseSelectable = true;
            // 
            // rbn_batch
            // 
            this.rbn_batch.AutoSize = true;
            this.rbn_batch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbn_batch.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbn_batch.Location = new System.Drawing.Point(361, 219);
            this.rbn_batch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbn_batch.Name = "rbn_batch";
            this.rbn_batch.Size = new System.Drawing.Size(77, 25);
            this.rbn_batch.TabIndex = 62;
            this.rbn_batch.Text = "Batch";
            this.rbn_batch.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(728, 255);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 25);
            this.metroLabel8.TabIndex = 63;
            this.metroLabel8.Text = "Clear";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(652, 255);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 25);
            this.metroLabel7.TabIndex = 64;
            this.metroLabel7.Text = "Search";
            // 
            // Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 735);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.rbn_batch);
            this.Controls.Add(this.rbn_course);
            this.Controls.Add(this.rbn_stuid);
            this.Controls.Add(this.txt_stuid);
            this.Controls.Add(this.txt_batch);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.pictureBox_clear);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.metroGrid_stuDetails);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Student_Details";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_stuDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_clear;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private MetroFramework.Controls.MetroGrid metroGrid_stuDetails;
        private MetroFramework.Controls.MetroTextBox txt_stuid;
        private MetroFramework.Controls.MetroTextBox txt_batch;
        private MetroFramework.Controls.MetroTextBox txt_course;
        private MetroFramework.Controls.MetroRadioButton rbn_stuid;
        private MetroFramework.Controls.MetroRadioButton rbn_course;
        private MetroFramework.Controls.MetroRadioButton rbn_batch;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}