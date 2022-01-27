using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using SimpleEdit.Properties;

namespace SimpleEdit
{
    /// <summary>
    /// Settings form
    /// </summary>
    partial class SettingsWindow
    {
        /// <summary>
        /// Handles Compile text box click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompileTextBoxClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Компилятор|csc.exe";
            openFileDialog.InitialDirectory = @"C:\Windows\Microsoft.NET\Framework";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string fileName = openFileDialog.FileName;

            Settings.Default.compiler = fileName;
            
            MaterialTextBox textBox = (MaterialTextBox)sender;
            textBox.Text = fileName;
        }
    }
}