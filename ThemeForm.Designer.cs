namespace ALTTP_Helper_CSharp
{
    partial class ThemeForm
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
            themePreviewGroup = new GroupBox();
            pictureBox1 = new PictureBox();
            themeListBox = new ListBox();
            cancelThemeBtn = new Button();
            confirmThemeBtn = new Button();
            themePreviewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // themePreviewGroup
            // 
            themePreviewGroup.Controls.Add(pictureBox1);
            themePreviewGroup.Controls.Add(themeListBox);
            themePreviewGroup.Location = new Point(12, 12);
            themePreviewGroup.Name = "themePreviewGroup";
            themePreviewGroup.Size = new Size(476, 234);
            themePreviewGroup.TabIndex = 0;
            themePreviewGroup.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(162, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // themeListBox
            // 
            themeListBox.BorderStyle = BorderStyle.FixedSingle;
            themeListBox.FormattingEnabled = true;
            themeListBox.IntegralHeight = false;
            themeListBox.ItemHeight = 15;
            themeListBox.Location = new Point(6, 22);
            themeListBox.Name = "themeListBox";
            themeListBox.Size = new Size(150, 200);
            themeListBox.Sorted = true;
            themeListBox.TabIndex = 0;
            // 
            // cancelThemeBtn
            // 
            cancelThemeBtn.Location = new Point(388, 252);
            cancelThemeBtn.Name = "cancelThemeBtn";
            cancelThemeBtn.Size = new Size(100, 40);
            cancelThemeBtn.TabIndex = 1;
            cancelThemeBtn.Text = "Cancel";
            cancelThemeBtn.UseVisualStyleBackColor = true;
            cancelThemeBtn.Click += cancelThemeBtn_Click;
            // 
            // confirmThemeBtn
            // 
            confirmThemeBtn.Location = new Point(282, 252);
            confirmThemeBtn.Name = "confirmThemeBtn";
            confirmThemeBtn.Size = new Size(100, 40);
            confirmThemeBtn.TabIndex = 2;
            confirmThemeBtn.Text = "OK";
            confirmThemeBtn.UseVisualStyleBackColor = true;
            confirmThemeBtn.Click += confirmThemeBtn_Click;
            // 
            // ThemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(confirmThemeBtn);
            Controls.Add(cancelThemeBtn);
            Controls.Add(themePreviewGroup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemeForm";
            Text = "ThemeForm";
            Load += ThemeForm_Load;
            themePreviewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox themePreviewGroup;
        private Button cancelThemeBtn;
        private Button confirmThemeBtn;
        private ListBox themeListBox;
        private PictureBox pictureBox1;
    }
}