namespace Music_Application
{
    partial class ucPlaylistBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPlaylistBox));
            this.titleLabel = new System.Windows.Forms.Label();
            this.playlistPic = new System.Windows.Forms.PictureBox();
            this.playBt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playlistPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBt)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(8, 174);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(31, 23);
            this.titleLabel.TabIndex = 24;
            this.titleLabel.Text = "---";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playlistPic
            // 
            this.playlistPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistPic.BackgroundImage")));
            this.playlistPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playlistPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistPic.Location = new System.Drawing.Point(12, 12);
            this.playlistPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playlistPic.Name = "playlistPic";
            this.playlistPic.Size = new System.Drawing.Size(156, 156);
            this.playlistPic.TabIndex = 0;
            this.playlistPic.TabStop = false;
            this.playlistPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // playBt
            // 
            this.playBt.BackgroundImage = global::Music_Application.Properties.Resources.wplay;
            this.playBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBt.ErrorImage = null;
            this.playBt.InitialImage = null;
            this.playBt.Location = new System.Drawing.Point(133, 198);
            this.playBt.Name = "playBt";
            this.playBt.Size = new System.Drawing.Size(35, 35);
            this.playBt.TabIndex = 26;
            this.playBt.TabStop = false;
            this.playBt.Click += new System.EventHandler(this.playBt_Click);
            // 
            // ucPlaylistBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.playBt);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.playlistPic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucPlaylistBox";
            this.Size = new System.Drawing.Size(181, 239);
            ((System.ComponentModel.ISupportInitialize)(this.playlistPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playBt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playlistPic;
        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox playBt;
    }
}
