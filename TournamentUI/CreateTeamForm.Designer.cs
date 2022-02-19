namespace TournamentUI
{
    public partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.createTeamButton = new System.Windows.Forms.Button();
            this.removeSelectedPlayersButton = new System.Windows.Forms.Button();
            this.selectedPlayersLable = new System.Windows.Forms.Label();
            this.selectedPlayersListBox = new System.Windows.Forms.ListBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.orLable = new System.Windows.Forms.Label();
            this.createPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.cellphoneValueTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressValueTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneLable = new System.Windows.Forms.Label();
            this.lastNameValueTextBox = new System.Windows.Forms.TextBox();
            this.emailLable = new System.Windows.Forms.Label();
            this.firstNameValueTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamLable = new System.Windows.Forms.Label();
            this.teamNameValueTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLable = new System.Windows.Forms.Label();
            this.createTeamLable = new System.Windows.Forms.Label();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.createPlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamButton
            // 
            this.createTeamButton.AutoSize = true;
            this.createTeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createTeamButton.FlatAppearance.BorderSize = 0;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.White;
            this.createTeamButton.Location = new System.Drawing.Point(481, 586);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(202, 67);
            this.createTeamButton.TabIndex = 40;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // removeSelectedPlayersButton
            // 
            this.removeSelectedPlayersButton.AutoSize = true;
            this.removeSelectedPlayersButton.BackColor = System.Drawing.Color.Red;
            this.removeSelectedPlayersButton.FlatAppearance.BorderSize = 0;
            this.removeSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPlayersButton.ForeColor = System.Drawing.Color.White;
            this.removeSelectedPlayersButton.Location = new System.Drawing.Point(918, 553);
            this.removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
            this.removeSelectedPlayersButton.Size = new System.Drawing.Size(128, 42);
            this.removeSelectedPlayersButton.TabIndex = 39;
            this.removeSelectedPlayersButton.Text = "Remove";
            this.removeSelectedPlayersButton.UseVisualStyleBackColor = false;
            this.removeSelectedPlayersButton.Click += new System.EventHandler(this.removeSelectedPlayersButton_Click);
            // 
            // selectedPlayersLable
            // 
            this.selectedPlayersLable.AutoSize = true;
            this.selectedPlayersLable.BackColor = System.Drawing.Color.Transparent;
            this.selectedPlayersLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPlayersLable.ForeColor = System.Drawing.Color.White;
            this.selectedPlayersLable.Location = new System.Drawing.Point(686, 94);
            this.selectedPlayersLable.Name = "selectedPlayersLable";
            this.selectedPlayersLable.Size = new System.Drawing.Size(239, 41);
            this.selectedPlayersLable.TabIndex = 38;
            this.selectedPlayersLable.Text = "Selected Players:";
            // 
            // selectedPlayersListBox
            // 
            this.selectedPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedPlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPlayersListBox.FormattingEnabled = true;
            this.selectedPlayersListBox.ItemHeight = 29;
            this.selectedPlayersListBox.Location = new System.Drawing.Point(693, 139);
            this.selectedPlayersListBox.Name = "selectedPlayersListBox";
            this.selectedPlayersListBox.Size = new System.Drawing.Size(353, 408);
            this.selectedPlayersListBox.TabIndex = 37;
            // 
            // addMemberButton
            // 
            this.addMemberButton.AutoSize = true;
            this.addMemberButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addMemberButton.FlatAppearance.BorderSize = 0;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.Location = new System.Drawing.Point(256, 219);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(168, 46);
            this.addMemberButton.TabIndex = 36;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // orLable
            // 
            this.orLable.AutoSize = true;
            this.orLable.BackColor = System.Drawing.Color.Transparent;
            this.orLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLable.ForeColor = System.Drawing.Color.White;
            this.orLable.Location = new System.Drawing.Point(185, 240);
            this.orLable.Name = "orLable";
            this.orLable.Size = new System.Drawing.Size(55, 28);
            this.orLable.TabIndex = 35;
            this.orLable.Text = "-OR-";
            // 
            // createPlayerGroupBox
            // 
            this.createPlayerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.createPlayerGroupBox.Controls.Add(this.lblFname);
            this.createPlayerGroupBox.Controls.Add(this.lblLname);
            this.createPlayerGroupBox.Controls.Add(this.lblEmail);
            this.createPlayerGroupBox.Controls.Add(this.lblCellPhone);
            this.createPlayerGroupBox.Controls.Add(this.createPlayerButton);
            this.createPlayerGroupBox.Controls.Add(this.cellphoneValueTextBox);
            this.createPlayerGroupBox.Controls.Add(this.emailAddressValueTextBox);
            this.createPlayerGroupBox.Controls.Add(this.cellphoneLable);
            this.createPlayerGroupBox.Controls.Add(this.lastNameValueTextBox);
            this.createPlayerGroupBox.Controls.Add(this.emailLable);
            this.createPlayerGroupBox.Controls.Add(this.firstNameValueTextBox);
            this.createPlayerGroupBox.Controls.Add(this.lastNameLable);
            this.createPlayerGroupBox.Controls.Add(this.firstNameLable);
            this.createPlayerGroupBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerGroupBox.ForeColor = System.Drawing.Color.White;
            this.createPlayerGroupBox.Location = new System.Drawing.Point(26, 271);
            this.createPlayerGroupBox.Name = "createPlayerGroupBox";
            this.createPlayerGroupBox.Size = new System.Drawing.Size(407, 390);
            this.createPlayerGroupBox.TabIndex = 34;
            this.createPlayerGroupBox.TabStop = false;
            this.createPlayerGroupBox.Text = "Create Player";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.White;
            this.lblFname.Location = new System.Drawing.Point(174, 83);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(0, 20);
            this.lblFname.TabIndex = 41;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.White;
            this.lblLname.Location = new System.Drawing.Point(174, 157);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(0, 20);
            this.lblLname.TabIndex = 42;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(174, 229);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 20);
            this.lblEmail.TabIndex = 43;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.ForeColor = System.Drawing.Color.White;
            this.lblCellPhone.Location = new System.Drawing.Point(174, 299);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(0, 20);
            this.lblCellPhone.TabIndex = 44;
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.AutoSize = true;
            this.createPlayerButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createPlayerButton.FlatAppearance.BorderSize = 0;
            this.createPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerButton.ForeColor = System.Drawing.Color.White;
            this.createPlayerButton.Location = new System.Drawing.Point(224, 329);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(171, 42);
            this.createPlayerButton.TabIndex = 24;
            this.createPlayerButton.Text = "Create Player";
            this.createPlayerButton.UseVisualStyleBackColor = false;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // cellphoneValueTextBox
            // 
            this.cellphoneValueTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneValueTextBox.Location = new System.Drawing.Point(178, 258);
            this.cellphoneValueTextBox.Name = "cellphoneValueTextBox";
            this.cellphoneValueTextBox.Size = new System.Drawing.Size(200, 38);
            this.cellphoneValueTextBox.TabIndex = 24;
            this.cellphoneValueTextBox.TextChanged += new System.EventHandler(this.cellphoneValueTextBox_TextChanged);
            // 
            // emailAddressValueTextBox
            // 
            this.emailAddressValueTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressValueTextBox.Location = new System.Drawing.Point(178, 188);
            this.emailAddressValueTextBox.Name = "emailAddressValueTextBox";
            this.emailAddressValueTextBox.Size = new System.Drawing.Size(200, 38);
            this.emailAddressValueTextBox.TabIndex = 26;
            this.emailAddressValueTextBox.TextChanged += new System.EventHandler(this.emailAddressValueTextBox_TextChanged);
            // 
            // cellphoneLable
            // 
            this.cellphoneLable.AutoSize = true;
            this.cellphoneLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLable.Location = new System.Drawing.Point(25, 261);
            this.cellphoneLable.Name = "cellphoneLable";
            this.cellphoneLable.Size = new System.Drawing.Size(122, 31);
            this.cellphoneLable.TabIndex = 23;
            this.cellphoneLable.Text = "Cellphone:";
            // 
            // lastNameValueTextBox
            // 
            this.lastNameValueTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameValueTextBox.Location = new System.Drawing.Point(178, 116);
            this.lastNameValueTextBox.Name = "lastNameValueTextBox";
            this.lastNameValueTextBox.Size = new System.Drawing.Size(200, 38);
            this.lastNameValueTextBox.TabIndex = 24;
            this.lastNameValueTextBox.TextChanged += new System.EventHandler(this.lastNameValueTextBox_TextChanged);
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLable.Location = new System.Drawing.Point(25, 191);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(75, 31);
            this.emailLable.TabIndex = 25;
            this.emailLable.Text = "Email:";
            // 
            // firstNameValueTextBox
            // 
            this.firstNameValueTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameValueTextBox.Location = new System.Drawing.Point(178, 42);
            this.firstNameValueTextBox.Name = "firstNameValueTextBox";
            this.firstNameValueTextBox.Size = new System.Drawing.Size(200, 38);
            this.firstNameValueTextBox.TabIndex = 1;
            this.firstNameValueTextBox.TextChanged += new System.EventHandler(this.firstNameValueTextBox_TextChanged);
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLable.Location = new System.Drawing.Point(25, 119);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(127, 31);
            this.lastNameLable.TabIndex = 23;
            this.lastNameLable.Text = "Last Name:";
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLable.Location = new System.Drawing.Point(22, 45);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(129, 31);
            this.firstNameLable.TabIndex = 0;
            this.firstNameLable.Text = "First Name:";
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(26, 174);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(398, 39);
            this.selectTeamMemberDropdown.TabIndex = 33;
            // 
            // selectTeamLable
            // 
            this.selectTeamLable.AutoSize = true;
            this.selectTeamLable.BackColor = System.Drawing.Color.Transparent;
            this.selectTeamLable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLable.ForeColor = System.Drawing.Color.White;
            this.selectTeamLable.Location = new System.Drawing.Point(19, 133);
            this.selectTeamLable.Name = "selectTeamLable";
            this.selectTeamLable.Size = new System.Drawing.Size(283, 38);
            this.selectTeamLable.TabIndex = 32;
            this.selectTeamLable.Text = "Select Team Member:";
            // 
            // teamNameValueTextBox
            // 
            this.teamNameValueTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameValueTextBox.ForeColor = System.Drawing.Color.Black;
            this.teamNameValueTextBox.Location = new System.Drawing.Point(26, 72);
            this.teamNameValueTextBox.Name = "teamNameValueTextBox";
            this.teamNameValueTextBox.Size = new System.Drawing.Size(398, 43);
            this.teamNameValueTextBox.TabIndex = 31;
            this.teamNameValueTextBox.TextChanged += new System.EventHandler(this.teamNameValueTextBox_TextChanged);
            // 
            // teamNameLable
            // 
            this.teamNameLable.AutoSize = true;
            this.teamNameLable.BackColor = System.Drawing.Color.Transparent;
            this.teamNameLable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLable.ForeColor = System.Drawing.Color.White;
            this.teamNameLable.Location = new System.Drawing.Point(19, 31);
            this.teamNameLable.Name = "teamNameLable";
            this.teamNameLable.Size = new System.Drawing.Size(170, 38);
            this.teamNameLable.TabIndex = 30;
            this.teamNameLable.Text = "Team Name:";
            // 
            // createTeamLable
            // 
            this.createTeamLable.AutoSize = true;
            this.createTeamLable.BackColor = System.Drawing.Color.Transparent;
            this.createTeamLable.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLable.ForeColor = System.Drawing.Color.White;
            this.createTeamLable.Location = new System.Drawing.Point(389, -5);
            this.createTeamLable.Name = "createTeamLable";
            this.createTeamLable.Size = new System.Drawing.Size(267, 59);
            this.createTeamLable.TabIndex = 29;
            this.createTeamLable.Text = "Create Team";
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.White;
            this.lblTeamName.Location = new System.Drawing.Point(22, 115);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(0, 20);
            this.lblTeamName.TabIndex = 41;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedPlayersButton);
            this.Controls.Add(this.selectedPlayersLable);
            this.Controls.Add(this.selectedPlayersListBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.orLable);
            this.Controls.Add(this.createPlayerGroupBox);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamLable);
            this.Controls.Add(this.teamNameValueTextBox);
            this.Controls.Add(this.teamNameLable);
            this.Controls.Add(this.createTeamLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.createPlayerGroupBox.ResumeLayout(false);
            this.createPlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button removeSelectedPlayersButton;
        private System.Windows.Forms.Label selectedPlayersLable;
        private System.Windows.Forms.ListBox selectedPlayersListBox;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label orLable;
        private System.Windows.Forms.GroupBox createPlayerGroupBox;
        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.TextBox cellphoneValueTextBox;
        private System.Windows.Forms.TextBox emailAddressValueTextBox;
        private System.Windows.Forms.Label cellphoneLable;
        private System.Windows.Forms.TextBox lastNameValueTextBox;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.TextBox firstNameValueTextBox;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamLable;
        private System.Windows.Forms.TextBox teamNameValueTextBox;
        private System.Windows.Forms.Label teamNameLable;
        private System.Windows.Forms.Label createTeamLable;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblTeamName;
    }
}