namespace Institute_management_system_report
{
    partial class Payment_Summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Summary));
            this.reportViewerpayment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.txt_batch = new MetroFramework.Controls.MetroTextBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.rbn_batch = new MetroFramework.Controls.MetroRadioButton();
            this.rbn_id = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox_clear = new System.Windows.Forms.PictureBox();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.DataSet1 = new Institute_management_system_report.DataSet1();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Institute_management_system_report.DataSet1TableAdapters.paymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerpayment
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.paymentBindingSource;
            this.reportViewerpayment.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerpayment.LocalReport.ReportEmbeddedResource = "Institute_management_system_report.Report2.rdlc";
            this.reportViewerpayment.Location = new System.Drawing.Point(14, 188);
            this.reportViewerpayment.Name = "reportViewerpayment";
            this.reportViewerpayment.Size = new System.Drawing.Size(996, 261);
            this.reportViewerpayment.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Summary";
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_search.Image")));
            this.pictureBox_search.Location = new System.Drawing.Point(600, 510);
            this.pictureBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_search.TabIndex = 93;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.Click += new System.EventHandler(this.pictureBox_search_Click);
            // 
            // txt_batch
            // 
            // 
            // 
            // 
            this.txt_batch.CustomButton.Image = null;
            this.txt_batch.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txt_batch.CustomButton.Name = "";
            this.txt_batch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_batch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_batch.CustomButton.TabIndex = 1;
            this.txt_batch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_batch.CustomButton.UseSelectable = true;
            this.txt_batch.CustomButton.Visible = false;
            this.txt_batch.Lines = new string[0];
            this.txt_batch.Location = new System.Drawing.Point(432, 551);
            this.txt_batch.MaxLength = 32767;
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.PasswordChar = '\0';
            this.txt_batch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_batch.SelectedText = "";
            this.txt_batch.SelectionLength = 0;
            this.txt_batch.SelectionStart = 0;
            this.txt_batch.ShortcutsEnabled = true;
            this.txt_batch.Size = new System.Drawing.Size(133, 23);
            this.txt_batch.TabIndex = 88;
            this.txt_batch.UseSelectable = true;
            this.txt_batch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_batch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_id.Location = new System.Drawing.Point(432, 510);
            this.txt_id.MaxLength = 32767;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(133, 23);
            this.txt_id.TabIndex = 89;
            this.txt_id.UseSelectable = true;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbn_batch
            // 
            this.rbn_batch.AutoSize = true;
            this.rbn_batch.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbn_batch.Location = new System.Drawing.Point(288, 549);
            this.rbn_batch.Name = "rbn_batch";
            this.rbn_batch.Size = new System.Drawing.Size(71, 25);
            this.rbn_batch.TabIndex = 90;
            this.rbn_batch.Text = "Batch";
            this.rbn_batch.UseSelectable = true;
            // 
            // rbn_id
            // 
            this.rbn_id.AutoSize = true;
            this.rbn_id.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbn_id.Location = new System.Drawing.Point(288, 508);
            this.rbn_id.Name = "rbn_id";
            this.rbn_id.Size = new System.Drawing.Size(112, 25);
            this.rbn_id.TabIndex = 91;
            this.rbn_id.Text = "Student ID";
            this.rbn_id.UseSelectable = true;
            // 
            // pictureBox_clear
            // 
            this.pictureBox_clear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_clear.Image")));
            this.pictureBox_clear.Location = new System.Drawing.Point(693, 510);
            this.pictureBox_clear.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_clear.Name = "pictureBox_clear";
            this.pictureBox_clear.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_clear.TabIndex = 94;
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
            this.pictureBox_back.TabIndex = 95;
            this.pictureBox_back.TabStop = false;
            this.pictureBox_back.Click += new System.EventHandler(this.pictureBox_back_Click_1);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.DataSet1;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // Payment_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 627);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_clear);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.txt_batch);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.rbn_batch);
            this.Controls.Add(this.rbn_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewerpayment);
            this.MaximizeBox = false;
            this.Name = "Payment_Summary";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Payment_Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerpayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private MetroFramework.Controls.MetroTextBox txt_batch;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroRadioButton rbn_batch;
        private MetroFramework.Controls.MetroRadioButton rbn_id;
        private System.Windows.Forms.PictureBox pictureBox_clear;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.paymentTableAdapter paymentTableAdapter;
    }
}