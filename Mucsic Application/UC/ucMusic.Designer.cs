namespace Music_Application
{
    partial class ucMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMusic));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queueBt = new System.Windows.Forms.PictureBox();
            this.playlistBt = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.viewLabel = new System.Windows.Forms.Label();
            this.playBt = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.queueBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Có Không Giữ Mất Đừng Tìm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(376, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trúc Nhân";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // queueBt
            // 
            this.queueBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("queueBt.BackgroundImage")));
            this.queueBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.queueBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queueBt.Location = new System.Drawing.Point(968, 14);
            this.queueBt.Margin = new System.Windows.Forms.Padding(2);
            this.queueBt.Name = "queueBt";
            this.queueBt.Size = new System.Drawing.Size(24, 24);
            this.queueBt.TabIndex = 5;
            this.queueBt.TabStop = false;
            this.queueBt.Click += new System.EventHandler(this.queueBt_Click);
            // 
            // playlistBt
            // 
            this.playlistBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistBt.BackgroundImage")));
            this.playlistBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playlistBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistBt.Location = new System.Drawing.Point(1003, 14);
            this.playlistBt.Margin = new System.Windows.Forms.Padding(2);
            this.playlistBt.Name = "playlistBt";
            this.playlistBt.Size = new System.Drawing.Size(24, 24);
            this.playlistBt.TabIndex = 4;
            this.playlistBt.TabStop = false;
            this.playlistBt.Click += new System.EventHandler(this.playlistBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(17, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(693, 15);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 19);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.ForeColor = System.Drawing.Color.White;
            this.viewLabel.Location = new System.Drawing.Point(714, 18);
            this.viewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(35, 14);
            this.viewLabel.TabIndex = 7;
            this.viewLabel.Text = "1000";
            // 
            // playBt
            // 
            this.playBt.ActiveImage = null;
            this.playBt.AllowAnimations = true;
            this.playBt.AllowBuffering = false;
            this.playBt.AllowToggling = false;
            this.playBt.AllowZooming = true;
            this.playBt.AllowZoomingOnFocus = false;
            this.playBt.BackColor = System.Drawing.Color.Transparent;
            this.playBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.playBt.ErrorImage = ((System.Drawing.Image)(resources.GetObject("playBt.ErrorImage")));
            this.playBt.FadeWhenInactive = false;
            this.playBt.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.playBt.ForeColor = System.Drawing.Color.Transparent;
            this.playBt.Image = ((System.Drawing.Image)(resources.GetObject("playBt.Image")));
            this.playBt.ImageActive = null;
            this.playBt.ImageLocation = null;
            this.playBt.ImageMargin = 0;
            this.playBt.ImageSize = new System.Drawing.Size(23, 23);
            this.playBt.ImageZoomSize = new System.Drawing.Size(24, 24);
            this.playBt.InitialImage = ((System.Drawing.Image)(resources.GetObject("playBt.InitialImage")));
            this.playBt.Location = new System.Drawing.Point(931, 14);
            this.playBt.Margin = new System.Windows.Forms.Padding(2);
            this.playBt.Name = "playBt";
            this.playBt.Rotation = 0;
            this.playBt.ShowActiveImage = true;
            this.playBt.ShowCursorChanges = true;
            this.playBt.ShowImageBorders = true;
            this.playBt.ShowSizeMarkers = false;
            this.playBt.Size = new System.Drawing.Size(24, 24);
            this.playBt.TabIndex = 20;
            this.playBt.ToolTipText = "";
            this.playBt.WaitOnLoad = false;
            this.playBt.Zoom = 0;
            this.playBt.ZoomSpeed = 10;
            this.playBt.Click += new System.EventHandler(this.playBt_Click);
            // 
            // ucMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.playBt);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.queueBt);
            this.Controls.Add(this.playlistBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMusic";
            this.Size = new System.Drawing.Size(1045, 49);
            ((System.ComponentModel.ISupportInitialize)(this.queueBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistBt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox playlistBt;
        private System.Windows.Forms.PictureBox queueBt;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label viewLabel;
        public Bunifu.UI.WinForms.BunifuImageButton playBt;
    }
}
