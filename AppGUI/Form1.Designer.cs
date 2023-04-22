namespace AppGUI
{
    partial class Form1
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
            OpenButton = new ToolStripMenuItem();
            SaveButton = new ToolStripMenuItem();
            SaveAsButton = new ToolStripMenuItem();
            CloseButton = new ToolStripMenuItem();
            ItemNameDB = new ComboBox();
            SelectedItemLabel = new Label();
            LoadedDatabaseLabel = new Label();
            UpdateItemButton = new Button();
            UpdateLabel = new Label();
            UCAbilityData = new UserControlPanels.AbilityDataUC();
            UCGameText = new UserControlPanels.GameTextUC();
            UCJobData = new UserControlPanels.JobDataUC();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1284, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenButton, SaveButton, SaveAsButton, CloseButton });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // OpenButton
            // 
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(114, 22);
            OpenButton.Text = "Open";
            OpenButton.Click += openToolStripMenuItem_Click;
            // 
            // SaveButton
            // 
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(114, 22);
            SaveButton.Text = "Save";
            SaveButton.Click += saveToolStripMenuItem_Click;
            // 
            // SaveAsButton
            // 
            SaveAsButton.Name = "SaveAsButton";
            SaveAsButton.Size = new Size(114, 22);
            SaveAsButton.Text = "Save As";
            SaveAsButton.Click += saveAsToolStripMenuItem_Click;
            // 
            // CloseButton
            // 
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(114, 22);
            CloseButton.Text = "Close";
            CloseButton.Click += closeToolStripMenuItem_Click;
            // 
            // ItemNameDB
            // 
            ItemNameDB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ItemNameDB.AutoCompleteSource = AutoCompleteSource.ListItems;
            ItemNameDB.FormattingEnabled = true;
            ItemNameDB.Location = new Point(152, 57);
            ItemNameDB.Name = "ItemNameDB";
            ItemNameDB.Size = new Size(244, 23);
            ItemNameDB.TabIndex = 1;
            ItemNameDB.SelectedIndexChanged += ItemNameDB_SelectedIndexChanged;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Location = new Point(12, 60);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(78, 15);
            SelectedItemLabel.TabIndex = 8;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // LoadedDatabaseLabel
            // 
            LoadedDatabaseLabel.AutoSize = true;
            LoadedDatabaseLabel.Location = new Point(152, 24);
            LoadedDatabaseLabel.Name = "LoadedDatabaseLabel";
            LoadedDatabaseLabel.Size = new Size(63, 15);
            LoadedDatabaseLabel.TabIndex = 12;
            LoadedDatabaseLabel.Text = "Loaded db";
            // 
            // UpdateItemButton
            // 
            UpdateItemButton.Location = new Point(402, 56);
            UpdateItemButton.Name = "UpdateItemButton";
            UpdateItemButton.Size = new Size(135, 23);
            UpdateItemButton.TabIndex = 13;
            UpdateItemButton.Text = "Update Item";
            UpdateItemButton.UseVisualStyleBackColor = true;
            UpdateItemButton.Click += UpdateItemButton_Click;
            // 
            // UpdateLabel
            // 
            UpdateLabel.AutoSize = true;
            UpdateLabel.Location = new Point(543, 60);
            UpdateLabel.Name = "UpdateLabel";
            UpdateLabel.Size = new Size(76, 15);
            UpdateLabel.TabIndex = 14;
            UpdateLabel.Text = "Update Label";
            // 
            // UCAbilityData
            // 
            UCAbilityData.Location = new Point(30, 90);
            UCAbilityData.Name = "UCAbilityData";
            UCAbilityData.Size = new Size(1200, 625);
            UCAbilityData.TabIndex = 17;
            // 
            // UCGameText
            // 
            UCGameText.Location = new Point(30, 90);
            UCGameText.Name = "UCGameText";
            UCGameText.Size = new Size(1200, 625);
            UCGameText.TabIndex = 18;
            // 
            // UCJobData
            // 
            UCJobData.Location = new Point(30, 90);
            UCJobData.Name = "UCJobData";
            UCJobData.Size = new Size(1200, 625);
            UCJobData.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 711);
            Controls.Add(UCAbilityData);
            Controls.Add(UCGameText);
            Controls.Add(UCJobData);
            Controls.Add(UpdateLabel);
            Controls.Add(UpdateItemButton);
            Controls.Add(LoadedDatabaseLabel);
            Controls.Add(SelectedItemLabel);
            Controls.Add(ItemNameDB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Octopath Traveler 2 UAsset Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem OpenButton;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem SaveAsButton;
        private ToolStripMenuItem CloseButton;
        private ComboBox ItemNameDB;
        private Label SelectedItemLabel;
        private Label LoadedDatabaseLabel;
        private Button UpdateItemButton;
        private Label UpdateLabel;
        private UserControlPanels.AbilityDataUC UCAbilityData;
        private UserControlPanels.GameTextUC UCGameText;
        private UserControlPanels.JobDataUC UCJobData;
    }
}