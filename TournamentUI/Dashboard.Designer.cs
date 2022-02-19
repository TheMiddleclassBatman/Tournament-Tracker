namespace TournamentUI
{
    partial class dashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardForm));
            this.orLable = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.loadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentsLable = new System.Windows.Forms.Label();
            this.tournamentDashboardLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orLable
            // 
            this.orLable.AutoSize = true;
            this.orLable.BackColor = System.Drawing.Color.Transparent;
            this.orLable.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLable.ForeColor = System.Drawing.Color.White;
            this.orLable.Location = new System.Drawing.Point(477, 421);
            this.orLable.Name = "orLable";
            this.orLable.Size = new System.Drawing.Size(94, 51);
            this.orLable.TabIndex = 37;
            this.orLable.Text = "-Or-";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.AutoSize = true;
            this.createTournamentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createTournamentButton.FlatAppearance.BorderSize = 0;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.White;
            this.createTournamentButton.Location = new System.Drawing.Point(341, 522);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(375, 98);
            this.createTournamentButton.TabIndex = 36;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.AutoSize = true;
            this.loadTournamentButton.BackColor = System.Drawing.Color.DarkOrange;
            this.loadTournamentButton.FlatAppearance.BorderSize = 0;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.loadTournamentButton.ForeColor = System.Drawing.Color.White;
            this.loadTournamentButton.Location = new System.Drawing.Point(412, 310);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(243, 72);
            this.loadTournamentButton.TabIndex = 35;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
            // 
            // loadExistingTournamentDropdown
            // 
            this.loadExistingTournamentDropdown.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.loadExistingTournamentDropdown.FormattingEnabled = true;
            this.loadExistingTournamentDropdown.Location = new System.Drawing.Point(260, 227);
            this.loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            this.loadExistingTournamentDropdown.Size = new System.Drawing.Size(553, 49);
            this.loadExistingTournamentDropdown.TabIndex = 34;
            // 
            // loadExistingTournamentsLable
            // 
            this.loadExistingTournamentsLable.AutoSize = true;
            this.loadExistingTournamentsLable.BackColor = System.Drawing.Color.Transparent;
            this.loadExistingTournamentsLable.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentsLable.ForeColor = System.Drawing.Color.White;
            this.loadExistingTournamentsLable.Location = new System.Drawing.Point(250, 147);
            this.loadExistingTournamentsLable.Name = "loadExistingTournamentsLable";
            this.loadExistingTournamentsLable.Size = new System.Drawing.Size(550, 59);
            this.loadExistingTournamentsLable.TabIndex = 33;
            this.loadExistingTournamentsLable.Text = "Load Existing Tournaments";
            // 
            // tournamentDashboardLable
            // 
            this.tournamentDashboardLable.AutoSize = true;
            this.tournamentDashboardLable.BackColor = System.Drawing.Color.Transparent;
            this.tournamentDashboardLable.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashboardLable.ForeColor = System.Drawing.Color.White;
            this.tournamentDashboardLable.Location = new System.Drawing.Point(183, 52);
            this.tournamentDashboardLable.Name = "tournamentDashboardLable";
            this.tournamentDashboardLable.Size = new System.Drawing.Size(697, 81);
            this.tournamentDashboardLable.TabIndex = 32;
            this.tournamentDashboardLable.Text = "Tournament Dashboard";
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.orLable);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropdown);
            this.Controls.Add(this.loadExistingTournamentsLable);
            this.Controls.Add(this.tournamentDashboardLable);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "dashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orLable;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropdown;
        private System.Windows.Forms.Label loadExistingTournamentsLable;
        private System.Windows.Forms.Label tournamentDashboardLable;
    }
}

