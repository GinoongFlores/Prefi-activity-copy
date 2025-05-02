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
    public partial class Challenge1 : Form
    {
        public Challenge1()
        {
            InitializeComponent();
        }

        /* 
         
         2. Library Fine Estimator (Method Overloading)

         Description: Create a Windows Form that helps students calculate overdue library fines. Depending on which inputs are provided, three overloads of the same method apply different rules:

         Basic: fine based on days overdue only

         Category-based: adds higher rates for special collections

         Member discount: gives a discount to premium members

        Learning Goals:

            - Define multiple methods with the same name but different parameter signatures

            - Observe how C#’s compiler selects the correct overload based on argument lists
         
         */

        // Take note: TODO 1-4 uses the same method name "CalculateFine". This is method overloading.

        // TODO: 1) Create a method to calculate the basic fine.
        // Description: This method should take the number of overdue days as an integer parameter
        // and return the fine as a decimal. The fine is $0.50 per day.
        // Example: If days = 5, the method should return 2.50.

        // TODO: 2) Create a method to calculate the fine based on the category of the book.
        // Description: This method should take the number of overdue days and the category as parameters.
        // Use the following rates:
        // - "Reference": $1.00 per day
        // - "Multimedia": $0.75 per day
        // - Default: $0.50 per day (same as the basic fine)
        // Hint: Use a switch statement or a Dictionary to determine the rate.

        // TODO: 3) Create a method to calculate the fine with a premium member discount.
        // Description: This method should take the number of overdue days, the category, and a boolean
        // indicating whether the user is a premium member. Premium members get a 20% discount on the total fine.
        // Hint: Use the method from TODO 2 to calculate the base fine, then apply the discount if applicable.

        // TODO: 4) Implement the button click event to calculate the fine.
        // Description: When the "Calculate Fine" button is clicked, this event should:
        // - Parse the number of overdue days from the txtDays TextBox.
        // - Get the selected category from the cmbCategory ComboBox.
        // - Check if the user is a premium member using the chkPremium CheckBox.
        // - Call the appropriate method (from TODO 1, 2, or 3) to calculate the fine.
        // - Display the calculated fine in the txt_Result TextBox.
        // Hint: Use conditional logic to determine which method to call based on the inputs.

        private void btn_Calcuate_Click(object sender, EventArgs e)
        {
            // TODO: Parse the number of overdue days from txtDays.
            // TODO: Validate that the number of days is non-negative. Show an error message if invalid.

            // TODO: Get the selected category from cmbCategory.
            // TODO: Check if the user is a premium member using chkPremium.

            // TODO: Call the appropriate CalculateFine method based on the inputs.
            // - If no category is selected, call the basic fine method (TODO 1).
            // - If a category is selected, call the category-based fine method (TODO 2).
            // - If the user is a premium member, call the premium member fine method (TODO 3).

            // TODO: Display the calculated fine in txt_Result.
        }

        private void Challenge1_Load(object sender, EventArgs e)
        {
            // TODO: Populate the cmbCategory ComboBox with the following options:
            // - "General"
            // - "Reference"
            // - "Multimedia"
            // Hint: Use the Items.Add() method to add each option.

            // Given (already): 

            cmbCategory.Items.Add("General");
            cmbCategory.Items.Add("Reference");
            cmbCategory.Items.Add("Multimedia");

            // Optionally, set a default value
            cmbCategory.SelectedIndex = 0; // Select "General" by default

        }
    }
}