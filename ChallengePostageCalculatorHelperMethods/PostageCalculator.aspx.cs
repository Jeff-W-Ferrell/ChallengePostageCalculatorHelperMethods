using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostageCalculatorHelperMethods
{

    public partial class PostageCalculator : System.Web.UI.Page
    { 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void masterTextBoxRadioControl(object sender, EventArgs e)
        {
            calculateShipping();
        }

        private void calculateShipping()
        {
            //Do values in text/check boxes even exist?
            if (!detectValues()) return;
           
            //What is the volume?
            double volume = 0.0;
            if (!tryForVolume(out volume)) return;

            //What method was chosen- what's the multiplier?
            double multiplier = getMultiplier();

            //What's the cost?
            double cost = volume * multiplier;

            //Show the user cost.
            calcLabel.Text = String.Format("Your total cost to ship is: {0:C}", cost);
        }

        private bool detectValues()
        {
            if (widthTextBox.Text.Trim().Length == 0 || heightTextBox.Text.Trim().Length == 0)
                return false;
                
            if (!groundRadioButton.Checked &&
                !airRadioButton.Checked &&
                !nextDayRadioButton.Checked)
                return false;

            return true;
        }

        private bool tryForVolume(out double volume)
        {
            volume = 0.0;
            double width = 0.0;
            double height = 0.0;
            double length = 0.0;

            if (!Double.TryParse(widthTextBox.Text.Trim(), out width))
                return false;
                
            if (!Double.TryParse(heightTextBox.Text.Trim(), out height))
                return false;

            if (!Double.TryParse(lengthTextBox.Text.Trim(), out length))
                length = 1.0;

            volume = width * height * length;
            return true;
        }

        private double getMultiplier()
        {
            if (groundRadioButton.Checked)
                return .15;

            else if (airRadioButton.Checked)
                return .25;

            else if (nextDayRadioButton.Checked)
                return .45;

            else return 0.0;
        }
    }
}