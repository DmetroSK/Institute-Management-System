namespace Institute_management_system
{
    partial class Register
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
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tile_staffregister = new MetroFramework.Controls.MetroTile();
            this.tile_sturegister = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.Image = global::Institute_management_system.Properties.Resources.back;
            this.pictureBox_back.Location = new System.Drawing.Point(1325, 57);
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
            this.pictureBox_home.Location = new System.Drawing.Point(1434, 57);
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
            this.pic_logo.Location = new System.Drawing.Point(24, 38);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(217, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 18;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 69);
            this.label1.TabIndex = 17;
            this.label1.Text = "Register";
            // 
            // tile_staffregister
            // 
            this.tile_staffregister.ActiveControl = null;
            this.tile_staffregister.Location = new System.Drawing.Point(734, 341);
            this.tile_staffregister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_staffregister.Name = "tile_staffregister";
            this.tile_staffregister.Size = new System.Drawing.Size(396, 220);
            this.tile_staffregister.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_staffregister.TabIndex = 22;
            this.tile_staffregister.Text = "Staff";
            this.tile_staffregister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_staffregister.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_staffregister.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_staffregister.UseSelectable = true;
            this.tile_staffregister.Click += new System.EventHandler(this.tile_staffregister_Click);
            // 
            // tile_sturegister
            // 
            this.tile_sturegister.ActiveControl = null;
            this.tile_sturegister.Location = new System.Drawing.Point(302, 341);
            this.tile_sturegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tile_sturegister.Name = "tile_sturegister";
            this.tile_sturegister.Size = new System.Drawing.Size(396, 220);
            this.tile_sturegister.Style = MetroFramework.MetroColorStyle.Silver;
            this.tile_sturegister.TabIndex = 23;
            this.tile_sturegister.Text = "Student";
            this.tile_sturegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile_sturegister.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tile_sturegister.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tile_sturegister.UseSelectable = true;
            this.tile_sturegister.Click += new System.EventHandler(this.tile_sturegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 905);
            this.Controls.Add(this.tile_staffregister);
            this.Controls.Add(this.tile_sturegister);
            this.Controls.Add(this.pictureBox_back);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Register_Load);
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
        private MetroFramework.Controls.MetroTile tile_staffregister;
        private MetroFramework.Controls.MetroTile tile_sturegister;
    }
}