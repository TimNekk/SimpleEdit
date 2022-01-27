using System;
using System.Drawing;
using System.Windows.Forms;
using SimpleEdit.Properties;

namespace SimpleEdit
{
    /// <summary>
    /// Settings form
    /// </summary>
    partial class SettingsWindow
    {
        /// <summary>
        /// Updates colors of labels
        /// </summary>
        private void UpdateLabelsColors()
        {
            keyWordsColorLabel.ForeColor = Settings.Default.keyWordsColor;
            symbolsColorLabel.ForeColor = Settings.Default.symbolsColor;
            numbersColorLabel.ForeColor = Settings.Default.numbersColor;
            stringsColorLabel.ForeColor = Settings.Default.stringsColor;
            variablesColorLabel.ForeColor = Settings.Default.variablesColor;
            methodsColorLabel.ForeColor = Settings.Default.methodsColor;
            classesColorLabel.ForeColor = Settings.Default.classesColor;
            commentsColorLabel.ForeColor = Settings.Default.commentsColor;
        }
        
        /// <summary>
        /// Handles Key word label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyWordColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.keyWordsColor = color;
            Settings.Default.Save();
        }
        
        /// <summary>
        /// Handles Symbols label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SymbolsColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.symbolsColor = color;
            Settings.Default.Save();
        }
        
        /// <summary>
        /// Handles Numbers label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumbersColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.numbersColor = color;
            Settings.Default.Save();
        }
        
        /// <summary>
        /// Handles Strings label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StringsColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.stringsColor = color;
            Settings.Default.Save();
        }
        
        /// <summary>
        /// Handles Variables label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VariablesColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.variablesColor = color;
            Settings.Default.Save();
        }
        
        /// <summary>
        /// Handles Methods label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MethodsColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.methodsColor = color;
            Settings.Default.Save();
        }
        
        /// <summary>
        /// Handles Classes label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassesColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.classesColor = color;
            Settings.Default.Save();
        }

        /// <summary>
        /// Handles Comments label click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommentsColorLabelClick(object sender, EventArgs e)
        {
            Color color = ChangeColor((Label)sender);
            Settings.Default.commentsColor = color;
            Settings.Default.Save();
        }

        /// <summary>
        /// Changes color of label
        /// </summary>
        /// <param name="label">Label</param>
        /// <returns>Color</returns>
        private Color ChangeColor(Label label)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            label.ForeColor = colorDialog.Color;
            return colorDialog.Color;
        }
    }
}