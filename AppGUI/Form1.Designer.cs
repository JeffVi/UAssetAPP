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
            AbilityDataEnumLabel1 = new Label();
            AbilityDataEnumLabel2 = new Label();
            AbilityDataEnumLabel3 = new Label();
            AbilityDataEnumLabel4 = new Label();
            AbilityDataEnumLabel5 = new Label();
            AbilityDataPannel = new Panel();
            AbilityDataEnumBox5 = new ComboBox();
            AbilityDataEnumBox4 = new ComboBox();
            AbilityDataEnumBox3 = new ComboBox();
            AbilityDataEnumBox2 = new ComboBox();
            AbilityDataEnumBox1 = new ComboBox();
            SelectedItemLabel = new Label();
            LoadedDatabaseLabel = new Label();
            UpdateItemButton = new Button();
            UpdateLabel = new Label();
            menuStrip1.SuspendLayout();
            AbilityDataPannel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1053, 24);
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
            ItemNameDB.Location = new Point(310, 57);
            ItemNameDB.Name = "ItemNameDB";
            ItemNameDB.Size = new Size(244, 23);
            ItemNameDB.TabIndex = 1;
            ItemNameDB.SelectedIndexChanged += ItemNameDB_SelectedIndexChanged;
            // 
            // AbilityDataEnumLabel1
            // 
            AbilityDataEnumLabel1.AutoSize = true;
            AbilityDataEnumLabel1.Location = new Point(40, 49);
            AbilityDataEnumLabel1.Name = "AbilityDataEnumLabel1";
            AbilityDataEnumLabel1.Size = new Size(72, 15);
            AbilityDataEnumLabel1.TabIndex = 2;
            AbilityDataEnumLabel1.Text = "EnumLabel1";
            // 
            // AbilityDataEnumLabel2
            // 
            AbilityDataEnumLabel2.AutoSize = true;
            AbilityDataEnumLabel2.Location = new Point(40, 95);
            AbilityDataEnumLabel2.Name = "AbilityDataEnumLabel2";
            AbilityDataEnumLabel2.Size = new Size(72, 15);
            AbilityDataEnumLabel2.TabIndex = 3;
            AbilityDataEnumLabel2.Text = "EnumLabel2";
            // 
            // AbilityDataEnumLabel3
            // 
            AbilityDataEnumLabel3.AutoSize = true;
            AbilityDataEnumLabel3.Location = new Point(40, 141);
            AbilityDataEnumLabel3.Name = "AbilityDataEnumLabel3";
            AbilityDataEnumLabel3.Size = new Size(72, 15);
            AbilityDataEnumLabel3.TabIndex = 4;
            AbilityDataEnumLabel3.Text = "EnumLabel3";
            // 
            // AbilityDataEnumLabel4
            // 
            AbilityDataEnumLabel4.AutoSize = true;
            AbilityDataEnumLabel4.Location = new Point(40, 190);
            AbilityDataEnumLabel4.Name = "AbilityDataEnumLabel4";
            AbilityDataEnumLabel4.Size = new Size(72, 15);
            AbilityDataEnumLabel4.TabIndex = 5;
            AbilityDataEnumLabel4.Text = "EnumLabel4";
            // 
            // AbilityDataEnumLabel5
            // 
            AbilityDataEnumLabel5.AutoSize = true;
            AbilityDataEnumLabel5.Location = new Point(40, 239);
            AbilityDataEnumLabel5.Name = "AbilityDataEnumLabel5";
            AbilityDataEnumLabel5.Size = new Size(72, 15);
            AbilityDataEnumLabel5.TabIndex = 6;
            AbilityDataEnumLabel5.Text = "EnumLabel5";
            // 
            // AbilityDataPannel
            // 
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox5);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox4);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox3);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox2);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox1);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel1);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel5);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel2);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel4);
            AbilityDataPannel.Controls.Add(AbilityDataEnumLabel3);
            AbilityDataPannel.Location = new Point(34, 86);
            AbilityDataPannel.Name = "AbilityDataPannel";
            AbilityDataPannel.Size = new Size(929, 463);
            AbilityDataPannel.TabIndex = 7;
            // 
            // AbilityDataEnumBox5
            // 
            AbilityDataEnumBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox5.FormattingEnabled = true;
            AbilityDataEnumBox5.Location = new Point(200, 236);
            AbilityDataEnumBox5.Name = "AbilityDataEnumBox5";
            AbilityDataEnumBox5.Size = new Size(121, 23);
            AbilityDataEnumBox5.TabIndex = 11;
            // 
            // AbilityDataEnumBox4
            // 
            AbilityDataEnumBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox4.FormattingEnabled = true;
            AbilityDataEnumBox4.Location = new Point(200, 187);
            AbilityDataEnumBox4.Name = "AbilityDataEnumBox4";
            AbilityDataEnumBox4.Size = new Size(121, 23);
            AbilityDataEnumBox4.TabIndex = 10;
            // 
            // AbilityDataEnumBox3
            // 
            AbilityDataEnumBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox3.FormattingEnabled = true;
            AbilityDataEnumBox3.Location = new Point(200, 138);
            AbilityDataEnumBox3.Name = "AbilityDataEnumBox3";
            AbilityDataEnumBox3.Size = new Size(121, 23);
            AbilityDataEnumBox3.TabIndex = 9;
            // 
            // AbilityDataEnumBox2
            // 
            AbilityDataEnumBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox2.FormattingEnabled = true;
            AbilityDataEnumBox2.Location = new Point(200, 92);
            AbilityDataEnumBox2.Name = "AbilityDataEnumBox2";
            AbilityDataEnumBox2.Size = new Size(121, 23);
            AbilityDataEnumBox2.TabIndex = 8;
            // 
            // AbilityDataEnumBox1
            // 
            AbilityDataEnumBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox1.FormattingEnabled = true;
            AbilityDataEnumBox1.Location = new Point(200, 46);
            AbilityDataEnumBox1.Name = "AbilityDataEnumBox1";
            AbilityDataEnumBox1.Size = new Size(121, 23);
            AbilityDataEnumBox1.TabIndex = 7;
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Location = new Point(155, 60);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(78, 15);
            SelectedItemLabel.TabIndex = 8;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // LoadedDatabaseLabel
            // 
            LoadedDatabaseLabel.AutoSize = true;
            LoadedDatabaseLabel.Location = new Point(914, 60);
            LoadedDatabaseLabel.Name = "LoadedDatabaseLabel";
            LoadedDatabaseLabel.Size = new Size(63, 15);
            LoadedDatabaseLabel.TabIndex = 12;
            LoadedDatabaseLabel.Text = "Loaded db";
            // 
            // UpdateItemButton
            // 
            UpdateItemButton.Location = new Point(579, 56);
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
            UpdateLabel.Location = new Point(746, 60);
            UpdateLabel.Name = "UpdateLabel";
            UpdateLabel.Size = new Size(76, 15);
            UpdateLabel.TabIndex = 14;
            UpdateLabel.Text = "Update Label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 648);
            Controls.Add(UpdateLabel);
            Controls.Add(UpdateItemButton);
            Controls.Add(LoadedDatabaseLabel);
            Controls.Add(SelectedItemLabel);
            Controls.Add(AbilityDataPannel);
            Controls.Add(ItemNameDB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Octopath Traveler 2 UAsset Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            AbilityDataPannel.ResumeLayout(false);
            AbilityDataPannel.PerformLayout();
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
        private Label AbilityDataEnumLabel1;
        private Label AbilityDataEnumLabel2;
        private Label AbilityDataEnumLabel3;
        private Label AbilityDataEnumLabel4;
        private Label AbilityDataEnumLabel5;
        private Panel AbilityDataPannel;
        private ComboBox AbilityDataEnumBox1;
        private ComboBox AbilityDataEnumBox5;
        private ComboBox AbilityDataEnumBox4;
        private ComboBox AbilityDataEnumBox3;
        private ComboBox AbilityDataEnumBox2;
        private Label SelectedItemLabel;
        private Label LoadedDatabaseLabel;
        private Button UpdateItemButton;
        private Label UpdateLabel;
    }
}