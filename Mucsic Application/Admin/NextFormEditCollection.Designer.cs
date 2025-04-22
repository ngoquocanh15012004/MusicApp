namespace Music_Application.Admin
{
    partial class NextFormEditCollection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.playListLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVList = new System.Windows.Forms.DataGridView();
            this.DGVSearch = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeBt = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.submitBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // playListLabel
            // 
            this.playListLabel.AutoSize = true;
            this.playListLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playListLabel.ForeColor = System.Drawing.Color.White;
            this.playListLabel.Location = new System.Drawing.Point(15, 15);
            this.playListLabel.Name = "playListLabel";
            this.playListLabel.Size = new System.Drawing.Size(222, 24);
            this.playListLabel.TabIndex = 6;
            this.playListLabel.Text = "CHỈNH SỬA TUYỂN TẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Danh sách nhạc";
            // 
            // DGVList
            // 
            this.DGVList.AllowUserToResizeRows = false;
            this.DGVList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DGVList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVList.ColumnHeadersVisible = false;
            this.DGVList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVList.Location = new System.Drawing.Point(19, 117);
            this.DGVList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVList.Name = "DGVList";
            this.DGVList.ReadOnly = true;
            this.DGVList.RowHeadersVisible = false;
            this.DGVList.RowHeadersWidth = 51;
            this.DGVList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DGVList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGVList.RowTemplate.Height = 24;
            this.DGVList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVList.Size = new System.Drawing.Size(423, 290);
            this.DGVList.TabIndex = 37;
            // 
            // DGVSearch
            // 
            this.DGVSearch.AllowUserToResizeRows = false;
            this.DGVSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DGVSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.DGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSearch.ColumnHeadersVisible = false;
            this.DGVSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVSearch.Location = new System.Drawing.Point(475, 117);
            this.DGVSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVSearch.Name = "DGVSearch";
            this.DGVSearch.ReadOnly = true;
            this.DGVSearch.RowHeadersVisible = false;
            this.DGVSearch.RowHeadersWidth = 51;
            this.DGVSearch.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DGVSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVSearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGVSearch.RowTemplate.Height = 24;
            this.DGVSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSearch.Size = new System.Drawing.Size(423, 290);
            this.DGVSearch.TabIndex = 38;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchTextBox.Location = new System.Drawing.Point(475, 76);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(345, 22);
            this.searchTextBox.TabIndex = 39;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(826, 71);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(72, 30);
            this.searchButton.TabIndex = 40;
            this.searchButton.Text = "Tìm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // removeBt
            // 
            this.removeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBt.Location = new System.Drawing.Point(361, 422);
            this.removeBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBt.Name = "removeBt";
            this.removeBt.Size = new System.Drawing.Size(81, 31);
            this.removeBt.TabIndex = 41;
            this.removeBt.Text = "Xóa";
            this.removeBt.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(817, 422);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 31);
            this.addButton.TabIndex = 42;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // submitBt
            // 
            this.submitBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBt.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBt.Location = new System.Drawing.Point(797, 482);
            this.submitBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitBt.Name = "submitBt";
            this.submitBt.Size = new System.Drawing.Size(101, 36);
            this.submitBt.TabIndex = 43;
            this.submitBt.Text = "Submit";
            this.submitBt.UseVisualStyleBackColor = true;
            // 
            // NextFormEditCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Controls.Add(this.submitBt);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeBt);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.DGVSearch);
            this.Controls.Add(this.DGVList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playListLabel);
            this.Name = "NextFormEditCollection";
            this.Text = "NextFormEditCollection";
            ((System.ComponentModel.ISupportInitialize)(this.DGVList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playListLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVList;
        private System.Windows.Forms.DataGridView DGVSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button removeBt;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button submitBt;
    }
}