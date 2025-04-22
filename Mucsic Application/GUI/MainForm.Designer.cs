namespace Music_Application
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.homePanel = new System.Windows.Forms.Panel();
            this.panelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.currentPanelName = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.searchtextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.searchButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.minimizeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.closeButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.leftPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.adminLabel = new System.Windows.Forms.Label();
            this.playlistPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.signOutLabel = new System.Windows.Forms.Label();
            this.avatar = new Bunifu.UI.WinForms.BunifuShapes();
            this.addPlaylistButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Player = new Music_Application.UC.ucPlayer();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = this.panelHeader;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.homePanel.Location = new System.Drawing.Point(202, 42);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1077, 602);
            this.homePanel.TabIndex = 11;
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.BorderColor = System.Drawing.Color.Transparent;
            this.panelHeader.BorderRadius = 3;
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.currentPanelName);
            this.panelHeader.Controls.Add(this.homeButton);
            this.panelHeader.Controls.Add(this.searchtextBox);
            this.panelHeader.Controls.Add(this.searchButton);
            this.panelHeader.Controls.Add(this.minimizeButton);
            this.panelHeader.Controls.Add(this.closeButton);
            this.panelHeader.Location = new System.Drawing.Point(202, 1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShowBorders = true;
            this.panelHeader.Size = new System.Drawing.Size(1079, 42);
            this.panelHeader.TabIndex = 1;
            // 
            // currentPanelName
            // 
            this.currentPanelName.AutoSize = true;
            this.currentPanelName.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.currentPanelName.ForeColor = System.Drawing.Color.White;
            this.currentPanelName.Location = new System.Drawing.Point(607, 8);
            this.currentPanelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentPanelName.Name = "currentPanelName";
            this.currentPanelName.Size = new System.Drawing.Size(99, 25);
            this.currentPanelName.TabIndex = 1;
            this.currentPanelName.Text = "Mặc định";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.Transparent;
            this.homeButton.Location = new System.Drawing.Point(23, 6);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(27, 29);
            this.homeButton.TabIndex = 19;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.AcceptsReturn = false;
            this.searchtextBox.AcceptsTab = false;
            this.searchtextBox.AnimationSpeed = 200;
            this.searchtextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchtextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchtextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchtextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchtextBox.BackgroundImage")));
            this.searchtextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchtextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchtextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchtextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchtextBox.BorderRadius = 30;
            this.searchtextBox.BorderThickness = 1;
            this.searchtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchtextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtextBox.DefaultFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.DefaultText = "";
            this.searchtextBox.FillColor = System.Drawing.Color.DimGray;
            this.searchtextBox.ForeColor = System.Drawing.Color.White;
            this.searchtextBox.HideSelection = true;
            this.searchtextBox.IconLeft = null;
            this.searchtextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtextBox.IconPadding = 10;
            this.searchtextBox.IconRight = null;
            this.searchtextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtextBox.Lines = new string[0];
            this.searchtextBox.Location = new System.Drawing.Point(74, 3);
            this.searchtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchtextBox.MaxLength = 32767;
            this.searchtextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchtextBox.Modified = false;
            this.searchtextBox.Multiline = false;
            this.searchtextBox.Name = "searchtextBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchtextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchtextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchtextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.DimGray;
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchtextBox.OnIdleState = stateProperties8;
            this.searchtextBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchtextBox.PasswordChar = '\0';
            this.searchtextBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.searchtextBox.PlaceholderText = "Tìm kiếm ...";
            this.searchtextBox.ReadOnly = false;
            this.searchtextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchtextBox.SelectedText = "";
            this.searchtextBox.SelectionLength = 0;
            this.searchtextBox.SelectionStart = 0;
            this.searchtextBox.ShortcutsEnabled = true;
            this.searchtextBox.Size = new System.Drawing.Size(378, 37);
            this.searchtextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchtextBox.TabIndex = 9;
            this.searchtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchtextBox.TextMarginBottom = 0;
            this.searchtextBox.TextMarginLeft = 3;
            this.searchtextBox.TextMarginTop = 0;
            this.searchtextBox.TextPlaceholder = "Tìm kiếm ...";
            this.searchtextBox.UseSystemPasswordChar = false;
            this.searchtextBox.WordWrap = true;
            this.searchtextBox.Click += new System.EventHandler(this.searchtextBox_Click);
            // 
            // searchButton
            // 
            this.searchButton.ActiveImage = null;
            this.searchButton.AllowAnimations = true;
            this.searchButton.AllowBuffering = false;
            this.searchButton.AllowToggling = false;
            this.searchButton.AllowZooming = true;
            this.searchButton.AllowZoomingOnFocus = false;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("searchButton.ErrorImage")));
            this.searchButton.FadeWhenInactive = false;
            this.searchButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageActive = null;
            this.searchButton.ImageLocation = null;
            this.searchButton.ImageMargin = 0;
            this.searchButton.ImageSize = new System.Drawing.Size(31, 31);
            this.searchButton.ImageZoomSize = new System.Drawing.Size(32, 32);
            this.searchButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchButton.InitialImage")));
            this.searchButton.Location = new System.Drawing.Point(458, 6);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Rotation = 0;
            this.searchButton.ShowActiveImage = true;
            this.searchButton.ShowCursorChanges = true;
            this.searchButton.ShowImageBorders = true;
            this.searchButton.ShowSizeMarkers = false;
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.TabIndex = 8;
            this.searchButton.ToolTipText = "";
            this.searchButton.WaitOnLoad = false;
            this.searchButton.Zoom = 0;
            this.searchButton.ZoomSpeed = 10;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.ActiveImage = null;
            this.minimizeButton.AllowAnimations = true;
            this.minimizeButton.AllowBuffering = false;
            this.minimizeButton.AllowToggling = false;
            this.minimizeButton.AllowZooming = true;
            this.minimizeButton.AllowZoomingOnFocus = false;
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minimizeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.ErrorImage")));
            this.minimizeButton.FadeWhenInactive = false;
            this.minimizeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.ImageLocation = null;
            this.minimizeButton.ImageMargin = 0;
            this.minimizeButton.ImageSize = new System.Drawing.Size(14, 15);
            this.minimizeButton.ImageZoomSize = new System.Drawing.Size(15, 16);
            this.minimizeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.InitialImage")));
            this.minimizeButton.Location = new System.Drawing.Point(1028, 8);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Rotation = 0;
            this.minimizeButton.ShowActiveImage = true;
            this.minimizeButton.ShowCursorChanges = true;
            this.minimizeButton.ShowImageBorders = true;
            this.minimizeButton.ShowSizeMarkers = false;
            this.minimizeButton.Size = new System.Drawing.Size(15, 16);
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.ToolTipText = "";
            this.minimizeButton.WaitOnLoad = false;
            this.minimizeButton.Zoom = 0;
            this.minimizeButton.ZoomSpeed = 10;
            // 
            // closeButton
            // 
            this.closeButton.ActiveImage = null;
            this.closeButton.AllowAnimations = true;
            this.closeButton.AllowBuffering = false;
            this.closeButton.AllowToggling = false;
            this.closeButton.AllowZooming = true;
            this.closeButton.AllowZoomingOnFocus = false;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeButton.ErrorImage")));
            this.closeButton.FadeWhenInactive = false;
            this.closeButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.ImageLocation = null;
            this.closeButton.ImageMargin = 0;
            this.closeButton.ImageSize = new System.Drawing.Size(12, 13);
            this.closeButton.ImageZoomSize = new System.Drawing.Size(13, 14);
            this.closeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("closeButton.InitialImage")));
            this.closeButton.Location = new System.Drawing.Point(1053, 10);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Rotation = 0;
            this.closeButton.ShowActiveImage = true;
            this.closeButton.ShowCursorChanges = true;
            this.closeButton.ShowImageBorders = true;
            this.closeButton.ShowSizeMarkers = false;
            this.closeButton.Size = new System.Drawing.Size(13, 14);
            this.closeButton.TabIndex = 6;
            this.closeButton.ToolTipText = "";
            this.closeButton.WaitOnLoad = false;
            this.closeButton.Zoom = 0;
            this.closeButton.ZoomSpeed = 10;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.leftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftPanel.BackgroundImage")));
            this.leftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftPanel.BorderColor = System.Drawing.Color.Transparent;
            this.leftPanel.BorderRadius = 3;
            this.leftPanel.BorderThickness = 1;
            this.leftPanel.Controls.Add(this.usernameLabel);
            this.leftPanel.Controls.Add(this.adminLabel);
            this.leftPanel.Controls.Add(this.playlistPanel);
            this.leftPanel.Controls.Add(this.signOutLabel);
            this.leftPanel.Controls.Add(this.avatar);
            this.leftPanel.Controls.Add(this.addPlaylistButton);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Location = new System.Drawing.Point(-2, 1);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.ShowBorders = true;
            this.leftPanel.Size = new System.Drawing.Size(207, 718);
            this.leftPanel.TabIndex = 0;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.Transparent;
            this.adminLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Italic);
            this.adminLabel.ForeColor = System.Drawing.Color.White;
            this.adminLabel.Location = new System.Drawing.Point(152, 619);
            this.adminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(48, 19);
            this.adminLabel.TabIndex = 13;
            this.adminLabel.Text = "Admin";
            this.adminLabel.Visible = false;
            this.adminLabel.Click += new System.EventHandler(this.adminLabel_Click);
            // 
            // playlistPanel
            // 
            this.playlistPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.playlistPanel.Location = new System.Drawing.Point(2, 99);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(200, 464);
            this.playlistPanel.TabIndex = 0;
            // 
            // signOutLabel
            // 
            this.signOutLabel.AutoSize = true;
            this.signOutLabel.BackColor = System.Drawing.Color.Transparent;
            this.signOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Italic);
            this.signOutLabel.ForeColor = System.Drawing.Color.White;
            this.signOutLabel.Location = new System.Drawing.Point(6, 619);
            this.signOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(70, 19);
            this.signOutLabel.TabIndex = 12;
            this.signOutLabel.Text = "Đăng xuất";
            this.signOutLabel.Click += new System.EventHandler(this.signOutLabel_Click);
            // 
            // avatar
            // 
            this.avatar.Angle = 0F;
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avatar.BackgroundImage")));
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatar.BorderColor = System.Drawing.Color.Silver;
            this.avatar.BorderThickness = 2;
            this.avatar.FillColor = System.Drawing.Color.Transparent;
            this.avatar.FillShape = true;
            this.avatar.Location = new System.Drawing.Point(10, 576);
            this.avatar.Margin = new System.Windows.Forms.Padding(2);
            this.avatar.Name = "avatar";
            this.avatar.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.avatar.Sides = 5;
            this.avatar.Size = new System.Drawing.Size(38, 38);
            this.avatar.TabIndex = 11;
            this.avatar.Text = "bunifuShapes1";
            // 
            // addPlaylistButton
            // 
            this.addPlaylistButton.BackColor = System.Drawing.Color.Transparent;
            this.addPlaylistButton.BackgroundImage = global::Music_Application.Properties.Resources.icons8_plus_150;
            this.addPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPlaylistButton.FlatAppearance.BorderSize = 0;
            this.addPlaylistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addPlaylistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlaylistButton.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.addPlaylistButton.Location = new System.Drawing.Point(166, 65);
            this.addPlaylistButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPlaylistButton.Name = "addPlaylistButton";
            this.addPlaylistButton.Size = new System.Drawing.Size(24, 24);
            this.addPlaylistButton.TabIndex = 10;
            this.addPlaylistButton.UseVisualStyleBackColor = false;
            this.addPlaylistButton.Click += new System.EventHandler(this.addPlaylistButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(30, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "TuneTastic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thư viện";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Player.Location = new System.Drawing.Point(-2, 643);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(1283, 76);
            this.Player.TabIndex = 13;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(53, 585);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(48, 23);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.leftPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel leftPanel;
        private Bunifu.UI.WinForms.BunifuPanel panelHeader;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuImageButton minimizeButton;
        private Bunifu.UI.WinForms.BunifuImageButton closeButton;
        private Bunifu.UI.WinForms.BunifuImageButton searchButton;
        private Bunifu.UI.WinForms.BunifuTextBox searchtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addPlaylistButton;
        private System.Windows.Forms.Label currentPanelName;
        private System.Windows.Forms.Panel homePanel;
        private Bunifu.UI.WinForms.BunifuShapes avatar;
        private System.Windows.Forms.Label signOutLabel;
        private System.Windows.Forms.FlowLayoutPanel playlistPanel;
        private UC.ucPlayer Player;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}

