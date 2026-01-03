namespace ALTTP_Helper_CSharp
{
    partial class MainTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            resetTrackerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionToolStripMenuItem = new ToolStripMenuItem();
            liveUpdatingToolStripMenuItem = new ToolStripMenuItem();
            manualUpdatingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            themeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            howItWorksToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            gitHubPageToolStripMenuItem = new ToolStripMenuItem();
            tabGroupBox = new GroupBox();
            mapTrackRadio = new RadioButton();
            manualTrackRadio = new RadioButton();
            liveTrackRadio = new RadioButton();
            worldSelectionGroupbox = new GroupBox();
            worldGroupLabel = new Label();
            darkWorldMapRadio = new RadioButton();
            lightWorldMapRadio = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            searchShop = new RadioButton();
            menuStrip1.SuspendLayout();
            tabGroupBox.SuspendLayout();
            worldSelectionGroupbox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionToolStripMenuItem, helpToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "mainTrackerMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator2, resetTrackerToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(183, 22);
            openToolStripMenuItem.Text = "&Open Spoiler Log . . .";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(180, 6);
            // 
            // resetTrackerToolStripMenuItem
            // 
            resetTrackerToolStripMenuItem.Name = "resetTrackerToolStripMenuItem";
            resetTrackerToolStripMenuItem.Size = new Size(183, 22);
            resetTrackerToolStripMenuItem.Text = "&Reset Tracker";
            resetTrackerToolStripMenuItem.Click += resetTrackerToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(183, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { liveUpdatingToolStripMenuItem, manualUpdatingToolStripMenuItem, toolStripSeparator1, themeToolStripMenuItem });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(56, 20);
            optionToolStripMenuItem.Text = "O&ption";
            // 
            // liveUpdatingToolStripMenuItem
            // 
            liveUpdatingToolStripMenuItem.Checked = true;
            liveUpdatingToolStripMenuItem.CheckState = CheckState.Checked;
            liveUpdatingToolStripMenuItem.Name = "liveUpdatingToolStripMenuItem";
            liveUpdatingToolStripMenuItem.Size = new Size(166, 22);
            liveUpdatingToolStripMenuItem.Text = "&Live Updating";
            liveUpdatingToolStripMenuItem.Click += liveUpdatingToolStripMenuItem_Click;
            // 
            // manualUpdatingToolStripMenuItem
            // 
            manualUpdatingToolStripMenuItem.Checked = true;
            manualUpdatingToolStripMenuItem.CheckState = CheckState.Checked;
            manualUpdatingToolStripMenuItem.Name = "manualUpdatingToolStripMenuItem";
            manualUpdatingToolStripMenuItem.Size = new Size(166, 22);
            manualUpdatingToolStripMenuItem.Text = "&Manual Updating";
            manualUpdatingToolStripMenuItem.Click += manualUpdatingToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(163, 6);
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(166, 22);
            themeToolStripMenuItem.Text = "&Theme. . . ";
            themeToolStripMenuItem.Click += themeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, howItWorksToolStripMenuItem, toolStripSeparator3, gitHubPageToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(44, 20);
            helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(145, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // howItWorksToolStripMenuItem
            // 
            howItWorksToolStripMenuItem.Name = "howItWorksToolStripMenuItem";
            howItWorksToolStripMenuItem.Size = new Size(145, 22);
            howItWorksToolStripMenuItem.Text = "How it &Works";
            howItWorksToolStripMenuItem.Click += howItWorksToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(142, 6);
            // 
            // gitHubPageToolStripMenuItem
            // 
            gitHubPageToolStripMenuItem.Name = "gitHubPageToolStripMenuItem";
            gitHubPageToolStripMenuItem.Size = new Size(145, 22);
            gitHubPageToolStripMenuItem.Text = "&GitHub Page";
            gitHubPageToolStripMenuItem.Click += gitHubPageToolStripMenuItem_Click;
            // 
            // tabGroupBox
            // 
            tabGroupBox.Controls.Add(label1);
            tabGroupBox.Controls.Add(mapTrackRadio);
            tabGroupBox.Controls.Add(manualTrackRadio);
            tabGroupBox.Controls.Add(liveTrackRadio);
            tabGroupBox.Location = new Point(12, 27);
            tabGroupBox.Name = "tabGroupBox";
            tabGroupBox.Size = new Size(264, 68);
            tabGroupBox.TabIndex = 1;
            tabGroupBox.TabStop = false;
            // 
            // mapTrackRadio
            // 
            mapTrackRadio.Appearance = Appearance.Button;
            mapTrackRadio.Font = new Font("Segoe UI", 12F);
            mapTrackRadio.Location = new Point(178, 22);
            mapTrackRadio.Name = "mapTrackRadio";
            mapTrackRadio.Size = new Size(80, 40);
            mapTrackRadio.TabIndex = 2;
            mapTrackRadio.Text = "Map";
            mapTrackRadio.TextAlign = ContentAlignment.MiddleCenter;
            mapTrackRadio.UseVisualStyleBackColor = true;
            mapTrackRadio.CheckedChanged += mapTrackRadio_CheckedChanged;
            // 
            // manualTrackRadio
            // 
            manualTrackRadio.Appearance = Appearance.Button;
            manualTrackRadio.Font = new Font("Segoe UI", 12F);
            manualTrackRadio.Location = new Point(92, 22);
            manualTrackRadio.Name = "manualTrackRadio";
            manualTrackRadio.Size = new Size(80, 40);
            manualTrackRadio.TabIndex = 1;
            manualTrackRadio.Text = "Manual";
            manualTrackRadio.TextAlign = ContentAlignment.MiddleCenter;
            manualTrackRadio.UseVisualStyleBackColor = true;
            manualTrackRadio.CheckedChanged += manualTrackRadio_CheckedChanged;
            // 
            // liveTrackRadio
            // 
            liveTrackRadio.Appearance = Appearance.Button;
            liveTrackRadio.Font = new Font("Segoe UI", 12F);
            liveTrackRadio.Location = new Point(6, 22);
            liveTrackRadio.Name = "liveTrackRadio";
            liveTrackRadio.Size = new Size(80, 40);
            liveTrackRadio.TabIndex = 0;
            liveTrackRadio.Text = "Live";
            liveTrackRadio.TextAlign = ContentAlignment.MiddleCenter;
            liveTrackRadio.UseVisualStyleBackColor = true;
            liveTrackRadio.CheckedChanged += liveTrackRadio_CheckedChanged;
            // 
            // worldSelectionGroupbox
            // 
            worldSelectionGroupbox.Controls.Add(worldGroupLabel);
            worldSelectionGroupbox.Controls.Add(darkWorldMapRadio);
            worldSelectionGroupbox.Controls.Add(lightWorldMapRadio);
            worldSelectionGroupbox.Location = new Point(282, 27);
            worldSelectionGroupbox.Name = "worldSelectionGroupbox";
            worldSelectionGroupbox.Size = new Size(178, 68);
            worldSelectionGroupbox.TabIndex = 3;
            worldSelectionGroupbox.TabStop = false;
            worldSelectionGroupbox.Visible = false;
            // 
            // worldGroupLabel
            // 
            worldGroupLabel.AutoSize = true;
            worldGroupLabel.Location = new Point(46, 0);
            worldGroupLabel.Name = "worldGroupLabel";
            worldGroupLabel.Size = new Size(82, 15);
            worldGroupLabel.TabIndex = 4;
            worldGroupLabel.Text = "Choose World";
            worldGroupLabel.Visible = false;
            // 
            // darkWorldMapRadio
            // 
            darkWorldMapRadio.Appearance = Appearance.Button;
            darkWorldMapRadio.Font = new Font("Segoe UI", 12F);
            darkWorldMapRadio.Location = new Point(92, 22);
            darkWorldMapRadio.Name = "darkWorldMapRadio";
            darkWorldMapRadio.Size = new Size(80, 40);
            darkWorldMapRadio.TabIndex = 1;
            darkWorldMapRadio.Text = "Dark";
            darkWorldMapRadio.TextAlign = ContentAlignment.MiddleCenter;
            darkWorldMapRadio.UseVisualStyleBackColor = true;
            // 
            // lightWorldMapRadio
            // 
            lightWorldMapRadio.Appearance = Appearance.Button;
            lightWorldMapRadio.Font = new Font("Segoe UI", 12F);
            lightWorldMapRadio.Location = new Point(6, 22);
            lightWorldMapRadio.Name = "lightWorldMapRadio";
            lightWorldMapRadio.Size = new Size(80, 40);
            lightWorldMapRadio.TabIndex = 0;
            lightWorldMapRadio.Text = "Light";
            lightWorldMapRadio.TextAlign = ContentAlignment.MiddleCenter;
            lightWorldMapRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 5;
            label1.Text = "Tracking Method";
            label1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(searchShop);
            groupBox1.Location = new Point(466, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 68);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Search For:";
            label2.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(92, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 40);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Dark";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // searchShop
            // 
            searchShop.Appearance = Appearance.Button;
            searchShop.Font = new Font("Segoe UI", 12F);
            searchShop.Location = new Point(6, 22);
            searchShop.Name = "searchShop";
            searchShop.Size = new Size(80, 40);
            searchShop.TabIndex = 0;
            searchShop.Text = "Shop";
            searchShop.TextAlign = ContentAlignment.MiddleCenter;
            searchShop.UseVisualStyleBackColor = true;
            // 
            // MainTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(worldSelectionGroupbox);
            Controls.Add(tabGroupBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "MainTracker";
            Load += MainTracker_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabGroupBox.ResumeLayout(false);
            tabGroupBox.PerformLayout();
            worldSelectionGroupbox.ResumeLayout(false);
            worldSelectionGroupbox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem liveUpdatingToolStripMenuItem;
        private ToolStripMenuItem manualUpdatingToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem resetTrackerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem howItWorksToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem gitHubPageToolStripMenuItem;
        private GroupBox tabGroupBox;
        private RadioButton liveTrackRadio;
        private RadioButton manualTrackRadio;
        private RadioButton mapTrackRadio;
        private GroupBox worldSelectionGroupbox;
        private RadioButton darkWorldMapRadio;
        private RadioButton lightWorldMapRadio;
        private Label worldGroupLabel;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton searchShop;
    }
}
