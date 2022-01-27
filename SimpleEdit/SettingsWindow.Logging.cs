using System;

namespace SimpleEdit
{
    /// <summary>
    /// Settings form
    /// </summary>
    partial class SettingsWindow
    {
        /// <summary>
        /// Handles logging text box text change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoggingTextBoxTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(loggingTextBox.Text, out int time) && time > 0)
            {
                Properties.Settings.Default.loggingTime = time * 60 * 1000;
                Properties.Settings.Default.Save();
            }
            else
            {
                loggingTextBox.Text = "";
            }
        }
    }
}