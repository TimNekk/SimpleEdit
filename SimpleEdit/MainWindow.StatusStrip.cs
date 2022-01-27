namespace SimpleEdit
{
    /// <summary>
    /// Main form
    /// </summary>
    partial class MainWindow
    {
        /// <summary>
        /// Update status strip
        /// </summary>
        private void UpdateFileNameStripStatusLabel()
        {
            fileNameStripStatusLabel.Text = tabControl.TabCount == 0 ? "" : tabControl.SelectedTab.Text;
        }
    }
}