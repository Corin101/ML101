namespace ML101
{
    partial class Form1
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
            this.gameEnd1 = new ML101.GameEnd();
            this.inputSticksError1 = new ML101.InputSticksError();
            this.mainWindow1 = new ML101.MainWindow();
            this.SuspendLayout();
            // 
            // gameEnd1
            // 
            this.gameEnd1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameEnd1.Location = new System.Drawing.Point(169, 81);
            this.gameEnd1.Name = "gameEnd1";
            this.gameEnd1.Size = new System.Drawing.Size(832, 608);
            this.gameEnd1.TabIndex = 2;
            // 
            // inputSticksError1
            // 
            this.inputSticksError1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputSticksError1.Location = new System.Drawing.Point(169, 81);
            this.inputSticksError1.Name = "inputSticksError1";
            this.inputSticksError1.Size = new System.Drawing.Size(832, 608);
            this.inputSticksError1.TabIndex = 1;
            // 
            // mainWindow1
            // 
            this.mainWindow1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainWindow1.Location = new System.Drawing.Point(169, 81);
            this.mainWindow1.Name = "mainWindow1";
            this.mainWindow1.Size = new System.Drawing.Size(832, 608);
            this.mainWindow1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1178, 820);
            this.Controls.Add(this.gameEnd1);
            this.Controls.Add(this.inputSticksError1);
            this.Controls.Add(this.mainWindow1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MainWindow mainWindow1;
        private InputSticksError inputSticksError1;
        private GameEnd gameEnd1;
    }
}