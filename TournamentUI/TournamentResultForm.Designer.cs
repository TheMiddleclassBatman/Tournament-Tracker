namespace TournamentUI
{
    partial class TournamentResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentResultForm));
            this.congratsLabel = new System.Windows.Forms.Label();
            this.whoWonText = new System.Windows.Forms.Label();
            this.prizeOneText = new System.Windows.Forms.Label();
            this.prizeTwoText = new System.Windows.Forms.Label();
            this.thanksForPlayingLabel = new System.Windows.Forms.Label();
            this.runnerUpText = new System.Windows.Forms.Label();
            this.signLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // congratsLabel
            // 
            this.congratsLabel.AutoSize = true;
            this.congratsLabel.BackColor = System.Drawing.Color.Transparent;
            this.congratsLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratsLabel.ForeColor = System.Drawing.Color.White;
            this.congratsLabel.Location = new System.Drawing.Point(38, 251);
            this.congratsLabel.Name = "congratsLabel";
            this.congratsLabel.Size = new System.Drawing.Size(860, 45);
            this.congratsLabel.TabIndex = 5;
            this.congratsLabel.Text = "Congratulations to our winner on a great tournament!";
            this.congratsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // whoWonText
            // 
            this.whoWonText.AutoSize = true;
            this.whoWonText.BackColor = System.Drawing.Color.Transparent;
            this.whoWonText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoWonText.ForeColor = System.Drawing.Color.White;
            this.whoWonText.Location = new System.Drawing.Point(38, 45);
            this.whoWonText.Name = "whoWonText";
            this.whoWonText.Size = new System.Drawing.Size(341, 54);
            this.whoWonText.TabIndex = 6;
            this.whoWonText.Text = "<someone won>";
            // 
            // prizeOneText
            // 
            this.prizeOneText.AutoSize = true;
            this.prizeOneText.BackColor = System.Drawing.Color.Transparent;
            this.prizeOneText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeOneText.ForeColor = System.Drawing.Color.White;
            this.prizeOneText.Location = new System.Drawing.Point(38, 354);
            this.prizeOneText.Name = "prizeOneText";
            this.prizeOneText.Size = new System.Drawing.Size(206, 54);
            this.prizeOneText.TabIndex = 7;
            this.prizeOneText.Text = "<prize 1>";
            this.prizeOneText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prizeOneText.Visible = false;
            // 
            // prizeTwoText
            // 
            this.prizeTwoText.AutoSize = true;
            this.prizeTwoText.BackColor = System.Drawing.Color.Transparent;
            this.prizeTwoText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeTwoText.ForeColor = System.Drawing.Color.White;
            this.prizeTwoText.Location = new System.Drawing.Point(38, 457);
            this.prizeTwoText.Name = "prizeTwoText";
            this.prizeTwoText.Size = new System.Drawing.Size(206, 54);
            this.prizeTwoText.TabIndex = 8;
            this.prizeTwoText.Text = "<prize 2>";
            this.prizeTwoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prizeTwoText.Visible = false;
            // 
            // thanksForPlayingLabel
            // 
            this.thanksForPlayingLabel.AutoSize = true;
            this.thanksForPlayingLabel.BackColor = System.Drawing.Color.Transparent;
            this.thanksForPlayingLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksForPlayingLabel.ForeColor = System.Drawing.Color.White;
            this.thanksForPlayingLabel.Location = new System.Drawing.Point(664, 562);
            this.thanksForPlayingLabel.Name = "thanksForPlayingLabel";
            this.thanksForPlayingLabel.Size = new System.Drawing.Size(386, 54);
            this.thanksForPlayingLabel.TabIndex = 9;
            this.thanksForPlayingLabel.Text = "Thanks for playing!";
            this.thanksForPlayingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // runnerUpText
            // 
            this.runnerUpText.AutoSize = true;
            this.runnerUpText.BackColor = System.Drawing.Color.Transparent;
            this.runnerUpText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runnerUpText.ForeColor = System.Drawing.Color.White;
            this.runnerUpText.Location = new System.Drawing.Point(38, 148);
            this.runnerUpText.Name = "runnerUpText";
            this.runnerUpText.Size = new System.Drawing.Size(341, 54);
            this.runnerUpText.TabIndex = 10;
            this.runnerUpText.Text = "<someone won>";
            // 
            // signLable
            // 
            this.signLable.AutoSize = true;
            this.signLable.BackColor = System.Drawing.Color.Transparent;
            this.signLable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signLable.ForeColor = System.Drawing.Color.White;
            this.signLable.Location = new System.Drawing.Point(754, 626);
            this.signLable.Name = "signLable";
            this.signLable.Size = new System.Drawing.Size(281, 38);
            this.signLable.TabIndex = 11;
            this.signLable.Text = "~Tournament Tracker";
            this.signLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TournamentResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.signLable);
            this.Controls.Add(this.runnerUpText);
            this.Controls.Add(this.thanksForPlayingLabel);
            this.Controls.Add(this.prizeTwoText);
            this.Controls.Add(this.prizeOneText);
            this.Controls.Add(this.whoWonText);
            this.Controls.Add(this.congratsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label congratsLabel;
        private System.Windows.Forms.Label whoWonText;
        private System.Windows.Forms.Label prizeOneText;
        private System.Windows.Forms.Label prizeTwoText;
        private System.Windows.Forms.Label thanksForPlayingLabel;
        private System.Windows.Forms.Label runnerUpText;
        private System.Windows.Forms.Label signLable;
    }
}