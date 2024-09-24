
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Assignment2 : Form
    {
        // Enum for car colors
        public enum CarColor
        {
            Red,
            Blue,
            Black,
            White
        }

        // Member variable to store the selected color
        private CarColor selectedColor;

        public Assignment2()
        {
            InitializeComponent();
        }

        private void Assignment2_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // Reset the summary label text color
            lblPurchaseSummary.ForeColor = Color.Black;

            // Check if a make and model is selected
            if (lstMakeModel.SelectedItem == null)
            {
                lblPurchaseSummary.ForeColor = Color.Red;
                lblPurchaseSummary.Text = "Please select a make and model.";
                return;
            }

            // Validate and parse the year
            if (!int.TryParse(txtYear.Text, out int year))
            {
                lblPurchaseSummary.ForeColor = Color.Red;
                lblPurchaseSummary.Text = "Invalid year. Please enter a valid number.";
                return;
            }
            // Get the selected features
            List<string> features = new List<string>();
            if (chkPowerWindows.Checked) features.Add("Power Windows");
            if (chkAirConditioning.Checked) features.Add("Air Conditioning");
            if (chkSiriusRadio.Checked) features.Add("Sirius Radio");
            if (chkLaneAssistance.Checked) features.Add("Lane Assistance");

            // Use a switch statement for color
            string colorName = selectedColor switch
            {
                CarColor.Red => "red",
                CarColor.Blue => "blue",
                CarColor.Black => "black",
                CarColor.White => "white",
                _ => "unknown color"
            };

            // Create the purchase summary
            string makeModel = lstMakeModel.SelectedItem.ToString();
            string featuresList = features.Count > 0 ? string.Join(", ", features) : "no additional features";
            lblPurchaseSummary.Text = $"You have purchased a {colorName} {year} {makeModel} with the following features: {featuresList}.";

        }

    }
}

