using System;
using System.Windows.Forms;

namespace SimpleEdit
{
    /// <summary>
    /// Main form
    /// </summary>
    partial class MainWindow
    {
        /// <summary>
        /// Create Tool Strip Menu Item
        /// </summary>
        /// <param name="text">Item text</param>
        /// <param name="clickEventHandler">Click even handler</param>
        /// <returns></returns>
        private ToolStripMenuItem CreateToolStripMenuItem(string text, EventHandler clickEventHandler=null)
        {
            var toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = text;
            toolStripMenuItem.Click += clickEventHandler;
            return toolStripMenuItem;
        }

        /// <summary>
        /// Creates Context Menu Strip
        /// </summary>
        /// <param name="items">Items of strip</param>
        /// <param name="openEventHandler">Open event handler</param>
        /// <returns></returns>
        private ContextMenuStrip CreateContextMenuStrip(ToolStripItem[] items, EventHandler openEventHandler=null)
        {
            var contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.AddRange(items);
            contextMenuStrip.Opened += openEventHandler;
            return contextMenuStrip;
        }
    }
}