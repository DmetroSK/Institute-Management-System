namespace Institute_management_system
{
    partial class Examination_Department
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
            this.tile_examdates = new MetroFramework.Controls.MetroTile();
            this.tile_results = new MetroFramework.Controls.MetroTile();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 69);
            this.label1.TabIndex = 34;
            this.label1.Text = "Examination Department";
            // 
            // tile_examdates
            // 
            this.tile_examdates.ActiveControl = null;
            this.tile_examdates.Location = new System.Drawing.Point(713, 315);
            this.tile_examdates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_examdates.Name = "tile_examdates";
            this.tile_examdates.Size = new System.Drawing.Size(396, 220);
            this.tile_examdates.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_examdates.TabIndex = 32;
            this.tile_examdates.Text = "Exam Dates\r\n\r\nInsert/Update/View/Delete";
            this.tile_examdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_examdates.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_examdates.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_examdates.UseSelectable = true;
            this.tile_examdates.Click += new System.EventHandler(this.tile_examdates_Click);
            // 
            // tile_results
            // 
            this.tile_results.ActiveControl = null;
            this.tile_results.Location = new System.Drawing.Point(281, 315);
            this.tile_results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_results.Name = "tile_results";
            this.tile_results.Size = new System.Drawing.Size(396, 220);
            this.tile_results.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_results.TabIndex = 33;
            this.tile_results.Text = "Results\r\n\r\nInsert/Update/View/Delete";
            this.tile_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_results.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_results.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_results.UseSelectable = true;
            this.tile_results.Click += new System.EventHandler(this.tile_results_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::Institute_management_system.Properties.Resources.Logo;
            this.pic_logo.Location = new System.Drawing.Point(17, 22);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(217, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 35;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::Institute_management_system.Properties.Resources.home;
            this.pictureBox_home.Location = new System.Drawing.Point(1445, 39);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_home.TabIndex = 36;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // Examination_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 905);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tile_examdates);
            this.Controls.Add(this.tile_results);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Examination_Department";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile tile_examdates;
        private MetroFramework.Controls.MetroTile tile_results;
        private System.Windows.Forms.PictureBox pictureBox_home;
    }
}