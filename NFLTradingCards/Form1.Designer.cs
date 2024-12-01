namespace NFLTradingCards
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
            playerListBox = new ListBox();
            cardPanel = new Panel();
            nextPlayerButton = new Button();
            previousPlayerButton = new Button();
            lbl_teamName = new Label();
            teamPicture = new PictureBox();
            panel1 = new Panel();
            interceptionsLabel = new Label();
            touchdownsLabel = new Label();
            yardsPerAttemptLabel = new Label();
            passingYardsLabel = new Label();
            playerName = new Label();
            playerPicture = new PictureBox();
            nameLabel = new Label();
            teamLabel = new Label();
            statsLabel = new Label();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teamPicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerPicture).BeginInit();
            SuspendLayout();
            // 
            // playerListBox
            // 
            playerListBox.Location = new Point(14, 16);
            playerListBox.Margin = new Padding(3, 4, 3, 4);
            playerListBox.Name = "playerListBox";
            playerListBox.Size = new Size(228, 564);
            playerListBox.TabIndex = 0;
            playerListBox.SelectedIndexChanged += playerListBox_SelectedIndexChanged;
            // 
            // cardPanel
            // 
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Controls.Add(nextPlayerButton);
            cardPanel.Controls.Add(previousPlayerButton);
            cardPanel.Controls.Add(lbl_teamName);
            cardPanel.Controls.Add(teamPicture);
            cardPanel.Controls.Add(panel1);
            cardPanel.Controls.Add(playerPicture);
            cardPanel.Location = new Point(249, 16);
            cardPanel.Margin = new Padding(3, 4, 3, 4);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(400, 563);
            cardPanel.TabIndex = 1;
            // 
            // nextPlayerButton
            // 
            nextPlayerButton.BackColor = SystemColors.ButtonShadow;
            nextPlayerButton.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextPlayerButton.ForeColor = SystemColors.HighlightText;
            nextPlayerButton.Location = new Point(351, 292);
            nextPlayerButton.Name = "nextPlayerButton";
            nextPlayerButton.Size = new Size(43, 32);
            nextPlayerButton.TabIndex = 6;
            nextPlayerButton.Text = ">";
            nextPlayerButton.UseVisualStyleBackColor = false;
            nextPlayerButton.Click += nextPlayerButtonClicked;
            // 
            // previousPlayerButton
            // 
            previousPlayerButton.BackColor = SystemColors.ButtonShadow;
            previousPlayerButton.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousPlayerButton.ForeColor = SystemColors.HighlightText;
            previousPlayerButton.Location = new Point(6, 292);
            previousPlayerButton.Name = "previousPlayerButton";
            previousPlayerButton.Size = new Size(43, 32);
            previousPlayerButton.TabIndex = 5;
            previousPlayerButton.Text = "<";
            previousPlayerButton.UseVisualStyleBackColor = false;
            previousPlayerButton.Click += previousPlayerButtonClicked;
            // 
            // lbl_teamName
            // 
            lbl_teamName.AutoSize = true;
            lbl_teamName.BackColor = SystemColors.ControlLightLight;
            lbl_teamName.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_teamName.Location = new Point(66, 35);
            lbl_teamName.Name = "lbl_teamName";
            lbl_teamName.Size = new Size(67, 20);
            lbl_teamName.TabIndex = 2;
            lbl_teamName.Text = "label1";
            // 
            // teamPicture
            // 
            teamPicture.Location = new Point(264, 55);
            teamPicture.Margin = new Padding(2, 3, 2, 3);
            teamPicture.Name = "teamPicture";
            teamPicture.Size = new Size(46, 53);
            teamPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            teamPicture.TabIndex = 4;
            teamPicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(interceptionsLabel);
            panel1.Controls.Add(touchdownsLabel);
            panel1.Controls.Add(yardsPerAttemptLabel);
            panel1.Controls.Add(passingYardsLabel);
            panel1.Controls.Add(playerName);
            panel1.Location = new Point(65, 305);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 228);
            panel1.TabIndex = 2;
            // 
            // interceptionsLabel
            // 
            interceptionsLabel.AutoSize = true;
            interceptionsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interceptionsLabel.Location = new Point(17, 169);
            interceptionsLabel.Name = "interceptionsLabel";
            interceptionsLabel.Size = new Size(68, 23);
            interceptionsLabel.TabIndex = 5;
            interceptionsLabel.Text = "label1";
            interceptionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // touchdownsLabel
            // 
            touchdownsLabel.AutoSize = true;
            touchdownsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            touchdownsLabel.Location = new Point(17, 133);
            touchdownsLabel.Name = "touchdownsLabel";
            touchdownsLabel.Size = new Size(68, 23);
            touchdownsLabel.TabIndex = 4;
            touchdownsLabel.Text = "label1";
            touchdownsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yardsPerAttemptLabel
            // 
            yardsPerAttemptLabel.AutoSize = true;
            yardsPerAttemptLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yardsPerAttemptLabel.Location = new Point(17, 97);
            yardsPerAttemptLabel.Name = "yardsPerAttemptLabel";
            yardsPerAttemptLabel.Size = new Size(68, 23);
            yardsPerAttemptLabel.TabIndex = 3;
            yardsPerAttemptLabel.Text = "label1";
            yardsPerAttemptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passingYardsLabel
            // 
            passingYardsLabel.AutoSize = true;
            passingYardsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passingYardsLabel.Location = new Point(17, 61);
            passingYardsLabel.Name = "passingYardsLabel";
            passingYardsLabel.Size = new Size(68, 23);
            passingYardsLabel.TabIndex = 2;
            passingYardsLabel.Text = "label1";
            passingYardsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerName.Location = new Point(17, 13);
            playerName.Name = "playerName";
            playerName.Size = new Size(95, 29);
            playerName.TabIndex = 1;
            playerName.Text = "label1";
            playerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerPicture
            // 
            playerPicture.Location = new Point(55, 25);
            playerPicture.Margin = new Padding(3, 4, 3, 4);
            playerPicture.Name = "playerPicture";
            playerPicture.Size = new Size(290, 268);
            playerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            playerPicture.TabIndex = 0;
            playerPicture.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(0, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 23);
            nameLabel.TabIndex = 0;
            // 
            // teamLabel
            // 
            teamLabel.Location = new Point(0, 0);
            teamLabel.Name = "teamLabel";
            teamLabel.Size = new Size(100, 23);
            teamLabel.TabIndex = 0;
            // 
            // statsLabel
            // 
            statsLabel.Location = new Point(0, 0);
            statsLabel.Name = "statsLabel";
            statsLabel.Size = new Size(100, 23);
            statsLabel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 591);
            Controls.Add(cardPanel);
            Controls.Add(playerListBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "NFL Trading Cards";
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teamPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox playerListBox;
        private Panel cardPanel;
        private Label nameLabel;
        private Label teamLabel;
        private Label statsLabel;
        private Label playerName;
        private PictureBox playerPicture;
        private Panel panel1;
        private Label passingYardsLabel;
        private Label yardsPerAttemptLabel;
        private Label touchdownsLabel;
        private Label interceptionsLabel;
        private PictureBox teamPicture;
        private Label lbl_teamName;
        private Button previousPlayerButton;
        private Button nextPlayerButton;
    }
}