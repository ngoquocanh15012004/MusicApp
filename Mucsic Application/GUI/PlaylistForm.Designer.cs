namespace Music_Application
{
    partial class PlaylistForm
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
            this.listPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playlistName = new System.Windows.Forms.Label();
            this.playBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Location = new System.Drawing.Point(13, 90);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(1050, 500);
            this.listPanel.TabIndex = 10;
            // 
            // playlistName
            // 
            this.playlistName.AutoSize = true;
            this.playlistName.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playlistName.Location = new System.Drawing.Point(12, 14);
            this.playlistName.Name = "playlistName";
            this.playlistName.Size = new System.Drawing.Size(158, 58);
            this.playlistName.TabIndex = 12;
            this.playlistName.Text = "label1";
            // 
            // playBt
            // 
            this.playBt.BackgroundImage = global::Music_Application.Properties.Resources.wplay;
            this.playBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playBt.FlatAppearance.BorderSize = 0;
            this.playBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.playBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.playBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBt.Location = new System.Drawing.Point(1013, 19);
            this.playBt.Name = "playBt";
            this.playBt.Size = new System.Drawing.Size(50, 50);
            this.playBt.TabIndex = 13;
            this.playBt.UseVisualStyleBackColor = true;
            this.playBt.Click += new System.EventHandler(this.playBt_Click);
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1077, 602);
            this.Controls.Add(this.playBt);
            this.Controls.Add(this.playlistName);
            this.Controls.Add(this.listPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlaylistForm";
            this.Text = "Danh sách phát";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel listPanel;
        private System.Windows.Forms.Label playlistName;
        private System.Windows.Forms.Button playBt;
    }
}