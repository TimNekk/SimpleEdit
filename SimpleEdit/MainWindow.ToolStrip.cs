using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleEdit
{
    /// <summary>
    /// Main form
    /// </summary>
    partial class MainWindow
    {
        /// <summary>
        /// Handles New button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolStripItemClick(object sender, EventArgs e)
        {
            CreateFile();
        }
        
        /// <summary>
        /// Handles New Window button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewWindowToolStripItemClick(object sender, EventArgs e)
        {
            CreateFile(newWindow: true);
        }
        
        /// <summary>
        /// Handles Save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripItemClick(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// Handles Save as button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripItemClick(object sender, EventArgs e)
        {
            SaveFileAs();
        }
        
        /// <summary>
        /// Handles Save all button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAllToolStripItemClick(object sender, EventArgs e)
        {
            SaveAllFiles();
        }

        /// <summary>
        /// Handles Open button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripItemClick(object sender, EventArgs e)
        {
            OpenFile();
        }

        /// <summary>
        /// Handles Close button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripItemClick(object sender, EventArgs e)
        {
            CloseTab(ignoreRemove: true);
        }
        
        /// <summary>
        /// Handles Exit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles Copy button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripItemClick(object sender, EventArgs e)
        {
            CopySelectedText();
        }

        /// <summary>
        /// Handles Paste button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteToolStripItemClick(object sender, EventArgs e)
        {
            PasteToTextBox();
        }

        /// <summary>
        /// Handles Cut button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripItemClick(object sender, EventArgs e)
        {
            CutSelectedText();
        }

        /// <summary>
        /// Handles Select all button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllToolStripItemClick(object sender, EventArgs e)
        {
            SelectAllText();
        }

        /// <summary>
        /// Handles Bold button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoldToolStripItemClick(object sender, EventArgs e)
        {
            FormatSelectedText(FontStyle.Bold);
        }

        /// <summary>
        /// Handles Italic button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItalicToolStripItemClick(object sender, EventArgs e)
        {
            FormatSelectedText(FontStyle.Italic);
        }

        /// <summary>
        /// Handles Underline button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnderlineToolStripItemClick(object sender, EventArgs e)
        {
            FormatSelectedText(FontStyle.Underline);
        }

        /// <summary>
        /// Handles Strike button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrikeToolStripItemClick(object sender, EventArgs e)
        {
            FormatSelectedText(FontStyle.Strikeout);
        }
        
        /// <summary>
        /// Handles Undo button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoToolStripItemClick(object sender, EventArgs e)
        {
            Undo();
        }
        
        /// <summary>
        /// Handles Redo button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedoToolStripItemClick(object sender, EventArgs e)
        {
            Undo(redo: true);
        }
        
        /// <summary>
        /// Handles Font button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontToolStripItemClick(object sender, EventArgs e)
        {
            ChangeFont();
        }

        /// <summary>
        /// Handles Highlight button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighlightToolStripItemClick(object sender, EventArgs e)
        {
            ColorizeCSharpCode();
        }
        
        /// <summary>
        /// Handles Compile button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompileToolStripItemClick(object sender, EventArgs e)
        {
            CompileCSharpCode();
        }
        
        /// <summary>
        /// Handles Settings button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingToolStripItemClick(object sender, EventArgs e)
        {
            var settingsForm = new SettingsWindow();
            settingsForm.ShowDialog();
            Refresh();
            SetUpAutoSave();
            SetUpLogging();
        }

        /// <summary>
        /// Handles Edit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditToolStripButtonClick(object sender, EventArgs e)
        {
            bool tabExist = TryGetCurrentTab(out TabPage tabPage);
            if (tabExist)
            {
                var textBox = GetTextBoxFromTab(tabPage);
                cutToolStripItem.Enabled = textBox.SelectionLength > 0;
                copyToolStripItem.Enabled = textBox.SelectionLength > 0;
                pasteToolStripItem.Enabled = Clipboard.ContainsText();
            }
            else
            {
                cutToolStripItem.Enabled = false;
                copyToolStripItem.Enabled = false;
                pasteToolStripItem.Enabled = false;
            }
        }

        /// <summary>
        /// Updates Tool Strip Buttons visibility
        /// </summary>
        private void UpdateToolStripButtons()
        {
            bool tabExist = TryGetCurrentTab(out TabPage tabPage);
            italicToolStripItem.Enabled = tabExist;
            boldToolStripItem.Enabled = tabExist;
            underlineToolStripItem.Enabled = tabExist;
            strikeToolStripItem.Enabled = tabExist;
            saveToolStripItem.Enabled = tabExist;
            saveAsToolStripItem.Enabled = tabExist;
            closeToolStripItem.Enabled = tabExist;
            selectAllToolStripItem.Enabled = tabExist;
            saveAllToolStripItem.Enabled = tabExist;
            fontToolStripItem.Enabled = tabExist;

            if (tabExist)
            {
                bool isCodeFile = tabPage.Text.EndsWith(".cs");
                highlightToolStripItem.Enabled = isCodeFile;
                compileToolStripItem.Enabled = isCodeFile;
            }
        }
    }
}