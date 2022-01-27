using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SimpleEdit
{
    /// <summary>
    /// Main form
    /// </summary>
    partial class MainWindow
    {
        /// <summary>
        /// Creates file in new tab
        /// </summary>
        /// <param name="newWindow">Open in new window or not</param>
        private void CreateFile(bool newWindow = false)
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid() + ".txt"; 
            using FileStream fileStream = File.Create(filePath);
            File.SetAttributes(fileStream.Name, FileAttributes.Hidden);
            fileStream.Close();

            if (newWindow)
            {
                MainWindow newForm = new MainWindow(false);
                newForm.Show();
                newForm.CreateNewTab(filePath, temp: true);
            }
            else
            {
                CreateNewTab(filePath, temp: true);
            }
        }
        
        /// <summary>
        /// Opens file with dialog
        /// </summary>
        private void OpenFile()
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt;*.rtf|Все файлы|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string[] filePaths = openFileDialog.FileNames;
            foreach (string filePath in filePaths)
            {
                CreateNewTab(filePath);
            }
        }

        /// <summary>
        /// Saves file
        /// </summary>
        /// <param name="tabPage">Tab page</param>
        /// <param name="saveFilePath">Path to save file</param>
        private void SaveFile(TabPage tabPage = null, string saveFilePath = null)
        {
            if (tabPage is null && TryGetCurrentTab(out tabPage) is false) return;
            if ((string) tabPage.Tag == "temp" && saveFilePath is null)
            {
                SaveFileAs(tabPage);
                return;
            }

            string filePath = tabPage.Name;
            RichTextBox textBox = GetTextBoxFromTab(tabPage);
            textBox.SaveFile(saveFilePath ?? filePath, GetFileRichTextBoxStreamType(filePath));

            if (IsTabSaved(tabPage) is false && saveFilePath is null)
            {
                tabPage.Text = tabPage.Text[1..];
                materialTabSelector.Hide();
                materialTabSelector.Show();
            }
        }

        /// <summary>
        /// Save file to new directory
        /// </summary>
        /// <param name="tabPage">Tab Page</param>
        private void SaveFileAs(TabPage tabPage = null)
        {
            if (tabPage is null && TryGetCurrentTab(out tabPage) is false) return;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = $"|*.{tabPage.Name.Split('.')[^1]}|All files|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() != DialogResult.OK) return;

            string filePath = dialog.FileName;
            RichTextBox textBox = GetTextBoxFromTab(tabPage);
            textBox.SaveFile(filePath, GetFileRichTextBoxStreamType(filePath));

            if ((string) tabPage.Tag == "temp")
            {
                RemoveTabPage(tabPage);
                Properties.Settings.Default.files.Remove(tabPage.Name);
                Properties.Settings.Default.Save();
                CreateNewTab(filePath);
            }
        }

        /// <summary>
        /// Saves all files
        /// </summary>
        private void SaveAllFiles()
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (IsDefaultTabPage(tabPage)) continue;
                SaveFile(tabPage);
            }
        }

        /// <summary>
        /// Backups file
        /// </summary>
        /// <param name="tabPage">Tab Page</param>
        private void BackupFile(TabPage tabPage)
        {
            string fileName = tabPage.Text.Replace("*", "");
            var splitFileName = fileName.Split(".");
            if (splitFileName.Length > 1)
            {
                fileName = $"{string.Join(".", splitFileName[..^1])}_backup ({DateTime.Now.ToString("dd.MM.yyyy hh-mm").Replace(":", ".")}).{splitFileName[^1]}";
            }
            string filePath = Path.Combine(_backupFolder, fileName);
            SaveFile(tabPage, filePath);
        }

        /// <summary>
        /// Backups all opened files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackupAllFiles(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (IsDefaultTabPage(tabPage)) continue;
                BackupFile(tabPage);
            }
        }

        /// <summary>
        /// Sets up auto save feature
        /// </summary>
        private void SetUpAutoSave()
        {
            if (Properties.Settings.Default.autoSave)
            {
                float autoSaveTime = Properties.Settings.Default.autoSaveTime;
                autoSaveTimer.Interval = (int)autoSaveTime;
                autoSaveTimer.Start();
            }
            else
            {
                autoSaveTimer.Stop();
            }
        }
        
        /// <summary>
        /// Sets up logging feature
        /// </summary>
        private void SetUpLogging()
        {
            if (Directory.Exists(_backupFolder) is false)
            {
                DirectoryInfo directory = Directory.CreateDirectory(_backupFolder);
                directory.Attributes = FileAttributes.Directory | FileAttributes.Hidden; 
            }
            
            float loggingTime = Properties.Settings.Default.loggingTime;
            loggingTimer.Interval = (int)loggingTime;
            loggingTimer.Start();
        }

        /// <summary>
        /// Checks weather file is rtf
        /// </summary>
        /// <param name="filePath">File Path</param>
        /// <returns>Check result</returns>
        private bool IsFileRichText(string filePath) => filePath[^4..] == ".rtf";

        /// <summary>
        /// Gets file name
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>Name of given file</returns>
        private string GetFileName(string filePath) => filePath.Split('\\').Last();

        /// <summary>
        /// Checks weather file is bigger than 4 MB
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>Check result</returns>
        private bool IsFileTooBig(string filePath) => new FileInfo(filePath).Length > 1024 * 1024 * 4;

    }
}