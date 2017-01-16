namespace ML101
{
    partial class GameWindow
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
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SticksInGame = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerPickTextBox = new System.Windows.Forms.TextBox();
            this.GameWindowToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.takeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DisplayTextBox.Location = new System.Drawing.Point(32, 280);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayTextBox.Size = new System.Drawing.Size(756, 278);
            this.DisplayTextBox.TabIndex = 0;
            this.GameWindowToolTip.SetToolTip(this.DisplayTextBox, "Display screen where you can see the events\r\nhappening in the game.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(32, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sticks left in the Game:";
            this.GameWindowToolTip.SetToolTip(this.label1, "Number of sticks left in the game.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(32, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Who\'s turn is it:";
            this.GameWindowToolTip.SetToolTip(this.label2, "Displays the information about who\'s turn is it to take\r\nsticks from the board.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(32, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "How many sticks will you take:";
            this.GameWindowToolTip.SetToolTip(this.label3, "This is where you eneter the number of sticks you wish\r\nto take from the board. Y" +
        "ou can take 1, 2 or 3 sticks\r\nfrom the board (or less if there are not enough st" +
        "icks\r\nin the game).");
            // 
            // SticksInGame
            // 
            this.SticksInGame.AutoSize = true;
            this.SticksInGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SticksInGame.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SticksInGame.Location = new System.Drawing.Point(340, 98);
            this.SticksInGame.Name = "SticksInGame";
            this.SticksInGame.Size = new System.Drawing.Size(18, 20);
            this.SticksInGame.TabIndex = 4;
            this.SticksInGame.Text = "0";
            this.GameWindowToolTip.SetToolTip(this.SticksInGame, "Number of sticks left in the game.");
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlayerNameLabel.Location = new System.Drawing.Point(340, 140);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(48, 20);
            this.PlayerNameLabel.TabIndex = 5;
            this.PlayerNameLabel.Text = "None";
            this.GameWindowToolTip.SetToolTip(this.PlayerNameLabel, "Displays the information about who\'s turn is it to take\r\nsticks from the board.");
            // 
            // PlayerPickTextBox
            // 
            this.PlayerPickTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlayerPickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerPickTextBox.Location = new System.Drawing.Point(344, 180);
            this.PlayerPickTextBox.MaxLength = 1;
            this.PlayerPickTextBox.Name = "PlayerPickTextBox";
            this.PlayerPickTextBox.Size = new System.Drawing.Size(48, 27);
            this.PlayerPickTextBox.TabIndex = 6;
            this.GameWindowToolTip.SetToolTip(this.PlayerPickTextBox, "This is where you eneter the number of sticks you wish\r\nto take from the board. Y" +
        "ou can take 1, 2 or 3 sticks\r\nfrom the board (or less if there are not enough st" +
        "icks\r\nin the game).");
            this.PlayerPickTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayerPickTextBox_KeyDown);
            // 
            // takeButton
            // 
            this.takeButton.Location = new System.Drawing.Point(439, 175);
            this.takeButton.Name = "takeButton";
            this.takeButton.Size = new System.Drawing.Size(103, 38);
            this.takeButton.TabIndex = 7;
            this.takeButton.Text = "Take!";
            this.takeButton.UseVisualStyleBackColor = true;
            this.takeButton.Click += new System.EventHandler(this.takeButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.takeButton);
            this.Controls.Add(this.PlayerPickTextBox);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.SticksInGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayTextBox);
            this.Name = "GameWindow";
            this.Size = new System.Drawing.Size(832, 608);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label SticksInGame;
        public System.Windows.Forms.Label PlayerNameLabel;
        public System.Windows.Forms.TextBox PlayerPickTextBox;
        private System.Windows.Forms.ToolTip GameWindowToolTip;
        private System.Windows.Forms.Button takeButton;
    }
}
