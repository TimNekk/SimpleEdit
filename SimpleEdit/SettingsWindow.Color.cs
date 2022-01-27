using System;
using System.Drawing;
using SimpleEdit.Properties;

namespace SimpleEdit
{
    /// <summary>
    /// Settings form
    /// </summary>
    partial class SettingsWindow
    {
        /// <summary>
        /// Handles Color Blue button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorBlueRadioButtonClick(object sender, EventArgs e)
        {
            ChangeColor(Color.Blue);
        }
        
        /// <summary>
        /// Handles Color Yellow button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorYellowRadioButtonClick(object sender, EventArgs e)
        {
            ChangeColor(Color.Orange);
        }
        
        
        /// <summary>
        /// Handles Color Green button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorGreenRadioButtonClick(object sender, EventArgs e)
        {
            ChangeColor(Color.Green);
        }
        
        /// <summary>
        /// Handles Color Red button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorRedRadioButtonClick(object sender, EventArgs e)
        {
            ChangeColor(Color.Red);
        }
        
        /// <summary>
        /// Handles Color Purple button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPurpleRadioButtonClick(object sender, EventArgs e)
        {
            ChangeColor(Color.Purple);
        }

        /// <summary>
        /// Changes color
        /// </summary>
        /// <param name="color">Color</param>
        private void ChangeColor(Color color)
        {
            Settings.Default.color = color;
            Settings.Default.Save();
            UpdateColorTheme();
            Refresh();
        }

        /// <summary>
        /// Updates color buttons
        /// </summary>
        private void UpdateColorButtons()
        {
            var color = Settings.Default.color;
            switch (color.Name)
            {
                case "Blue":
                    colorBlueRadioButton.Checked = true;
                    break;
                case "Yellow":
                    colorOrangeRadioButton.Checked = true;
                    break;
                case "Green":
                    colorGreenRadioButton.Checked = true;
                    break;
                case "Red":
                    colorRedRadioButton.Checked = true;
                    break;
                case "Purple":
                    colorPurpleRadioButton.Checked = true;
                    break;
            }
        }
    }
}