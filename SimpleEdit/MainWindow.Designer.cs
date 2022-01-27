using System.Drawing;
using System.Windows.Forms;

namespace SimpleEdit
{
    /// <summary>
    /// Main class
    /// </summary>
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fileToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.fontToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.italicToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.highlightToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripIcons = new System.Windows.Forms.ToolStrip();
            this.undoIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newFileIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.boldIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.strikeIconToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fileNameStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.defaultTabPage = new System.Windows.Forms.TabPage();
            this.dragLabel = new MaterialSkin.Controls.MaterialLabel();
            this.createButton = new MaterialSkin.Controls.MaterialButton();
            this.openButton = new MaterialSkin.Controls.MaterialButton();
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.loggingTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.toolStripIcons.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.defaultTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripButton,
            this.editToolStripButton,
            this.formatToolStripButton,
            this.codeToolStripButton,
            this.settingToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 64);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.toolStrip.Size = new System.Drawing.Size(681, 30);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // fileToolStripButton
            // 
            this.fileToolStripButton.AutoToolTip = false;
            this.fileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripItem,
            this.newWindowToolStripItem,
            this.openToolStripItem,
            this.toolStripSeparator6,
            this.saveToolStripItem,
            this.saveAsToolStripItem,
            this.saveAllToolStripItem,
            this.toolStripSeparator7,
            this.closeToolStripItem,
            this.exitToolStripItem});
            this.fileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripButton.Name = "fileToolStripButton";
            this.fileToolStripButton.Size = new System.Drawing.Size(56, 21);
            this.fileToolStripButton.Text = "Файл";
            // 
            // newToolStripItem
            // 
            this.newToolStripItem.Name = "newToolStripItem";
            this.newToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.newToolStripItem.Text = "Новый";
            this.newToolStripItem.Click += new System.EventHandler(this.NewToolStripItemClick);
            // 
            // newWindowToolStripItem
            // 
            this.newWindowToolStripItem.Name = "newWindowToolStripItem";
            this.newWindowToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.newWindowToolStripItem.Text = "Новый в окне";
            this.newWindowToolStripItem.Click += new System.EventHandler(this.NewWindowToolStripItemClick);
            // 
            // openToolStripItem
            // 
            this.openToolStripItem.Name = "openToolStripItem";
            this.openToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.openToolStripItem.Text = "Открыть";
            this.openToolStripItem.Click += new System.EventHandler(this.OpenToolStripItemClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(264, 6);
            // 
            // saveToolStripItem
            // 
            this.saveToolStripItem.Enabled = false;
            this.saveToolStripItem.Name = "saveToolStripItem";
            this.saveToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.saveToolStripItem.Text = "Сохранить";
            this.saveToolStripItem.Click += new System.EventHandler(this.SaveToolStripItemClick);
            // 
            // saveAsToolStripItem
            // 
            this.saveAsToolStripItem.Enabled = false;
            this.saveAsToolStripItem.Name = "saveAsToolStripItem";
            this.saveAsToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.saveAsToolStripItem.Text = "Сохранить как";
            this.saveAsToolStripItem.Click += new System.EventHandler(this.SaveAsToolStripItemClick);
            // 
            // saveAllToolStripItem
            // 
            this.saveAllToolStripItem.Enabled = false;
            this.saveAllToolStripItem.Name = "saveAllToolStripItem";
            this.saveAllToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.saveAllToolStripItem.Text = "Сохранить все";
            this.saveAllToolStripItem.Click += new System.EventHandler(this.SaveAllToolStripItemClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(264, 6);
            // 
            // closeToolStripItem
            // 
            this.closeToolStripItem.Enabled = false;
            this.closeToolStripItem.Name = "closeToolStripItem";
            this.closeToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.closeToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.closeToolStripItem.Text = "Закрыть вкладку";
            this.closeToolStripItem.Click += new System.EventHandler(this.CloseToolStripItemClick);
            // 
            // exitToolStripItem
            // 
            this.exitToolStripItem.Name = "exitToolStripItem";
            this.exitToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.exitToolStripItem.Size = new System.Drawing.Size(267, 22);
            this.exitToolStripItem.Text = "Выход";
            this.exitToolStripItem.Click += new System.EventHandler(this.ExitToolStripItemClick);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.AutoToolTip = false;
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripItem,
            this.copyToolStripItem,
            this.pasteToolStripItem,
            this.selectAllToolStripItem});
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(71, 21);
            this.editToolStripButton.Text = "Правка";
            this.editToolStripButton.Click += new System.EventHandler(this.EditToolStripButtonClick);
            // 
            // undoToolStripItem
            // 
            this.undoToolStripItem.Name = "undoToolStripItem";
            this.undoToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripItem.Size = new System.Drawing.Size(220, 22);
            this.undoToolStripItem.Text = "Отмена";
            this.undoToolStripItem.Click += new System.EventHandler(this.UndoToolStripItemClick);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.redoToolStripMenuItem.Text = "Повтор";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // cutToolStripItem
            // 
            this.cutToolStripItem.Enabled = false;
            this.cutToolStripItem.Name = "cutToolStripItem";
            this.cutToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripItem.Size = new System.Drawing.Size(220, 22);
            this.cutToolStripItem.Text = "Вырезать";
            this.cutToolStripItem.Click += new System.EventHandler(this.CutToolStripItemClick);
            // 
            // copyToolStripItem
            // 
            this.copyToolStripItem.Enabled = false;
            this.copyToolStripItem.Name = "copyToolStripItem";
            this.copyToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripItem.Size = new System.Drawing.Size(220, 22);
            this.copyToolStripItem.Text = "Копировать";
            this.copyToolStripItem.Click += new System.EventHandler(this.CopyToolStripItemClick);
            // 
            // pasteToolStripItem
            // 
            this.pasteToolStripItem.Enabled = false;
            this.pasteToolStripItem.Name = "pasteToolStripItem";
            this.pasteToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripItem.Size = new System.Drawing.Size(220, 22);
            this.pasteToolStripItem.Text = "Вставить";
            this.pasteToolStripItem.Click += new System.EventHandler(this.PasteToolStripItemClick);
            // 
            // selectAllToolStripItem
            // 
            this.selectAllToolStripItem.Enabled = false;
            this.selectAllToolStripItem.Name = "selectAllToolStripItem";
            this.selectAllToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripItem.Size = new System.Drawing.Size(220, 22);
            this.selectAllToolStripItem.Text = "Выделить всё";
            this.selectAllToolStripItem.Click += new System.EventHandler(this.SelectAllToolStripItemClick);
            // 
            // formatToolStripButton
            // 
            this.formatToolStripButton.AutoToolTip = false;
            this.formatToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.formatToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripItem,
            this.toolStripSeparator5,
            this.italicToolStripItem,
            this.boldToolStripItem,
            this.underlineToolStripItem,
            this.strikeToolStripItem});
            this.formatToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("formatToolStripButton.Image")));
            this.formatToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.formatToolStripButton.Name = "formatToolStripButton";
            this.formatToolStripButton.Size = new System.Drawing.Size(73, 21);
            this.formatToolStripButton.Text = "Формат";
            // 
            // fontToolStripItem
            // 
            this.fontToolStripItem.Enabled = false;
            this.fontToolStripItem.Name = "fontToolStripItem";
            this.fontToolStripItem.Size = new System.Drawing.Size(224, 22);
            this.fontToolStripItem.Text = "Шрифт";
            this.fontToolStripItem.Click += new System.EventHandler(this.FontToolStripItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // italicToolStripItem
            // 
            this.italicToolStripItem.Enabled = false;
            this.italicToolStripItem.Name = "italicToolStripItem";
            this.italicToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripItem.Size = new System.Drawing.Size(224, 22);
            this.italicToolStripItem.Text = "Курсив";
            this.italicToolStripItem.Click += new System.EventHandler(this.ItalicToolStripItemClick);
            // 
            // boldToolStripItem
            // 
            this.boldToolStripItem.Enabled = false;
            this.boldToolStripItem.Name = "boldToolStripItem";
            this.boldToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripItem.Size = new System.Drawing.Size(224, 22);
            this.boldToolStripItem.Text = "Жирный";
            this.boldToolStripItem.Click += new System.EventHandler(this.BoldToolStripItemClick);
            // 
            // underlineToolStripItem
            // 
            this.underlineToolStripItem.Enabled = false;
            this.underlineToolStripItem.Name = "underlineToolStripItem";
            this.underlineToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripItem.Size = new System.Drawing.Size(224, 22);
            this.underlineToolStripItem.Text = "Подчёркнутый";
            this.underlineToolStripItem.Click += new System.EventHandler(this.UnderlineToolStripItemClick);
            // 
            // strikeToolStripItem
            // 
            this.strikeToolStripItem.Enabled = false;
            this.strikeToolStripItem.Name = "strikeToolStripItem";
            this.strikeToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.strikeToolStripItem.Size = new System.Drawing.Size(224, 22);
            this.strikeToolStripItem.Text = "Зачеркнутый";
            this.strikeToolStripItem.Click += new System.EventHandler(this.StrikeToolStripItemClick);
            // 
            // codeToolStripButton
            // 
            this.codeToolStripButton.AutoToolTip = false;
            this.codeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.codeToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highlightToolStripItem,
            this.compileToolStripItem});
            this.codeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("codeToolStripButton.Image")));
            this.codeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.codeToolStripButton.Name = "codeToolStripButton";
            this.codeToolStripButton.Size = new System.Drawing.Size(67, 21);
            this.codeToolStripButton.Text = "Код C#";
            // 
            // highlightToolStripItem
            // 
            this.highlightToolStripItem.Enabled = false;
            this.highlightToolStripItem.Name = "highlightToolStripItem";
            this.highlightToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.highlightToolStripItem.Size = new System.Drawing.Size(277, 22);
            this.highlightToolStripItem.Text = "Подсветка синтаксиса";
            this.highlightToolStripItem.Click += new System.EventHandler(this.HighlightToolStripItemClick);
            // 
            // compileToolStripItem
            // 
            this.compileToolStripItem.Enabled = false;
            this.compileToolStripItem.Name = "compileToolStripItem";
            this.compileToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.compileToolStripItem.Size = new System.Drawing.Size(277, 22);
            this.compileToolStripItem.Text = "Скомпилировать";
            this.compileToolStripItem.Click += new System.EventHandler(this.CompileToolStripItemClick);
            // 
            // settingToolStripButton
            // 
            this.settingToolStripButton.AutoToolTip = false;
            this.settingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripButton.Image")));
            this.settingToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingToolStripButton.Name = "settingToolStripButton";
            this.settingToolStripButton.Size = new System.Drawing.Size(84, 21);
            this.settingToolStripButton.Text = "Настройки";
            this.settingToolStripButton.Click += new System.EventHandler(this.SettingToolStripItemClick);
            // 
            // toolStripIcons
            // 
            this.toolStripIcons.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripIcons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoIconToolStripButton,
            this.redoIconToolStripButton,
            this.toolStripSeparator2,
            this.newFileIconToolStripButton,
            this.saveIconToolStripButton,
            this.closeIconToolStripButton,
            this.toolStripSeparator3,
            this.cutIconToolStripButton,
            this.copyIconToolStripButton,
            this.pasteIconToolStripButton,
            this.toolStripSeparator4,
            this.boldIconToolStripButton,
            this.italicIconToolStripButton,
            this.underlineIconToolStripButton,
            this.strikeIconToolStripButton});
            this.toolStripIcons.Location = new System.Drawing.Point(0, 94);
            this.toolStripIcons.Name = "toolStripIcons";
            this.toolStripIcons.Size = new System.Drawing.Size(681, 25);
            this.toolStripIcons.Stretch = true;
            this.toolStripIcons.TabIndex = 1;
            // 
            // undoIconToolStripButton
            // 
            this.undoIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undoIconToolStripButton.Image")));
            this.undoIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoIconToolStripButton.Name = "undoIconToolStripButton";
            this.undoIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.undoIconToolStripButton.ToolTipText = "Отмена";
            this.undoIconToolStripButton.Click += new System.EventHandler(this.UndoToolStripItemClick);
            // 
            // redoIconToolStripButton
            // 
            this.redoIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redoIconToolStripButton.Image")));
            this.redoIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoIconToolStripButton.Name = "redoIconToolStripButton";
            this.redoIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.redoIconToolStripButton.ToolTipText = "Повтор";
            this.redoIconToolStripButton.Click += new System.EventHandler(this.RedoToolStripItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // newFileIconToolStripButton
            // 
            this.newFileIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFileIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newFileIconToolStripButton.Image")));
            this.newFileIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileIconToolStripButton.Name = "newFileIconToolStripButton";
            this.newFileIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newFileIconToolStripButton.ToolTipText = "Создать файл";
            this.newFileIconToolStripButton.Click += new System.EventHandler(this.NewToolStripItemClick);
            // 
            // saveIconToolStripButton
            // 
            this.saveIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveIconToolStripButton.Image")));
            this.saveIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveIconToolStripButton.Name = "saveIconToolStripButton";
            this.saveIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveIconToolStripButton.ToolTipText = "Сохранить файл";
            this.saveIconToolStripButton.Click += new System.EventHandler(this.SaveToolStripItemClick);
            // 
            // closeIconToolStripButton
            // 
            this.closeIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeIconToolStripButton.Image")));
            this.closeIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeIconToolStripButton.Name = "closeIconToolStripButton";
            this.closeIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.closeIconToolStripButton.ToolTipText = "Закрыть файл";
            this.closeIconToolStripButton.Click += new System.EventHandler(this.CloseToolStripItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cutIconToolStripButton
            // 
            this.cutIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutIconToolStripButton.Image")));
            this.cutIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutIconToolStripButton.Name = "cutIconToolStripButton";
            this.cutIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutIconToolStripButton.ToolTipText = "Вырезать";
            this.cutIconToolStripButton.Click += new System.EventHandler(this.CutToolStripItemClick);
            // 
            // copyIconToolStripButton
            // 
            this.copyIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyIconToolStripButton.Image")));
            this.copyIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyIconToolStripButton.Name = "copyIconToolStripButton";
            this.copyIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyIconToolStripButton.ToolTipText = "Копировать";
            this.copyIconToolStripButton.Click += new System.EventHandler(this.CopyToolStripItemClick);
            // 
            // pasteIconToolStripButton
            // 
            this.pasteIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteIconToolStripButton.Image")));
            this.pasteIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteIconToolStripButton.Name = "pasteIconToolStripButton";
            this.pasteIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteIconToolStripButton.ToolTipText = "Вставить";
            this.pasteIconToolStripButton.Click += new System.EventHandler(this.PasteToolStripItemClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // boldIconToolStripButton
            // 
            this.boldIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("boldIconToolStripButton.Image")));
            this.boldIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldIconToolStripButton.Name = "boldIconToolStripButton";
            this.boldIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.boldIconToolStripButton.ToolTipText = "Жирный";
            this.boldIconToolStripButton.Click += new System.EventHandler(this.BoldToolStripItemClick);
            // 
            // italicIconToolStripButton
            // 
            this.italicIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("italicIconToolStripButton.Image")));
            this.italicIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicIconToolStripButton.Name = "italicIconToolStripButton";
            this.italicIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.italicIconToolStripButton.ToolTipText = "Курсив";
            this.italicIconToolStripButton.Click += new System.EventHandler(this.ItalicToolStripItemClick);
            // 
            // underlineIconToolStripButton
            // 
            this.underlineIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineIconToolStripButton.Image")));
            this.underlineIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineIconToolStripButton.Name = "underlineIconToolStripButton";
            this.underlineIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.underlineIconToolStripButton.ToolTipText = "Подчёркнутый";
            this.underlineIconToolStripButton.Click += new System.EventHandler(this.UnderlineToolStripItemClick);
            // 
            // strikeIconToolStripButton
            // 
            this.strikeIconToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikeIconToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("strikeIconToolStripButton.Image")));
            this.strikeIconToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeIconToolStripButton.Name = "strikeIconToolStripButton";
            this.strikeIconToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.strikeIconToolStripButton.ToolTipText = "Зачёркнутый";
            this.strikeIconToolStripButton.Click += new System.EventHandler(this.StrikeToolStripItemClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNameStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 708);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(822, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.Visible = false;
            // 
            // fileNameStripStatusLabel
            // 
            this.fileNameStripStatusLabel.Name = "fileNameStripStatusLabel";
            this.fileNameStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.defaultTabPage);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabControl.Location = new System.Drawing.Point(0, 119);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(681, 418);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // defaultTabPage
            // 
            this.defaultTabPage.AllowDrop = true;
            this.defaultTabPage.Controls.Add(this.dragLabel);
            this.defaultTabPage.Controls.Add(this.createButton);
            this.defaultTabPage.Controls.Add(this.openButton);
            this.defaultTabPage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.defaultTabPage.Location = new System.Drawing.Point(4, 23);
            this.defaultTabPage.Name = "defaultTabPage";
            this.defaultTabPage.Size = new System.Drawing.Size(673, 391);
            this.defaultTabPage.TabIndex = 0;
            this.defaultTabPage.UseVisualStyleBackColor = true;
            this.defaultTabPage.Visible = false;
            this.defaultTabPage.DragDrop += new System.Windows.Forms.DragEventHandler(this.DefaultTabPageDragDrop);
            this.defaultTabPage.DragEnter += new System.Windows.Forms.DragEventHandler(this.DefaultTabPageDragEnter);
            // 
            // dragLabel
            // 
            this.dragLabel.AutoSize = true;
            this.dragLabel.Depth = 0;
            this.dragLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dragLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.dragLabel.Location = new System.Drawing.Point(271, 259);
            this.dragLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dragLabel.Name = "dragLabel";
            this.dragLabel.Size = new System.Drawing.Size(126, 17);
            this.dragLabel.TabIndex = 2;
            this.dragLabel.Text = "или перетяни файл";
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createButton.Depth = 0;
            this.createButton.HighEmphasis = true;
            this.createButton.Icon = ((System.Drawing.Image)(resources.GetObject("createButton.Icon")));
            this.createButton.Location = new System.Drawing.Point(271, 202);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.createButton.Name = "createButton";
            this.createButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.createButton.Size = new System.Drawing.Size(117, 36);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createButton.UseAccentColor = false;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.NewToolStripItemClick);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.openButton.Depth = 0;
            this.openButton.HighEmphasis = true;
            this.openButton.Icon = ((System.Drawing.Image)(resources.GetObject("openButton.Icon")));
            this.openButton.Location = new System.Drawing.Point(271, 145);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openButton.Name = "openButton";
            this.openButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.openButton.Size = new System.Drawing.Size(118, 36);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Открыть";
            this.openButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.openButton.UseAccentColor = false;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenToolStripItemClick);
            // 
            // materialTabSelector
            // 
            this.materialTabSelector.BaseTabControl = this.tabControl;
            this.materialTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector.Depth = 0;
            this.materialTabSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector.Location = new System.Drawing.Point(0, 496);
            this.materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector.Name = "materialTabSelector";
            this.materialTabSelector.Size = new System.Drawing.Size(681, 41);
            this.materialTabSelector.TabIndex = 5;
            this.materialTabSelector.TabIndicatorHeight = 3;
            this.materialTabSelector.Text = "materialTabSelector1";
            this.materialTabSelector.Visible = false;
            // 
            // autoSaveTimer
            // 
            this.autoSaveTimer.Tick += new System.EventHandler(this.SaveAllToolStripItemClick);
            // 
            // loggingTimer
            // 
            this.loggingTimer.Tick += new System.EventHandler(this.BackupAllFiles);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 537);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStripIcons);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(386, 367);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Simple Edit";
            this.Resize += new System.EventHandler(this.OnResize);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStripIcons.ResumeLayout(false);
            this.toolStripIcons.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.defaultTabPage.ResumeLayout(false);
            this.defaultTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripItem;
        private System.Windows.Forms.ToolStripDropDownButton editToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripItem;
        private System.Windows.Forms.ToolStripDropDownButton formatToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem strikeToolStripItem;
        private System.Windows.Forms.ToolStripButton settingToolStripButton;
        private System.Windows.Forms.ToolStrip toolStripIcons;
        private System.Windows.Forms.ToolStripButton undoIconToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newFileIconToolStripButton;
        private System.Windows.Forms.ToolStripButton saveIconToolStripButton;
        private System.Windows.Forms.ToolStripButton redoIconToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel fileNameStripStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.ToolStripButton cutIconToolStripButton;
        private System.Windows.Forms.ToolStripButton copyIconToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteIconToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton boldIconToolStripButton;
        private System.Windows.Forms.ToolStripButton italicIconToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineIconToolStripButton;
        private System.Windows.Forms.ToolStripButton strikeIconToolStripButton;
        private System.Windows.Forms.ToolStripButton closeIconToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripItem;
        private System.Windows.Forms.TabPage defaultTabPage;
        private MaterialSkin.Controls.MaterialButton openButton;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private MaterialSkin.Controls.MaterialButton createButton;
        private MaterialSkin.Controls.MaterialLabel dragLabel;
        private ToolStripMenuItem saveAllToolStripItem;
        private ToolStripMenuItem newWindowToolStripItem;
        private Timer autoSaveTimer;
        private Timer loggingTimer;
        private ToolStripMenuItem fontToolStripItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripDropDownButton codeToolStripButton;
        private ToolStripMenuItem highlightToolStripItem;
        private ToolStripMenuItem compileToolStripItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem exitToolStripItem;
    }
}

