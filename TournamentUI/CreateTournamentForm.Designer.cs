namespace TournamentUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizesButton = new System.Windows.Forms.Button();
            this.removeSelectedTeamPlayersButton = new System.Windows.Forms.Button();
            this.prizesLable = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.teamPlayersLable = new System.Windows.Forms.Label();
            this.selectedTeamsListBox = new System.Windows.Forms.ListBox();
            this.setPrizezButton = new System.Windows.Forms.Button();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createNewTeamLinkLable = new System.Windows.Forms.LinkLabel();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamLable = new System.Windows.Forms.Label();
            this.inrLable = new System.Windows.Forms.Label();
            this.entryFeeValueTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLable = new System.Windows.Forms.Label();
            this.tournamentNameValueTextBox = new System.Windows.Forms.TextBox();
            this.tournamentNameLable = new System.Windows.Forms.Label();
            this.createTournamentLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.AutoSize = true;
            this.createTournamentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createTournamentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createTournamentButton.FlatAppearance.BorderSize = 0;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.Black;
            this.createTournamentButton.Location = new System.Drawing.Point(312, 561);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(297, 87);
            this.createTournamentButton.TabIndex = 44;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // removeSelectedPrizesButton
            // 
            this.removeSelectedPrizesButton.AutoSize = true;
            this.removeSelectedPrizesButton.BackColor = System.Drawing.Color.Red;
            this.removeSelectedPrizesButton.FlatAppearance.BorderSize = 0;
            this.removeSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizesButton.ForeColor = System.Drawing.Color.White;
            this.removeSelectedPrizesButton.Location = new System.Drawing.Point(938, 516);
            this.removeSelectedPrizesButton.Name = "removeSelectedPrizesButton";
            this.removeSelectedPrizesButton.Size = new System.Drawing.Size(112, 50);
            this.removeSelectedPrizesButton.TabIndex = 43;
            this.removeSelectedPrizesButton.Text = "Remove";
            this.removeSelectedPrizesButton.UseVisualStyleBackColor = false;
            this.removeSelectedPrizesButton.Click += new System.EventHandler(this.removeSelectedPrizesButton_Click);
            // 
            // removeSelectedTeamPlayersButton
            // 
            this.removeSelectedTeamPlayersButton.AutoSize = true;
            this.removeSelectedTeamPlayersButton.BackColor = System.Drawing.Color.Red;
            this.removeSelectedTeamPlayersButton.FlatAppearance.BorderSize = 0;
            this.removeSelectedTeamPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamPlayersButton.ForeColor = System.Drawing.Color.White;
            this.removeSelectedTeamPlayersButton.Location = new System.Drawing.Point(938, 311);
            this.removeSelectedTeamPlayersButton.Name = "removeSelectedTeamPlayersButton";
            this.removeSelectedTeamPlayersButton.Size = new System.Drawing.Size(112, 48);
            this.removeSelectedTeamPlayersButton.TabIndex = 42;
            this.removeSelectedTeamPlayersButton.Text = "Remove";
            this.removeSelectedTeamPlayersButton.UseVisualStyleBackColor = false;
            this.removeSelectedTeamPlayersButton.Click += new System.EventHandler(this.removeSelectedTeamPlayersButton_Click);
            // 
            // prizesLable
            // 
            this.prizesLable.AutoSize = true;
            this.prizesLable.BackColor = System.Drawing.Color.Transparent;
            this.prizesLable.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLable.ForeColor = System.Drawing.Color.White;
            this.prizesLable.Location = new System.Drawing.Point(630, 362);
            this.prizesLable.Name = "prizesLable";
            this.prizesLable.Size = new System.Drawing.Size(105, 41);
            this.prizesLable.TabIndex = 41;
            this.prizesLable.Text = "Prizes:";
            // 
            // prizesListBox
            // 
            this.prizesListBox.BackColor = System.Drawing.Color.White;
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 31;
            this.prizesListBox.Location = new System.Drawing.Point(630, 409);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(287, 157);
            this.prizesListBox.TabIndex = 40;
            // 
            // teamPlayersLable
            // 
            this.teamPlayersLable.AutoSize = true;
            this.teamPlayersLable.BackColor = System.Drawing.Color.Transparent;
            this.teamPlayersLable.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamPlayersLable.ForeColor = System.Drawing.Color.White;
            this.teamPlayersLable.Location = new System.Drawing.Point(630, 123);
            this.teamPlayersLable.Name = "teamPlayersLable";
            this.teamPlayersLable.Size = new System.Drawing.Size(111, 41);
            this.teamPlayersLable.TabIndex = 39;
            this.teamPlayersLable.Text = "Teams:";
            // 
            // selectedTeamsListBox
            // 
            this.selectedTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedTeamsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTeamsListBox.FormattingEnabled = true;
            this.selectedTeamsListBox.ItemHeight = 31;
            this.selectedTeamsListBox.Location = new System.Drawing.Point(630, 170);
            this.selectedTeamsListBox.Name = "selectedTeamsListBox";
            this.selectedTeamsListBox.Size = new System.Drawing.Size(287, 188);
            this.selectedTeamsListBox.TabIndex = 38;
            // 
            // setPrizezButton
            // 
            this.setPrizezButton.AutoSize = true;
            this.setPrizezButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.setPrizezButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setPrizezButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPrizezButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPrizezButton.ForeColor = System.Drawing.Color.Black;
            this.setPrizezButton.Location = new System.Drawing.Point(31, 534);
            this.setPrizezButton.Name = "setPrizezButton";
            this.setPrizezButton.Size = new System.Drawing.Size(180, 64);
            this.setPrizezButton.TabIndex = 37;
            this.setPrizezButton.Text = "Set Prizes";
            this.setPrizezButton.UseVisualStyleBackColor = false;
            this.setPrizezButton.Click += new System.EventHandler(this.setPrizezButton_Click);
            // 
            // addTeamButton
            // 
            this.addTeamButton.AutoSize = true;
            this.addTeamButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.Black;
            this.addTeamButton.Location = new System.Drawing.Point(31, 465);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(136, 51);
            this.addTeamButton.TabIndex = 36;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createNewTeamLinkLable
            // 
            this.createNewTeamLinkLable.AutoSize = true;
            this.createNewTeamLinkLable.BackColor = System.Drawing.Color.Transparent;
            this.createNewTeamLinkLable.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLinkLable.LinkColor = System.Drawing.Color.Yellow;
            this.createNewTeamLinkLable.Location = new System.Drawing.Point(216, 366);
            this.createNewTeamLinkLable.Name = "createNewTeamLinkLable";
            this.createNewTeamLinkLable.Size = new System.Drawing.Size(208, 32);
            this.createNewTeamLinkLable.TabIndex = 35;
            this.createNewTeamLinkLable.TabStop = true;
            this.createNewTeamLinkLable.Text = "Create New Team";
            this.createNewTeamLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLinkLable_LinkClicked);
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(31, 403);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(381, 39);
            this.selectTeamDropdown.TabIndex = 34;
            // 
            // selectTeamLable
            // 
            this.selectTeamLable.AutoSize = true;
            this.selectTeamLable.BackColor = System.Drawing.Color.Transparent;
            this.selectTeamLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLable.ForeColor = System.Drawing.Color.White;
            this.selectTeamLable.Location = new System.Drawing.Point(23, 355);
            this.selectTeamLable.Name = "selectTeamLable";
            this.selectTeamLable.Size = new System.Drawing.Size(198, 45);
            this.selectTeamLable.TabIndex = 33;
            this.selectTeamLable.Text = "Select Team:";
            // 
            // inrLable
            // 
            this.inrLable.AutoSize = true;
            this.inrLable.BackColor = System.Drawing.Color.Transparent;
            this.inrLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inrLable.ForeColor = System.Drawing.Color.White;
            this.inrLable.Location = new System.Drawing.Point(304, 278);
            this.inrLable.Name = "inrLable";
            this.inrLable.Size = new System.Drawing.Size(74, 45);
            this.inrLable.TabIndex = 32;
            this.inrLable.Text = "INR";
            // 
            // entryFeeValueTextBox
            // 
            this.entryFeeValueTextBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeValueTextBox.Location = new System.Drawing.Point(180, 282);
            this.entryFeeValueTextBox.Name = "entryFeeValueTextBox";
            this.entryFeeValueTextBox.Size = new System.Drawing.Size(119, 51);
            this.entryFeeValueTextBox.TabIndex = 31;
            this.entryFeeValueTextBox.Text = "0.00";
            this.entryFeeValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entryFeeLable
            // 
            this.entryFeeLable.AutoSize = true;
            this.entryFeeLable.BackColor = System.Drawing.Color.Transparent;
            this.entryFeeLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLable.ForeColor = System.Drawing.Color.White;
            this.entryFeeLable.Location = new System.Drawing.Point(23, 278);
            this.entryFeeLable.Name = "entryFeeLable";
            this.entryFeeLable.Size = new System.Drawing.Size(160, 45);
            this.entryFeeLable.TabIndex = 30;
            this.entryFeeLable.Text = "Entry Fee:";
            // 
            // tournamentNameValueTextBox
            // 
            this.tournamentNameValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameValueTextBox.ForeColor = System.Drawing.Color.Black;
            this.tournamentNameValueTextBox.Location = new System.Drawing.Point(30, 210);
            this.tournamentNameValueTextBox.Name = "tournamentNameValueTextBox";
            this.tournamentNameValueTextBox.Size = new System.Drawing.Size(381, 38);
            this.tournamentNameValueTextBox.TabIndex = 29;
            // 
            // tournamentNameLable
            // 
            this.tournamentNameLable.AutoSize = true;
            this.tournamentNameLable.BackColor = System.Drawing.Color.Transparent;
            this.tournamentNameLable.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLable.ForeColor = System.Drawing.Color.White;
            this.tournamentNameLable.Location = new System.Drawing.Point(23, 147);
            this.tournamentNameLable.Name = "tournamentNameLable";
            this.tournamentNameLable.Size = new System.Drawing.Size(306, 45);
            this.tournamentNameLable.TabIndex = 28;
            this.tournamentNameLable.Text = "Tournament Name:";
            // 
            // createTournamentLable
            // 
            this.createTournamentLable.AutoSize = true;
            this.createTournamentLable.BackColor = System.Drawing.Color.Transparent;
            this.createTournamentLable.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentLable.ForeColor = System.Drawing.Color.Yellow;
            this.createTournamentLable.Location = new System.Drawing.Point(21, 71);
            this.createTournamentLable.Name = "createTournamentLable";
            this.createTournamentLable.Size = new System.Drawing.Size(423, 59);
            this.createTournamentLable.TabIndex = 27;
            this.createTournamentLable.Text = "Create Tournament:";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeSelectedPrizesButton);
            this.Controls.Add(this.removeSelectedTeamPlayersButton);
            this.Controls.Add(this.prizesLable);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.teamPlayersLable);
            this.Controls.Add(this.selectedTeamsListBox);
            this.Controls.Add(this.setPrizezButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLinkLable);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLable);
            this.Controls.Add(this.inrLable);
            this.Controls.Add(this.entryFeeValueTextBox);
            this.Controls.Add(this.entryFeeLable);
            this.Controls.Add(this.tournamentNameValueTextBox);
            this.Controls.Add(this.tournamentNameLable);
            this.Controls.Add(this.createTournamentLable);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button removeSelectedPrizesButton;
        private System.Windows.Forms.Button removeSelectedTeamPlayersButton;
        private System.Windows.Forms.Label prizesLable;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Label teamPlayersLable;
        private System.Windows.Forms.ListBox selectedTeamsListBox;
        private System.Windows.Forms.Button setPrizezButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.LinkLabel createNewTeamLinkLable;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Label selectTeamLable;
        private System.Windows.Forms.Label inrLable;
        private System.Windows.Forms.TextBox entryFeeValueTextBox;
        private System.Windows.Forms.Label entryFeeLable;
        private System.Windows.Forms.TextBox tournamentNameValueTextBox;
        private System.Windows.Forms.Label tournamentNameLable;
        private System.Windows.Forms.Label createTournamentLable;
    }
}