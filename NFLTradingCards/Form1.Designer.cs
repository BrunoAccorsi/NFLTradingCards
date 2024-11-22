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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerPicture).BeginInit();
            SuspendLayout();
            // 
            // playerListBox
            // 
            playerListBox.ItemHeight = 15;
            playerListBox.Location = new Point(12, 12);
            playerListBox.Name = "playerListBox";
            playerListBox.Size = new Size(200, 424);
            playerListBox.TabIndex = 0;
            playerListBox.SelectedIndexChanged += playerListBox_SelectedIndexChanged;
            // 
            // cardPanel
            // 
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Controls.Add(panel1);
            cardPanel.Controls.Add(playerPicture);
            cardPanel.Location = new Point(218, 12);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(350, 424);
            cardPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(interceptionsLabel);
            panel1.Controls.Add(touchdownsLabel);
            panel1.Controls.Add(yardsPerAttemptLabel);
            panel1.Controls.Add(passingYardsLabel);
            panel1.Controls.Add(playerName);
            panel1.Location = new Point(46, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 171);
            panel1.TabIndex = 2;
            // 
            // interceptionsLabel
            // 
            interceptionsLabel.AutoSize = true;
            interceptionsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interceptionsLabel.Location = new Point(15, 127);
            interceptionsLabel.Name = "interceptionsLabel";
            interceptionsLabel.Size = new Size(51, 18);
            interceptionsLabel.TabIndex = 5;
            interceptionsLabel.Text = "label1";
            interceptionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // touchdownsLabel
            // 
            touchdownsLabel.AutoSize = true;
            touchdownsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            touchdownsLabel.Location = new Point(15, 100);
            touchdownsLabel.Name = "touchdownsLabel";
            touchdownsLabel.Size = new Size(51, 18);
            touchdownsLabel.TabIndex = 4;
            touchdownsLabel.Text = "label1";
            touchdownsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yardsPerAttemptLabel
            // 
            yardsPerAttemptLabel.AutoSize = true;
            yardsPerAttemptLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yardsPerAttemptLabel.Location = new Point(15, 73);
            yardsPerAttemptLabel.Name = "yardsPerAttemptLabel";
            yardsPerAttemptLabel.Size = new Size(51, 18);
            yardsPerAttemptLabel.TabIndex = 3;
            yardsPerAttemptLabel.Text = "label1";
            yardsPerAttemptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passingYardsLabel
            // 
            passingYardsLabel.AutoSize = true;
            passingYardsLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passingYardsLabel.Location = new Point(15, 46);
            passingYardsLabel.Name = "passingYardsLabel";
            passingYardsLabel.Size = new Size(51, 18);
            passingYardsLabel.TabIndex = 2;
            passingYardsLabel.Text = "label1";
            passingYardsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerName.Location = new Point(15, 10);
            playerName.Name = "playerName";
            playerName.Size = new Size(77, 23);
            playerName.TabIndex = 1;
            playerName.Text = "label1";
            playerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerPicture
            // 
            playerPicture.Location = new Point(46, 22);
            playerPicture.Name = "playerPicture";
            playerPicture.Size = new Size(256, 201);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(cardPanel);
            Controls.Add(playerListBox);
            Name = "Form1";
            Text = "NFL Trading Cards";
            cardPanel.ResumeLayout(false);
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
    }
}