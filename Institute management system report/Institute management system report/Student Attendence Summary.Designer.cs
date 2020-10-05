namespace Institute_management_system_report
{
    partial class Student_Attendence_Summary
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Attendence_Summary));
            this.attendenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Institute_management_system_report.DataSet1();
            this.reportViewerattend = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.txt_module = new MetroFramework.Controls.MetroTextBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.rbn_module = new MetroFramework.Controls.MetroRadioButton();
            this.rbn_id = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox_clear = new System.Windows.Forms.PictureBox();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.attendenceTableAdapter = new Institute_management_system_report.DataSet1TableAdapters.attendenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.SuspendLayout();
            // 
            // attendenceBindingSource
            // 
            this.attendenceBindingSource.DataMember = "attendence";
            this.attendenceBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerattend
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.attendenceBindingSource;
            this.reportViewerattend.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerattend.LocalReport.ReportEmbeddedResource = "Institute_management_system_report.Report3.rdlc";
            this.reportViewerattend.Location = new System.Drawing.Point(14, 188);
            this.reportViewerattend.Name = "reportViewerattend";
            this.reportViewerattend.Size = new System.Drawing.Size(996, 261);
            this.reportViewerattend.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(692, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Attendence Summary";
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_search.Image")));
            this.pictureBox_search.Location = new System.Drawing.Point(614, 507);
            this.pictureBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_search.TabIndex = 97;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.Click += new System.EventHandler(this.pictureBox_search_Click);
            // 
            // txt_module
            // 
            // 
            // 
            // 
            this.txt_module.CustomButton.Image = null;
            this.txt_module.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txt_module.CustomButton.Name = "";
            this.txt_module.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_module.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_module.CustomButton.TabIndex = 1;
            this.txt_module.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_module.CustomButton.UseSelectable = true;
            this.txt_module.CustomButton.Visible = false;
            this.txt_module.Lines = new string[0];
            this.txt_module.Location = new System.Drawing.Point(437, 542);
            this.txt_module.MaxLength = 32767;
            this.txt_module.Name = "txt_module";
            this.txt_module.PasswordChar = '\0';
            this.txt_module.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_module.SelectedText = "";
            this.txt_module.SelectionLength = 0;
            this.txt_module.SelectionStart = 0;
            this.txt_module.ShortcutsEnabled = true;
            this.txt_module.Size = new System.Drawing.Size(133, 23);
            this.txt_module.TabIndex = 90;
            this.txt_module.UseSelectable = true;
            this.txt_module.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_module.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_id
            // 
            // 
            // 
            // 
            this.txt_id.CustomButton.Image = null;
            this.txt_id.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txt_id.CustomButton.Name = "";
            this.txt_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id.CustomButton.TabIndex = 1;
            this.txt_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id.CustomButton.UseSelectable = true;
            this.txt_id.CustomButton.Visible = false;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(437, 509);
            this.txt_id.MaxLength = 32767;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(133, 23);
            this.txt_id.TabIndex = 91;
            this.txt_id.UseSelectable = true;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbn_module
            // 
            this.rbn_module.AutoSize = true;
            this.rbn_module.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbn_module.Location = new System.Drawing.Point(264, 540);
            this.rbn_module.Name = "rbn_module";
            this.rbn_module.Size = new System.Drawing.Size(136, 25);
            this.rbn_module.TabIndex = 94;
            this.rbn_module.Text = "Module Code";
            this.rbn_module.UseSelectable = true;
            // 
            // rbn_id
            // 
            this.rbn_id.AutoSize = true;
            this.rbn_id.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbn_id.Location = new System.Drawing.Point(264, 507);
            this.rbn_id.Name = "rbn_id";
            this.rbn_id.Size = new System.Drawing.Size(112, 25);
            this.rbn_id.TabIndex = 95;
            this.rbn_id.Text = "Student ID";
            this.rbn_id.UseSelectable = true;
            // 
            // pictureBox_clear
            // 
            this.pictureBox_clear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_clear.Image")));
            this.pictureBox_clear.Location = new System.Drawing.Point(712, 507);
            this.pictureBox_clear.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_clear.Name = "pictureBox_clear";
            this.pictureBox_clear.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_clear.TabIndex = 98;
            this.pictureBox_clear.TabStop = false;
            this.pictureBox_clear.Click += new System.EventHandler(this.pictureBox_clear_Click);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_back.Image")));
            this.pictureBox_back.Location = new System.Drawing.Point(946, 43);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_back.TabIndex = 99;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click_1);
            // 
            // attendenceTableAdapter
            // 
            this.attendenceTableAdapter.ClearBeforeFill = true;
            // 
            // Student_Attendence_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 627);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_clear);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.txt_module);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.rbn_module);
            this.Controls.Add(this.rbn_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewerattend);
            this.MaximizeBox = false;
            this.Name = "Student_Attendence_Summary";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Student_Attendence_Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerattend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private MetroFramework.Controls.MetroTextBox txt_module;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroRadioButton rbn_module;
        private MetroFramework.Controls.MetroRadioButton rbn_id;
        private System.Windows.Forms.PictureBox pictureBox_clear;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.BindingSource attendenceBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.attendenceTableAdapter attendenceTableAdapter;
    }
}