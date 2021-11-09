using System;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A Basic Calculator for windows forms apps
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the  user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Deletes the value to the right of the user's index
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Delete the value after the selected position
            DeleteTextValue();

            // Focus the user input text
            FocusInputText();
        }
        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds the / character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            // Insert "/" as a string character at the index position the user has selected
            InsertTextValue("/");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the * character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            // Insert "*" as a string character at the index position the user has selected
            InsertTextValue("*");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the - character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            // Insert "-" as a string character at the index position the user has selected
            InsertTextValue("-");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the + character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            // Insert "+" as a string character at the index position the user has selected
            InsertTextValue("+");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Calculates the current equation in UserInputText and outputs the result in CalculationResultText
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //TODO:Finish
            CalculateEquation();

            // Focus the user input text
            FocusInputText();
        }
        #endregion

        #region Number Methods

        /// <summary>
        /// Adds the . character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            // Insert "." as a string character at the index position the user has selected
            InsertTextValue(".");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 0 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {

            // Insert "0" as a string character at the index position the user has selected
            InsertTextValue("0");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 1 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            // Insert "1" as a string character at the index position the user has selected
            InsertTextValue("1");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 2 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            // Insert "2" as a string character at the index position the user has selected
            InsertTextValue("2");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 3 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            // Insert "3" as a string character at the index position the user has selected
            InsertTextValue("3");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 4 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            // Insert "4" as a string character at the index position the user has selected
            InsertTextValue("4");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 5 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            // Insert "5" as a string character at the index position the user has selected
            InsertTextValue("5");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 6 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            // Insert "6" as a string character at the index position the user has selected
            InsertTextValue("6");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 7 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            // Insert "7" as a string character at the index position the user has selected
            InsertTextValue("7");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 8 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            // Insert "8" as a string character at the index position the user has selected
            InsertTextValue("8");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 9 character to the UserInputText box
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguements</param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            // Insert "9" as a string character at the index position the user has selected
            InsertTextValue("9");

            // Focus the user input text
            FocusInputText();
        }
        #endregion

        /// <summary>
        /// Calculate the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {



        }

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();

        }

        /// <summary>
        /// Insert the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set Selection Length to 1
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            // If we dont have a value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart + 1);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set Selection Length to 1
            this.UserInputText.SelectionLength = 0;
        }
        #endregion
    }
}
