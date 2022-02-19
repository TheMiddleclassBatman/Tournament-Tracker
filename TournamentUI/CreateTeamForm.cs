using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using System.Text.RegularExpressions;

namespace TournamentUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        bool createPlayerValidation = true;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            selectedPlayersListBox.DataSource = null;

            selectedPlayersListBox.DataSource = selectedTeamMembers;
            selectedPlayersListBox.DisplayMember = "FullName";
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValueTextBox.Text;
                p.LastName = lastNameValueTextBox.Text;
                p.EmailAddress = emailAddressValueTextBox.Text;
                p.CellphoneNumber = cellphoneValueTextBox.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValueTextBox.Text = "";
                lastNameValueTextBox.Text = "";
                emailAddressValueTextBox.Text = "";
                cellphoneValueTextBox.Text = "";

                lblFname.Text = "";
                lblLname.Text = "";
                lblEmail.Text = "";
                lblCellPhone.Text = "";
            }

            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (emailAddressValueTextBox.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValueTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        //private void addMemberButton_Click(object sender, EventArgs e)
        //{
            
        //}

        private void removeSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectedPlayersListBox.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);

                WireUpLists();
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            if (teamNameValueTextBox.Text.Length > 0)
            {
                t.TeamName = teamNameValueTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter a valid team name", "Invalid Team Name");
                return;
            }

            if (selectedTeamMembers.Count > 0)
            {
                t.TeamMembers = selectedTeamMembers;
            }
            else
            {
                MessageBox.Show("Please enter at least one team member", "Invalid Team Member Count");
                return;
            }

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
        private void firstNameValueTextBox_TextChanged(object sender, EventArgs e)
        {
            lblFname.Text = string.Empty;
            if (firstNameValueTextBox.Text.Length == 0)
            {
                lblFname.Text = "First Name cannot be EMPTY";
                createPlayerValidation = false;
            }
            if (firstNameValueTextBox.Text.Length > 0)
            {
                createPlayerValidation = true;
            }
        }

        private void lastNameValueTextBox_TextChanged(object sender, EventArgs e)
        {
            lblLname.Text = string.Empty;
            if (lastNameValueTextBox.Text.Length == 0)
            {
                lblLname.Text = "Last Name cannot be EMPTY";
                createPlayerValidation = false;
            }
            if (lastNameValueTextBox.Text.Length > 0)
            {
                createPlayerValidation = true;
            }
        }

        private void emailAddressValueTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isValidInternal = true;

            lblEmail.Text = string.Empty;
            if (emailAddressValueTextBox.Text.Length == 0)
            {
                lblEmail.Text = "Email ID cannot be EMPTY";
                isValidInternal = false;
            }
            if (!emailAddressValueTextBox.Text.Contains('.'))
            {
                lblEmail.Text = "Incorrect Format";
                isValidInternal = false;
            }
            if (emailAddressValueTextBox.Text.EndsWith(".")
                || emailAddressValueTextBox.Text.EndsWith("@")
                || emailAddressValueTextBox.Text.StartsWith(".")
                || emailAddressValueTextBox.Text.StartsWith("@"))
            {
                lblEmail.Text = "Incorrect Format";
                isValidInternal = false;
            }
            if (Regex.Matches(emailAddressValueTextBox.Text, "@").Count > 1
                || Regex.Matches(emailAddressValueTextBox.Text, "@").Count < 1)
            {
                lblEmail.Text = "Incorrect Format";
                isValidInternal = false;
            }

            createPlayerValidation = isValidInternal ? true : false;
        }

        private void cellphoneValueTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isValidInternal = false;
            lblCellPhone.Text = "10 digits required";
            if (cellphoneValueTextBox.Text.Length == 10)
            {
                lblCellPhone.Text = string.Empty;
                isValidInternal = true;
            }
            createPlayerValidation = isValidInternal ? true : false;
        }

        private void teamNameValueTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isValidInternal = true;
            lblTeamName.Text = string.Empty;
            if (teamNameValueTextBox.Text.Length == 0)
            {
                lblTeamName.Text = "Team Name cannot be EMPTY";
                isValidInternal = false;
            }

            createPlayerValidation = isValidInternal ? true : false;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }
    }
}
