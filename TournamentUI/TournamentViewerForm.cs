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
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchUpModel> selectedMatchups = new BindingList<MatchUpModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void Tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundDropdown.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currentRound = 1;

            foreach (List<MatchUpModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currentRound)
                {
                    currentRound = matchups.First().MatchupRound;
                    rounds.Add(currentRound);
                }
            }

            LoadMatchups(1);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchUpModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchUpModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedCheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }

            DisplayMatchupInfo();
        }

        private string ValidateData()
        {
            string output = "";
            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(teamOneScoreValueTextBox.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(teamTwoScoreValueTextBox.Text, out teamTwoScore);

            if (!scoreOneValid)
            {
                output = "The score one value is not a valid number";
            }
            else if (!scoreTwoValid)
            {
                output = "The score two value is not a valid number";
            }
            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "You did not enter a score for either team";
            }
            else if (teamOneScore == teamTwoScore)
            {
                output = "We do not allow ties in this application";
            }

            return output;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Input Error: { errorMessage }");
                return;
            }

            MatchUpModel m = (MatchUpModel)matchupListBox.SelectedItem;
            //double teamOneScore = 0;
            //double teamTwoScore = 0;

            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            m.Entries[0].TeamCompeting.TeamName = teamOneLable.Text;

                            bool scoreValid = double.TryParse(teamOneScoreValueTextBox.Text, out double teamOneScore);
                            if (scoreValid)
                            {
                                m.Entries[0].Score = teamOneScore;
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid score for team 1.");
                                return;
                            }

                        }
                        else
                        {
                            teamOneLable.Text = "Not Yet Set";
                            teamOneScoreValueTextBox.Text = "";
                        }
                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            bool scoreValid = double.TryParse(teamTwoScoreValueTextBox.Text, out double teamTwoScore);
                            if (scoreValid)
                            {
                                m.Entries[1].Score = teamTwoScore;
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid score for team 2.");
                                return;
                            }
                        }
                        else
                        {
                            teamOneLable.Text = "Not Yet Set";
                            teamOneScoreValueTextBox.Text = "";
                        }
                    }
                }

                try
                {
                    int currentRound = TournamentLogic.CheckCurrentRound(tournament);
                    int lastRound = rounds.Last();

                    TournamentLogic.UpdateTournamentResults(tournament);

                    if (currentRound == lastRound)
                    {
                        TournamentResultForm form = new TournamentResultForm();
                        form.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The application had the following error: {ex.Message }");
                    return;
                }

                LoadMatchups((int)roundDropdown.SelectedItem);
            }
        }
        

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            teamOneLable.Visible = isVisible;
            teamOneScoreLable.Visible = isVisible;
            teamOneScoreValueTextBox.Visible = isVisible;
            teamTwoLable.Visible = isVisible;
            teamTwoScoreLablee.Visible = isVisible;
            teamTwoScoreValueTextBox.Visible = isVisible;
            vsLable.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void LoadMatchup(MatchUpModel m)
        {
            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            teamOneLable.Text = m.Entries[0].TeamCompeting.TeamName;
                            teamOneScoreValueTextBox.Text = m.Entries[0].Score.ToString();

                            teamTwoLable.Text = "<bye>";
                            teamTwoScoreValueTextBox.Text = "0";
                        }
                        else
                        {
                            teamOneLable.Text = "Not Yet Set";
                            teamOneScoreValueTextBox.Text = "";
                        }
                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            teamTwoLable.Text = m.Entries[1].TeamCompeting.TeamName;
                            teamTwoScoreValueTextBox.Text = m.Entries[1].Score.ToString();
                        }
                        else
                        {
                            teamTwoLable.Text = "Not Yet Set";
                            teamTwoScoreValueTextBox.Text = "";
                        }
                    }
                }
            }
        }

        //private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    LoadMatchup((MatchUpModel)matchupListBox.SelectedItem);
        //}

        //private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    LoadMatchups((int)roundDropdown.SelectedItem);
        //}

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchUpModel)matchupListBox.SelectedItem);
        }

        private void unplayedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropdown.SelectedItem);
        }

        private void roundDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropdown.SelectedItem);
        }
    }
}
