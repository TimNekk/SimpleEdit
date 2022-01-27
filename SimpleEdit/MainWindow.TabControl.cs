using System;
using System.Collections.Specialized;
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
        /// Gets text box from given tab
        /// </summary>
        /// <param name="tabPage">Tab Page</param>
        /// <returns>Text Box</returns>
        private RichTextBox GetTextBoxFromTab(TabPage tabPage)
        {
            return (RichTextBox) tabPage.Controls[0];
        }
        
        /// <summary>
        /// Tries to get opened tab
        /// </summary>
        /// <param name="tabPage">Tab Page</param>
        /// <returns>Getting result</returns>
        private bool TryGetCurrentTab(out TabPage tabPage)
        {
            tabPage = tabControl.SelectedTab;
            
            return tabPage is not null && IsDefaultTabPage(tabPage) is false;
        }

        /// <summary>
        /// Creates new tab and reads file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <param name="temp">Is file temp</param>
        private void CreateNewTab(string filePath, bool temp = false)
        {
            if (IsFileOpened(filePath)) return;
            if (IsFileTooBig(filePath))
            {
                MessageBox.Show("Файл слишком большой (макс. 4 МБ)");
                return;
            }

            var tabPage = new TabPage();
            tabPage.Padding = new Padding(5, 5, 5, 41);
            tabPage.Dock = DockStyle.Fill;
            tabPage.BackColor = Color.White;
            tabPage.Name = filePath;
            tabPage.Text = temp ? " Безымянный" : GetFileName(filePath);
            if (temp) tabPage.Tag = "temp";
            
            RichTextBox textBox;
            Cursor.Current = Cursors.WaitCursor;
            try { textBox = CreateTextBox(filePath); }
            catch (Exception e) { MessageBox.Show(e.Message); return; }
            finally { Cursor.Current = Cursors.Default; }
            tabPage.Controls.Add(textBox);
            
            ContextMenuStrip contextMenuStrip = CreateContextMenuStrip(new ToolStripItem[]
            {
                CreateToolStripMenuItem("Вырезать", CutToolStripItemClick), CreateToolStripMenuItem("Копировать", CopyToolStripItemClick),
                CreateToolStripMenuItem("Вставить", PasteToolStripItemClick), CreateToolStripMenuItem("Выделить всё", SelectAllToolStripItemClick),
                new ToolStripSeparator(), 
                CreateToolStripMenuItem("Жирный", BoldToolStripItemClick), CreateToolStripMenuItem("Курсив", ItalicToolStripItemClick), 
                CreateToolStripMenuItem("Подчеркнутый", UnderlineToolStripItemClick), CreateToolStripMenuItem("Зачеркнутый", StrikeToolStripItemClick)
            }, TextBoxContextMenuOpen);
            textBox.ContextMenuStrip = contextMenuStrip;
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;
            
            UpdateFileNameStripStatusLabel();
            UpdateToolStripButtons();
            
            if (tabControl.TabCount == 2) SetDefaultTabVisibility(false);
            if (Properties.Settings.Default.files.Contains(filePath) is false) Properties.Settings.Default.files.Add(filePath);

        }
        
        /// <summary>
        /// Handles tab switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            fileNameStripStatusLabel.Text = tabControl.SelectedTab.Text;
        }

        /// <summary>
        /// Checks if tab is saves
        /// </summary>
        /// <param name="tabPage">Tab page</param>
        /// <returns>Check result</returns>
        private bool IsTabSaved(TabPage tabPage)
        {
            return tabPage.Text[0] != '*';
        }
        
        /// <summary>
        /// Closes tab
        /// </summary>
        /// <param name="tabPage">Tab Page</param>
        /// <param name="ignoreRemove">Ignore remove or not</param>
        /// <returns>Remove result</returns>
        private bool CloseTab(TabPage tabPage = null, bool ignoreRemove = false)
        {
            if (tabPage is null && TryGetCurrentTab(out tabPage) is false) return false;
            if (IsDefaultTabPage(tabPage)) return true;

            DialogResult confirmResult = DialogResult.Ignore;
            if (IsTabSaved(tabPage) is false || (string) tabPage.Tag == "temp")
            {
                confirmResult =  MessageBox.Show($"Вы хотите сохранить изменения в файле \"{tabPage.Text[1..]}\"",
                    "Подтверждение закрытия",
                    MessageBoxButtons.YesNoCancel);
            }

            switch (confirmResult)
            {
                case DialogResult.Cancel:
                    return false;
                case DialogResult.Yes:
                    SaveFile(tabPage);
                    if (tabControl.TabCount == 1) SetDefaultTabVisibility(true);
                    RemoveTabPage(tabPage);
                    return true;
                case DialogResult.No:
                    if (tabControl.TabCount == 1) SetDefaultTabVisibility(true);
                    Properties.Settings.Default.files.Remove(tabPage.Name);
                    RemoveTabPage(tabPage);
                    return true;
                case DialogResult.Ignore:
                    if (tabControl.TabCount == 1) SetDefaultTabVisibility(true);
                    if (ignoreRemove) Properties.Settings.Default.files.Remove(tabPage.Name);
                    RemoveTabPage(tabPage);
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Sets Default Tab Visibility
        /// </summary>
        /// <param name="visible">Is visible</param>
        private void SetDefaultTabVisibility(bool visible)
        {
            materialTabSelector.Visible = !visible;
            defaultTabPage.Parent = visible ? tabControl : null;
        }

        /// <summary>
        /// Is it default tab page
        /// </summary>
        /// <param name="tabPage">Tab Page</param>
        /// <returns></returns>
        private bool IsDefaultTabPage(TabPage tabPage) => tabPage == defaultTabPage;

        /// <summary>
        /// Remove tab page
        /// </summary>
        /// <param name="tabPage">Tab page</param>
        private void RemoveTabPage(TabPage tabPage)
        {
            try
            {
                tabControl.TabPages.Remove(tabPage);
            }
            catch (Exception)
            {
                
            }

            UpdateFileNameStripStatusLabel();
            UpdateToolStripButtons();
        }

        /// <summary>
        /// Checks if file is opened
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>Check result</returns>
        private bool IsFileOpened(string filePath)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Name == filePath) return true;
            }
            return false;
        }

        /// <summary>
        /// Loads previously opened tabs
        /// </summary>
        private void LoadPreviousTabs()
        {
            Properties.Settings.Default.files ??= new StringCollection();

            foreach (string filePath in Properties.Settings.Default.files)
            {
                try
                {
                    CreateNewTab(filePath);
                }
                catch (Exception)
                {
                    // Properties.Settings.Default.files.Remove(filePath);
                }
            }
        }

        /// <summary>
        /// Undo or redo text box change
        /// </summary>
        /// <param name="redo">If redo</param>
        private void Undo(bool redo = false)
        {
            if (TryGetCurrentTextBox(out RichTextBox textBox) is false) return;
            if (redo)
            {
                textBox.Redo();
            }
            else
            {
                textBox.Undo();
            }
        }
    }
}