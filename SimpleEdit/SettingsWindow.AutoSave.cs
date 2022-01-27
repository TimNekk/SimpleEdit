using System;

namespace SimpleEdit
{
    /// <summary>
    /// Settings form
    /// </summary>
    partial class SettingsWindow
    {
        /// <summary>
        /// Handles Auto Save Switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoSaveSwitchClicked(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoSave = autoSaveSwitch.Checked;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Handles Auto save text box text change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoSaveTextBoxTextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(autoSaveTextBox.Text, out int time) && time > 0)
            {
                Properties.Settings.Default.autoSaveTime = time * 60 * 1000;
                Properties.Settings.Default.Save();
            }
            else
            {
                autoSaveTextBox.Text = "";
            }
        }
    }
}