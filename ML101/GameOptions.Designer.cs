﻿namespace ML101
{
    partial class GameOptions
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.SticksTextBox = new System.Windows.Forms.TextBox();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(365, 461);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(103, 38);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start";
            this.StartToolTip.SetToolTip(this.StartButton, "Yes, this is the Start button, and yes, you really do have\r\nto press this button " +
        "in order to continue.\r\nC\'mon! Press it, you know you want to!");
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SticksTextBox
            // 
            this.SticksTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SticksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SticksTextBox.Location = new System.Drawing.Point(412, 268);
            this.SticksTextBox.MaxLength = 2;
            this.SticksTextBox.Name = "SticksTextBox";
            this.SticksTextBox.Size = new System.Drawing.Size(40, 27);
            this.SticksTextBox.TabIndex = 10;
            this.StartToolTip.SetToolTip(this.SticksTextBox, "Enter the number of Sticks you want at the start of the\r\ngame. The number must be" +
        " bigger than 5, and just for\r\nthe fun of it, i\'ll limit the max number to 50.");
            this.SticksTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SticksTextBox_KeyDown);
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlayerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerNameTextBox.Location = new System.Drawing.Point(412, 209);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(189, 27);
            this.PlayerNameTextBox.TabIndex = 9;
            this.StartToolTip.SetToolTip(this.PlayerNameTextBox, "Player Name goes here. If you\'re too lazy to enter a name\r\nI\'ll just call you Pla" +
        "yer1.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(232, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Sticks:";
            this.StartToolTip.SetToolTip(this.label3, "Enter the number of Sticks you want at the start of the\r\ngame. The number must be" +
        " bigger than 5, and just for\r\nthe fun of it, i\'ll limit the max number to 50.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(232, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player Name:";
            this.StartToolTip.SetToolTip(this.label2, "Player Name goes here. If you\'re too lazy to enter a name\r\nI\'ll just call you Pla" +
        "yer1.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(231, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Options:";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarningLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.WarningLabel.Location = new System.Drawing.Point(259, 341);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(342, 20);
            this.WarningLabel.TabIndex = 12;
            this.WarningLabel.Text = "Number of sticks must be between 5 and 50!";
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SticksTextBox);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameOptions";
            this.Size = new System.Drawing.Size(832, 608);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox SticksTextBox;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip StartToolTip;
        private System.Windows.Forms.Label WarningLabel;
    }
}
