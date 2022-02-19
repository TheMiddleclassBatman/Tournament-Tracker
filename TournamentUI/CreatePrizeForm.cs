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
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TournamentUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;

        string validationErrorMessage = "";

        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameValueTextBox.Text, placeNumberValueTextBox.Text, prizeAmountValueTextBox.Text,
                    prizePercentageValueTextBox.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
            }

            else
            {
                MessageBox.Show(validationErrorMessage);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            validationErrorMessage = "";

            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValueTextBox.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
                validationErrorMessage = "Please enter 1 or 2 for place number";
                return output;
            }

            if (placeNumber < 1 || placeNumber > 2)
            {
                output = false;
                validationErrorMessage = "Please enter 1 or 2 for place number";
                return output;
            }

            if (placeNameValueTextBox.Text.Length == 0)
            {
                output = false;
                validationErrorMessage = "Please enter a valid place name";
                return output;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValueTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValueTextBox.Text, out prizePercentage);

            if (!prizeAmountValid || prizeAmount < 0)
            {
                output = false;
                validationErrorMessage = "Please a valid prize amount";
                return output;
            }

            if (!prizePercentageValid || prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
                validationErrorMessage = "Please a valid percentage amount";
                return output;
            }

            if (prizeAmountValid && prizePercentageValid)
            {
                if (prizeAmount != 0 && prizePercentage != 0)
                {
                    output = false;
                    validationErrorMessage = "Please choose either the amount or percentage method, not both.";
                    return output;
                }
            }

            return output;
        }
        private void prizeAmountValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (prizeAmountValueTextBox.Text != "0" && !string.IsNullOrEmpty(prizeAmountValueTextBox.Text))
            {
                prizePercentageValueTextBox.Enabled = false;
            }
            if (prizeAmountValueTextBox.Text == "0" || string.IsNullOrEmpty(prizeAmountValueTextBox.Text))
            {
                prizePercentageValueTextBox.Enabled = true;
                prizePercentageValueTextBox.Text = "0";
            }
        }

        private void prizePercentageValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (prizePercentageValueTextBox.Text != "0" && !string.IsNullOrEmpty(prizePercentageValueTextBox.Text))
            {
                prizeAmountValueTextBox.Enabled = false;
            }
            if (prizePercentageValueTextBox.Text == "0" || string.IsNullOrEmpty(prizePercentageValueTextBox.Text))
            {
                prizeAmountValueTextBox.Enabled = true;
                prizeAmountValueTextBox.Text = "0";
            }
        }
    }
}
