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
            playerListBox.ItemHeight = 25;
            playerListBox.Location = new Point(17, 20);
            playerListBox.Margin = new Padding(4, 5, 4, 5);
            playerListBox.Name = "playerListBox";
            playerListBox.Size = new Size(284, 704);
            playerListBox.TabIndex = 0;
            playerListBox.SelectedIndexChanged += playerListBox_SelectedIndexChanged;
            // 
            // cardPanel
            // 
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Controls.Add(teamPicture);
            cardPanel.Controls.Add(panel1);
            cardPanel.Controls.Add(playerPicture);
            cardPanel.Location = new Point(311, 20);
            cardPanel.Margin = new Padding(4, 5, 4, 5);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(499, 704);
            cardPanel.TabIndex = 1;
            // 
            // teamPicture
            // 
            teamPicture.Location = new Point(325, 33);
            teamPicture.Name = "teamPicture";
            teamPicture.Size = new Size(90, 90);
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
            panel1.Location = new Point(81, 382);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 285);
            panel1.TabIndex = 2;
            // 
            // interceptionsLabel
            // 
            interceptionsLabel.AutoSize = true;
            interceptionsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interceptionsLabel.Location = new Point(21, 212);
            interceptionsLabel.Margin = new Padding(4, 0, 4, 0);
            interceptionsLabel.Name = "interceptionsLabel";
            interceptionsLabel.Size = new Size(81, 28);
            interceptionsLabel.TabIndex = 5;
            interceptionsLabel.Text = "label1";
            interceptionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // touchdownsLabel
            // 
            touchdownsLabel.AutoSize = true;
            touchdownsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            touchdownsLabel.Location = new Point(21, 167);
            touchdownsLabel.Margin = new Padding(4, 0, 4, 0);
            touchdownsLabel.Name = "touchdownsLabel";
            touchdownsLabel.Size = new Size(81, 28);
            touchdownsLabel.TabIndex = 4;
            touchdownsLabel.Text = "label1";
            touchdownsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yardsPerAttemptLabel
            // 
            yardsPerAttemptLabel.AutoSize = true;
            yardsPerAttemptLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yardsPerAttemptLabel.Location = new Point(21, 122);
            yardsPerAttemptLabel.Margin = new Padding(4, 0, 4, 0);
            yardsPerAttemptLabel.Name = "yardsPerAttemptLabel";
            yardsPerAttemptLabel.Size = new Size(81, 28);
            yardsPerAttemptLabel.TabIndex = 3;
            yardsPerAttemptLabel.Text = "label1";
            yardsPerAttemptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passingYardsLabel
            // 
            passingYardsLabel.AutoSize = true;
            passingYardsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passingYardsLabel.Location = new Point(21, 77);
            passingYardsLabel.Margin = new Padding(4, 0, 4, 0);
            passingYardsLabel.Name = "passingYardsLabel";
            passingYardsLabel.Size = new Size(81, 28);
            passingYardsLabel.TabIndex = 2;
            passingYardsLabel.Text = "label1";
            passingYardsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerName.Location = new Point(21, 17);
            playerName.Margin = new Padding(4, 0, 4, 0);
            playerName.Name = "playerName";
            playerName.Size = new Size(114, 35);
            playerName.TabIndex = 1;
            playerName.Text = "label1";
            playerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerPicture
            // 
            playerPicture.Location = new Point(69, 32);
            playerPicture.Margin = new Padding(4, 5, 4, 5);
            playerPicture.Name = "playerPicture";
            playerPicture.Size = new Size(363, 335);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 738);
            Controls.Add(cardPanel);
            Controls.Add(playerListBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "NFL Trading Cards";
            cardPanel.ResumeLayout(false);
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
    }
}