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
            EnumLabel1 = new Label();
            EnumLabel2 = new Label();
            EnumLabel3 = new Label();
            EnumLabel4 = new Label();
            EnumLabel5 = new Label();
            AbilityDataPannel = new Panel();
            AbilityDataEnumBox5 = new ComboBox();
            AbilityDataEnumBox4 = new ComboBox();
            AbilityDataEnumBox3 = new ComboBox();
            AbilityDataEnumBox2 = new ComboBox();
            AbilityDataEnumBox1 = new ComboBox();
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
            ItemNameDB.Location = new Point(239, 57);
            ItemNameDB.Name = "ItemNameDB";
            ItemNameDB.Size = new Size(244, 23);
            ItemNameDB.TabIndex = 1;
            ItemNameDB.SelectedIndexChanged += ItemNameDB_SelectedIndexChanged;
            // 
            // EnumLabel1
            // 
            EnumLabel1.AutoSize = true;
            EnumLabel1.Location = new Point(40, 49);
            EnumLabel1.Name = "EnumLabel1";
            EnumLabel1.Size = new Size(72, 15);
            EnumLabel1.TabIndex = 2;
            EnumLabel1.Text = "EnumLabel1";
            // 
            // EnumLabel2
            // 
            EnumLabel2.AutoSize = true;
            EnumLabel2.Location = new Point(40, 97);
            EnumLabel2.Name = "EnumLabel2";
            EnumLabel2.Size = new Size(72, 15);
            EnumLabel2.TabIndex = 3;
            EnumLabel2.Text = "EnumLabel2";
            // 
            // EnumLabel3
            // 
            EnumLabel3.AutoSize = true;
            EnumLabel3.Location = new Point(40, 150);
            EnumLabel3.Name = "EnumLabel3";
            EnumLabel3.Size = new Size(72, 15);
            EnumLabel3.TabIndex = 4;
            EnumLabel3.Text = "EnumLabel3";
            // 
            // EnumLabel4
            // 
            EnumLabel4.AutoSize = true;
            EnumLabel4.Location = new Point(40, 206);
            EnumLabel4.Name = "EnumLabel4";
            EnumLabel4.Size = new Size(72, 15);
            EnumLabel4.TabIndex = 5;
            EnumLabel4.Text = "EnumLabel4";
            // 
            // EnumLabel5
            // 
            EnumLabel5.AutoSize = true;
            EnumLabel5.Location = new Point(40, 257);
            EnumLabel5.Name = "EnumLabel5";
            EnumLabel5.Size = new Size(72, 15);
            EnumLabel5.TabIndex = 6;
            EnumLabel5.Text = "EnumLabel5";
            // 
            // AbilityDataPannel
            // 
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox5);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox4);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox3);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox2);
            AbilityDataPannel.Controls.Add(AbilityDataEnumBox1);
            AbilityDataPannel.Controls.Add(EnumLabel1);
            AbilityDataPannel.Controls.Add(EnumLabel5);
            AbilityDataPannel.Controls.Add(EnumLabel2);
            AbilityDataPannel.Controls.Add(EnumLabel4);
            AbilityDataPannel.Controls.Add(EnumLabel3);
            AbilityDataPannel.Location = new Point(34, 86);
            AbilityDataPannel.Name = "AbilityDataPannel";
            AbilityDataPannel.Size = new Size(929, 463);
            AbilityDataPannel.TabIndex = 7;
            // 
            // AbilityDataEnumBox5
            // 
            AbilityDataEnumBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox5.FormattingEnabled = true;
            AbilityDataEnumBox5.Location = new Point(170, 254);
            AbilityDataEnumBox5.Name = "AbilityDataEnumBox5";
            AbilityDataEnumBox5.Size = new Size(121, 23);
            AbilityDataEnumBox5.TabIndex = 11;
            // 
            // AbilityDataEnumBox4
            // 
            AbilityDataEnumBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox4.FormattingEnabled = true;
            AbilityDataEnumBox4.Location = new Point(170, 203);
            AbilityDataEnumBox4.Name = "AbilityDataEnumBox4";
            AbilityDataEnumBox4.Size = new Size(121, 23);
            AbilityDataEnumBox4.TabIndex = 10;
            // 
            // AbilityDataEnumBox3
            // 
            AbilityDataEnumBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox3.FormattingEnabled = true;
            AbilityDataEnumBox3.Location = new Point(170, 147);
            AbilityDataEnumBox3.Name = "AbilityDataEnumBox3";
            AbilityDataEnumBox3.Size = new Size(121, 23);
            AbilityDataEnumBox3.TabIndex = 9;
            // 
            // AbilityDataEnumBox2
            // 
            AbilityDataEnumBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox2.FormattingEnabled = true;
            AbilityDataEnumBox2.Location = new Point(170, 94);
            AbilityDataEnumBox2.Name = "AbilityDataEnumBox2";
            AbilityDataEnumBox2.Size = new Size(121, 23);
            AbilityDataEnumBox2.TabIndex = 8;
            // 
            // AbilityDataEnumBox1
            // 
            AbilityDataEnumBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            AbilityDataEnumBox1.FormattingEnabled = true;
            AbilityDataEnumBox1.Location = new Point(170, 46);
            AbilityDataEnumBox1.Name = "AbilityDataEnumBox1";
            AbilityDataEnumBox1.Size = new Size(121, 23);
            AbilityDataEnumBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 648);
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
        private Label EnumLabel1;
        private Label EnumLabel2;
        private Label EnumLabel3;
        private Label EnumLabel4;
        private Label EnumLabel5;
        private Panel AbilityDataPannel;
        private ComboBox AbilityDataEnumBox1;
        private ComboBox AbilityDataEnumBox5;
        private ComboBox AbilityDataEnumBox4;
        private ComboBox AbilityDataEnumBox3;
        private ComboBox AbilityDataEnumBox2;
    }
}