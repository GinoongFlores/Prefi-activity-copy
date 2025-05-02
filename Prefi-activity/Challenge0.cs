using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prefi_activity
{
    /* 
     * Employee Commission & Bonus Calculator (Methods)
     * 
     * Description: A form with two TextBoxes (“Sales Amount” and “Years of Service”) 
     * and two Buttons (“Compute Commission” and “Compute Bonus”). 
     * Each button calls its own method to calculate either the sales commission or the loyalty bonus.
     */

    public partial class Challenge0 : Form
    {
        public Challenge0()
        {
            InitializeComponent();
        }

        // TODO: 1) Create a method to calculate the sales commission.
        // Description: This method should take the sales amount as a decimal parameter
        // and return the commission as a decimal. The commission is 5% of the sales amount.
        // Example: If sales = 1000, the method should return 50.

        // TODO: 2) Create a method to calculate the loyalty bonus.
        // Description: This method should take the years of service as an integer parameter
        // and return the bonus as a decimal. The bonus is $100 per year of service.
        // Example: If years = 5, the method should return 500.

        private void Challenge0_Load(object sender, EventArgs e)
        {
            // TODO: Optionally, initialize any default values or settings for the form. - Optional
        }

        private void txt_SalesAmount_TextChanged(object sender, EventArgs e)
        {
            // TODO: Handle any input validation or formatting for the Sales Amount TextBox, if needed. - Optional 
        }

        private void btn_Commission_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Parse the sales amount from txt_SalesAmount.
                // TODO: Validate that the sales amount is non-negative. Show an error message if invalid.

                // TODO: Call the CalculateCommission method to compute the commission.

                // TODO: Display the calculated commission in txt_Result.
            }
            catch (FormatException)
            {
                // TODO: Show an error message if the input is invalid.
            }
        }

        private void btn_Bonus_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Parse the years of service from txt_YearsOfService.
                // TODO: Validate that the years of service is non-negative. Show an error message if invalid.

                // TODO: Call the CalculateBonus method to compute the bonus.

                // TODO: Display the calculated bonus in txt_Result.
            }
            catch (FormatException)
            {
                // TODO: Show an error message if the input is invalid.
            }
        }

        private void txt_Result_Click(object sender, EventArgs e)
        {
            // TODO: Handle any additional logic for the result TextBox, if needed.
        }
    }
}