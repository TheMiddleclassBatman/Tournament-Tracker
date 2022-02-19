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

namespace TournamentUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";

            selectedTeamsListBox.DataSource = null;
            selectedTeamsListBox.DataSource = selectedTeams;
            selectedTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void setPrizezButton_Click(object sender, EventArgs e)
        {
            // Call the CreatePrizeForm.
            CreatePrizeForm form = new CreatePrizeForm(this);
            form.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a PrizeModel.
            // Take that PrizeModel and put it into our list of Selected Prizes.
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm form = new CreateTeamForm(this);
            form.Show();
        }

        private void removeSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void removeSelectedTeamPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectedTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate Data.
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValueTextBox.Text, out fee);

            if (!feeAcceptable || fee < 0)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", "Invalid Fee");
                return;
            }

            // Create our tournament model.
            TournamentModel tm = new TournamentModel();

            if (tournamentNameValueTextBox.Text.Length > 0)
            {
                tm.TournamentName = tournamentNameValueTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter a valid Tournament Name.", "Invalid Tournament Name");
                return;
            }

            tm.EntryFee = fee;
            tm.Prizes = selectedPrizes;

            if (selectedTeams.Count < 2)
            {
                MessageBox.Show("Please register at least two teams in the tournament", "Invalid Team Count");
                return;
            }
            else
            {
                tm.EnteredTeams = selectedTeams;
            }

            // Create our matchups.
            TournamentLogic.CreateRounds(tm);

            // Create Tournament Entry.
            // Create all of the prizes entries.
            // Create all of the team entries.
            GlobalConfig.Connection.CreateTournament(tm);

            // Emailing feature currently disabled.
            //tm.AlertUsersToNewRound();

            TournamentViewerForm form = new TournamentViewerForm(tm);
            form.Show();
            this.Close();
        }
    }
}
