namespace TournamentUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.scoreButton = new System.Windows.Forms.Button();
            this.vsLable = new System.Windows.Forms.Label();
            this.teamTwoScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.teamOneScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLablee = new System.Windows.Forms.Label();
            this.teamOneScoreLable = new System.Windows.Forms.Label();
            this.teamTwoLable = new System.Windows.Forms.Label();
            this.teamOneLable = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.unplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.roundLable = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.headerLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.ForestGreen;
            this.scoreButton.FlatAppearance.BorderSize = 0;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.White;
            this.scoreButton.Location = new System.Drawing.Point(872, 365);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(141, 64);
            this.scoreButton.TabIndex = 27;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // vsLable
            // 
            this.vsLable.AutoSize = true;
            this.vsLable.BackColor = System.Drawing.Color.Transparent;
            this.vsLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsLable.ForeColor = System.Drawing.Color.White;
            this.vsLable.Location = new System.Drawing.Point(721, 376);
            this.vsLable.Name = "vsLable";
            this.vsLable.Size = new System.Drawing.Size(77, 41);
            this.vsLable.TabIndex = 26;
            this.vsLable.Text = "-VS-";
            // 
            // teamTwoScoreValueTextBox
            // 
            this.teamTwoScoreValueTextBox.Location = new System.Drawing.Point(760, 520);
            this.teamTwoScoreValueTextBox.Name = "teamTwoScoreValueTextBox";
            this.teamTwoScoreValueTextBox.Size = new System.Drawing.Size(100, 38);
            this.teamTwoScoreValueTextBox.TabIndex = 25;
            // 
            // teamOneScoreValueTextBox
            // 
            this.teamOneScoreValueTextBox.Location = new System.Drawing.Point(760, 288);
            this.teamOneScoreValueTextBox.Name = "teamOneScoreValueTextBox";
            this.teamOneScoreValueTextBox.Size = new System.Drawing.Size(100, 38);
            this.teamOneScoreValueTextBox.TabIndex = 24;
            // 
            // teamTwoScoreLablee
            // 
            this.teamTwoScoreLablee.AutoSize = true;
            this.teamTwoScoreLablee.BackColor = System.Drawing.Color.Transparent;
            this.teamTwoScoreLablee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreLablee.ForeColor = System.Drawing.Color.White;
            this.teamTwoScoreLablee.Location = new System.Drawing.Point(644, 520);
            this.teamTwoScoreLablee.Name = "teamTwoScoreLablee";
            this.teamTwoScoreLablee.Size = new System.Drawing.Size(99, 41);
            this.teamTwoScoreLablee.TabIndex = 23;
            this.teamTwoScoreLablee.Text = "Score:";
            // 
            // teamOneScoreLable
            // 
            this.teamOneScoreLable.AutoSize = true;
            this.teamOneScoreLable.BackColor = System.Drawing.Color.Transparent;
            this.teamOneScoreLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreLable.ForeColor = System.Drawing.Color.White;
            this.teamOneScoreLable.Location = new System.Drawing.Point(644, 288);
            this.teamOneScoreLable.Name = "teamOneScoreLable";
            this.teamOneScoreLable.Size = new System.Drawing.Size(99, 41);
            this.teamOneScoreLable.TabIndex = 22;
            this.teamOneScoreLable.Text = "Score:";
            // 
            // teamTwoLable
            // 
            this.teamTwoLable.AutoSize = true;
            this.teamTwoLable.BackColor = System.Drawing.Color.Transparent;
            this.teamTwoLable.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoLable.ForeColor = System.Drawing.Color.White;
            this.teamTwoLable.Location = new System.Drawing.Point(641, 439);
            this.teamTwoLable.Name = "teamTwoLable";
            this.teamTwoLable.Size = new System.Drawing.Size(214, 59);
            this.teamTwoLable.TabIndex = 21;
            this.teamTwoLable.Text = "<team 2>";
            // 
            // teamOneLable
            // 
            this.teamOneLable.AutoSize = true;
            this.teamOneLable.BackColor = System.Drawing.Color.Transparent;
            this.teamOneLable.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneLable.ForeColor = System.Drawing.Color.White;
            this.teamOneLable.Location = new System.Drawing.Point(641, 214);
            this.teamOneLable.Name = "teamOneLable";
            this.teamOneLable.Size = new System.Drawing.Size(214, 59);
            this.teamOneLable.TabIndex = 20;
            this.teamOneLable.Text = "<team 1>";
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 31;
            this.matchupListBox.Location = new System.Drawing.Point(59, 336);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(427, 281);
            this.matchupListBox.TabIndex = 19;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // unplayedCheckBox
            // 
            this.unplayedCheckBox.AutoSize = true;
            this.unplayedCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.unplayedCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedCheckBox.ForeColor = System.Drawing.Color.White;
            this.unplayedCheckBox.Location = new System.Drawing.Point(181, 277);
            this.unplayedCheckBox.Name = "unplayedCheckBox";
            this.unplayedCheckBox.Size = new System.Drawing.Size(164, 32);
            this.unplayedCheckBox.TabIndex = 18;
            this.unplayedCheckBox.Text = "Unplayed Only";
            this.unplayedCheckBox.UseVisualStyleBackColor = false;
            this.unplayedCheckBox.CheckedChanged += new System.EventHandler(this.unplayedCheckBox_CheckedChanged);
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(181, 214);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(305, 39);
            this.roundDropdown.TabIndex = 17;
            this.roundDropdown.SelectedIndexChanged += new System.EventHandler(this.roundDropdown_SelectedIndexChanged_1);
            // 
            // roundLable
            // 
            this.roundLable.AutoSize = true;
            this.roundLable.BackColor = System.Drawing.Color.Transparent;
            this.roundLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLable.ForeColor = System.Drawing.Color.White;
            this.roundLable.Location = new System.Drawing.Point(51, 214);
            this.roundLable.Name = "roundLable";
            this.roundLable.Size = new System.Drawing.Size(122, 45);
            this.roundLable.TabIndex = 16;
            this.roundLable.Text = "Round:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.BackColor = System.Drawing.Color.Transparent;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.White;
            this.tournamentName.Location = new System.Drawing.Point(291, 56);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(178, 59);
            this.tournamentName.TabIndex = 15;
            this.tournamentName.Text = "<none>";
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.BackColor = System.Drawing.Color.Transparent;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.ForeColor = System.Drawing.Color.White;
            this.headerLable.Location = new System.Drawing.Point(49, 56);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(261, 59);
            this.headerLable.TabIndex = 14;
            this.headerLable.Text = "Tournament:";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLable);
            this.Controls.Add(this.teamTwoScoreValueTextBox);
            this.Controls.Add(this.teamOneScoreValueTextBox);
            this.Controls.Add(this.teamTwoScoreLablee);
            this.Controls.Add(this.teamOneScoreLable);
            this.Controls.Add(this.teamTwoLable);
            this.Controls.Add(this.teamOneLable);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedCheckBox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLable);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label vsLable;
        private System.Windows.Forms.TextBox teamTwoScoreValueTextBox;
        private System.Windows.Forms.TextBox teamOneScoreValueTextBox;
        private System.Windows.Forms.Label teamTwoScoreLablee;
        private System.Windows.Forms.Label teamOneScoreLable;
        private System.Windows.Forms.Label teamTwoLable;
        private System.Windows.Forms.Label teamOneLable;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox unplayedCheckBox;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.Label roundLable;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label headerLable;
    }
}