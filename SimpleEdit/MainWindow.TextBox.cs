using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace SimpleEdit
{
    /// <summary>
    /// Main form
    /// </summary>
    partial class MainWindow
    {
        /// <summary>
        /// Pastes text to given text box
        /// </summary>
        /// <param name="textBox">Text box</param>
        private void PasteToTextBox(RichTextBox textBox = null)
        {
            if (textBox == null && TryGetCurrentTextBox(out textBox) is false) return;
            textBox.Paste();
        }
        
        /// <summary>
        /// Copies text from selected text box
        /// </summary>
        private void CopySelectedText()
        {
            if (TryGetCurrentTextBox(out RichTextBox textBox) is false) return;
            textBox.Copy();
        }
        
        /// <summary>
        /// Cuts text from selected text box
        /// </summary>
        private void CutSelectedText()
        {
            if (TryGetCurrentTextBox(out RichTextBox textBox) is false) return;
            textBox.Cut();
        }
        
        /// <summary>
        /// Selects all text from selected text box
        /// </summary>
        private void SelectAllText()
        {
            if (TryGetCurrentTextBox(out RichTextBox textBox) is false) return;
            textBox.SelectAll();
        }
        
        /// <summary>
        /// Formats selected text 
        /// </summary>
        /// <param name="fontStyle">Font style</param>
        private void FormatSelectedText(FontStyle fontStyle)
        {
            if (TryGetCurrentTextBox(out RichTextBox textBox) is false) return;
            try
            {
                textBox.SelectionFont = new Font(textBox.Font, textBox.SelectionFont.Style ^ fontStyle);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Форматирование работает только на выделении с одинаковым шрифтом", "ошибОчка");
            }
        }

        /// <summary>
        /// Changes font
        /// </summary>
        private void ChangeFont()
        {
            if (TryGetCurrentTextBox(out RichTextBox textBox) is false) return;
            var fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            textBox.Font = fontDialog.Font;
        }

        /// <summary>
        /// Tries to get opened text box
        /// </summary>
        /// <param name="textBox">Text Box</param>
        /// <returns>Getting result</returns>
        private bool TryGetCurrentTextBox(out RichTextBox textBox)
        {
            if (TryGetCurrentTab(out TabPage tabPage))
            {
                textBox = GetTextBoxFromTab(tabPage);
                return true;
            }

            textBox = null;
            return false;
        }

        /// <summary>
        /// Creates new text box and reads file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>Text box</returns>
        private RichTextBox CreateTextBox(string filePath)
        {
            var textBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();

            if (GetFileRichTextBoxStreamType(filePath) == RichTextBoxStreamType.RichText)
            {
                textBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using var sr = new StreamReader(fs, Encoding.UTF8);
                textBox.Text = sr.ReadToEnd();
            }

            textBox.Dock = DockStyle.Fill;
            textBox.TextChanged += TextBoxTextChanged;
            return textBox;
        }

        /// <summary>
        /// Handles text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            RichTextBox textBox = (RichTextBox) sender;
            TabPage tabPage = (TabPage) textBox.Parent;
            
            if (tabPage.Text[0] != '*')
            {
                materialTabSelector.Hide();
                materialTabSelector.Show();
                tabPage.Text = "*" + tabPage.Text;
                UpdateFileNameStripStatusLabel();
            }
        }
        
        /// <summary>
        /// Handles context menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxContextMenuOpen(object sender, EventArgs e)
        {
            var contextMenuStrip = (ContextMenuStrip) sender;
            var textBox = (RichTextBox) contextMenuStrip.SourceControl;

            var cutToolStripMenuItem = (ToolStripMenuItem) contextMenuStrip.Items[0];
            var copyToolStripMenuItem = (ToolStripMenuItem) contextMenuStrip.Items[1];
            var pasteToolStripMenuItem = (ToolStripMenuItem) contextMenuStrip.Items[2];
            var deleteToolStripMenuItem = (ToolStripMenuItem) contextMenuStrip.Items[3];

            cutToolStripMenuItem.Enabled = textBox.SelectionLength > 0;
            copyToolStripMenuItem.Enabled = textBox.SelectionLength > 0;
            deleteToolStripMenuItem.Enabled = textBox.SelectionLength > 0;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
        }
        
        /// <summary>
        /// Gets File Rich Text Box Stream Type
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>Rich Text Box Stream Type</returns>
        private RichTextBoxStreamType GetFileRichTextBoxStreamType(string filePath) 
            => IsFileRichText(filePath) ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
    }
}