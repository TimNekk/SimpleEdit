using MaterialSkin;
using MaterialSkin.Controls;
using SimpleEdit.Properties;

namespace SimpleEdit
{
    /// <summary>
    /// Settings form
    /// </summary>
    public partial class SettingsWindow : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;

        /// <summary>
        /// Settings Window constructor
        /// </summary>
        public SettingsWindow()
        {
            InitializeComponent();
            UpdateColorButtons();
            UpdateLabelsColors();
            UpdateAll();
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

        /// <summary>
        /// Updates all elements
        /// </summary>
        private void UpdateAll()
        {
            autoSaveSwitch.Checked = Settings.Default.autoSave;
            autoSaveTextBox.Text = (Settings.Default.autoSaveTime / 1000 / 60).ToString();
            loggingTextBox.Text = (Settings.Default.loggingTime / 1000 / 60).ToString();
            compileTextBox.Text = Settings.Default.compiler;
        }
    }
}