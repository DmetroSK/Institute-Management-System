namespace Institute_management_system
{
    partial class Attendents
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
            this.txt_module = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid_attendence = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_stuid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_attendence)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attendents";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(18, 14);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(163, 146);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 7;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = global::Institute_management_system.Properties.Resources.back;
            this.pictureBox_back.Location = new System.Drawing.Point(997, 40);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_back.TabIndex = 19;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(1079, 40);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_home.TabIndex = 20;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // pictureBox_clear
            // 
            this.pictureBox_clear.Image = global::Institute_management_system.Properties.Resources.clear;
            this.pictureBox_clear.Location = new System.Drawing.Point(676, 173);
            this.pictureBox_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_clear.Name = "pictureBox_clear";
            this.pictureBox_clear.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_clear.TabIndex = 39;
            this.pictureBox_clear.TabStop = false;
            this.pictureBox_clear.Click += new System.EventHandler(this.pictureBox_clear_Click);
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = global::Institute_management_system.Properties.Resources.search;
            this.pictureBox_search.Location = new System.Drawing.Point(610, 172);
            this.pictureBox_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_search.TabIndex = 40;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.Click += new System.EventHandler(this.pictureBox_search_Click);
            // 
            // txt_module
            // 
            // 
            // 
            // 
            this.txt_module.CustomButton.Image = null;
            this.txt_module.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txt_module.CustomButton.Name = "";
            this.txt_module.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.txt_module.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_module.CustomButton.TabIndex = 1;
            this.txt_module.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_module.CustomButton.UseSelectable = true;
            this.txt_module.CustomButton.Visible = false;
            this.txt_module.Lines = new string[0];
            this.txt_module.Location = new System.Drawing.Point(409, 208);
            this.txt_module.MaxLength = 32767;
            this.txt_module.Name = "txt_module";
            this.txt_module.PasswordChar = '\0';
            this.txt_module.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_module.SelectedText = "";
            this.txt_module.SelectionLength = 0;
            this.txt_module.SelectionStart = 0;
            this.txt_module.ShortcutsEnabled = true;
            this.txt_module.Size = new System.Drawing.Size(124, 23);
            this.txt_module.TabIndex = 38;
            this.txt_module.UseSelectable = true;
            this.txt_module.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_module.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(303, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 25);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Module";
            // 
            // metroGrid_attendence
            // 
            this.metroGrid_attendence.AllowUserToResizeRows = false;
            this.metroGrid_attendence.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_attendence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_attendence.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_attendence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_attendence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_attendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_attendence.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_attendence.EnableHeadersVisualStyles = false;
            this.metroGrid_attendence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_attendence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_attendence.Location = new System.Drawing.Point(308, 284);
            this.metroGrid_attendence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroGrid_attendence.Name = "metroGrid_attendence";
            this.metroGrid_attendence.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_attendence.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_attendence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_attendence.RowTemplate.Height = 24;
            this.metroGrid_attendence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_attendence.Size = new System.Drawing.Size(432, 196);
            this.metroGrid_attendence.TabIndex = 36;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(303, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(103, 25);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Student ID";
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
            this.txt_stuid.Location = new System.Drawing.Point(409, 164);
            this.txt_stuid.MaxLength = 32767;
            this.txt_stuid.Name = "txt_stuid";
            this.txt_stuid.PasswordChar = '\0';
            this.txt_stuid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_stuid.SelectedText = "";
            this.txt_stuid.SelectionLength = 0;
            this.txt_stuid.SelectionStart = 0;
            this.txt_stuid.ShortcutsEnabled = true;
            this.txt_stuid.Size = new System.Drawing.Size(124, 23);
            this.txt_stuid.TabIndex = 42;
            this.txt_stuid.UseSelectable = true;
            this.txt_stuid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_stuid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(687, 239);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 25);
            this.metroLabel8.TabIndex = 43;
            this.metroLabel8.Text = "Clear";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(611, 239);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 25);
            this.metroLabel7.TabIndex = 44;
            this.metroLabel7.Text = "Search";
            // 
            // Attendents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 735);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_stuid);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pictureBox_clear);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.txt_module);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroGrid_attendence);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Attendents";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Attendents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_attendence)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox txt_module;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid metroGrid_attendence;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_stuid;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}