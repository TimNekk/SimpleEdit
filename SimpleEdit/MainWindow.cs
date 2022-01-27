using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SimpleEdit.Properties;

namespace SimpleEdit
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainWindow : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private readonly string _backupFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "backup");
        private readonly string _compilationsFolder = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "compilations");
        private readonly string _keyWordsFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "src", "keywords.txt");
        private readonly string _typesFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "src", "types.txt");

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="loadPreviousTabs">Load Previous Tabs or not</param>
        public MainWindow(bool loadPreviousTabs = true)
        {
            InitializeComponent();
            _materialSkinManager.AddFormToManage(this);
            UpdateColorTheme();
            if (loadPreviousTabs) LoadPreviousTabs();
            SetUpAutoSave();
            SetUpLogging();
        }

        /// <summary>
        /// Handles form closing
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Settings.Default.Save();
            
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (CloseTab(tabPage) is false)
                {
                    e.Cancel = true;
                }
            }
            
            Settings.Default.Save();
        }

        /// <summary>
        /// Handles form resizing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnResize(object sender, EventArgs e)
        {
            var (centerWidth, centerHeight) = (Width / 2, tabControl.Height / 2);
            openButton.Location = new Point(centerWidth - openButton.Width / 2, centerHeight - openButton.Height * 2);
            createButton.Location = new Point(centerWidth - createButton.Width / 2, centerHeight - createButton.Height / 2);
            dragLabel.Location = new Point(centerWidth - dragLabel.Width / 2, centerHeight + dragLabel.Height * 2);
        }

        /// <summary>
        /// Handles file drag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefaultTabPageDragEnter(object sender, DragEventArgs e) 
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        
        /// <summary>
        /// Handles file drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefaultTabPageDragDrop(object sender, DragEventArgs e) 
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                CreateNewTab(file);
            }
        }
        
        /// <summary>
        /// Updates color theme
        /// </summary>
        private void UpdateColorTheme()
        {
            var color = Settings.Default.color;
            switch (color.Name)
            {
                case "Blue":
                    _materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue600, Primary.Blue50, Accent.Blue200, TextShade.WHITE);
                    break;
                case "Orange":
                    _materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange400, Primary.Orange600, Primary.Orange50, Accent.Orange200, TextShade.WHITE);
                    break;
                case "Green":
                    _materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green600, Primary.Green50, Accent.Green200, TextShade.WHITE);
                    break;
                case "Purple":
                    _materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple600, Primary.Purple50, Accent.Purple200, TextShade.WHITE);
                    break;
                case "Red":
                    _materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red600, Primary.Red50, Accent.Red200, TextShade.WHITE);
                    break;
            }
            Refresh();
        }
    }
}
