namespace AppGUI.UserControlPanels
{
    partial class GameTextUC
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
            GameTextPannel = new Panel();
            GameTextRichBox = new RichTextBox();
            GameTextLabel = new Label();
            GameTextPannel.SuspendLayout();
            SuspendLayout();
            // 
            // GameTextPannel
            // 
            GameTextPannel.Controls.Add(GameTextRichBox);
            GameTextPannel.Controls.Add(GameTextLabel);
            GameTextPannel.Location = new Point(0, 0);
            GameTextPannel.Name = "GameTextPannel";
            GameTextPannel.Size = new Size(1200, 625);
            GameTextPannel.TabIndex = 16;
            // 
            // GameTextRichBox
            // 
            GameTextRichBox.Location = new Point(168, 74);
            GameTextRichBox.Name = "GameTextRichBox";
            GameTextRichBox.Size = new Size(480, 258);
            GameTextRichBox.TabIndex = 1;
            GameTextRichBox.Text = "";
            // 
            // GameTextLabel
            // 
            GameTextLabel.AutoSize = true;
            GameTextLabel.Location = new Point(37, 67);
            GameTextLabel.Name = "GameTextLabel";
            GameTextLabel.Size = new Size(61, 15);
            GameTextLabel.TabIndex = 0;
            GameTextLabel.Text = "Game text";
            // 
            // GameTextUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GameTextPannel);
            Name = "GameTextUC";
            Size = new Size(1200, 625);
            GameTextPannel.ResumeLayout(false);
            GameTextPannel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel GameTextPannel;
        private RichTextBox GameTextRichBox;
        private Label GameTextLabel;
    }
}
