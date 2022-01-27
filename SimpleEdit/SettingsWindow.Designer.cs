using System;
using System.ComponentModel;

namespace SimpleEdit
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.autoSaveCard = new MaterialSkin.Controls.MaterialCard();
            this.autoSaveTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.autoSaveSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.ColorCard = new MaterialSkin.Controls.MaterialCard();
            this.colorPurpleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.colorRedRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.colorBlueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.colorOrangeRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.colorGreenRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.ColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loggingCard = new MaterialSkin.Controls.MaterialCard();
            this.loggingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loggingTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.highlightCard = new MaterialSkin.Controls.MaterialCard();
            this.commentsColorLabel = new System.Windows.Forms.Label();
            this.stringsColorLabel = new System.Windows.Forms.Label();
            this.methodsColorLabel = new System.Windows.Forms.Label();
            this.classesColorLabel = new System.Windows.Forms.Label();
            this.variablesColorLabel = new System.Windows.Forms.Label();
            this.symbolsColorLabel = new System.Windows.Forms.Label();
            this.numbersColorLabel = new System.Windows.Forms.Label();
            this.keyWordsColorLabel = new System.Windows.Forms.Label();
            this.highlightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.compileCard = new MaterialSkin.Controls.MaterialCard();
            this.compileTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.compileLabel = new MaterialSkin.Controls.MaterialLabel();
            this.autoSaveCard.SuspendLayout();
            this.ColorCard.SuspendLayout();
            this.loggingCard.SuspendLayout();
            this.highlightCard.SuspendLayout();
            this.compileCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoSaveCard
            // 
            this.autoSaveCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoSaveCard.Controls.Add(this.autoSaveTextBox);
            this.autoSaveCard.Controls.Add(this.autoSaveSwitch);
            this.autoSaveCard.Depth = 0;
            this.autoSaveCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.autoSaveCard.Location = new System.Drawing.Point(17, 38);
            this.autoSaveCard.Margin = new System.Windows.Forms.Padding(14);
            this.autoSaveCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoSaveCard.Name = "autoSaveCard";
            this.autoSaveCard.Padding = new System.Windows.Forms.Padding(14, 8, 14, 14);
            this.autoSaveCard.Size = new System.Drawing.Size(239, 94);
            this.autoSaveCard.TabIndex = 2;
            // 
            // autoSaveTextBox
            // 
            this.autoSaveTextBox.AnimateReadOnly = false;
            this.autoSaveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autoSaveTextBox.Depth = 0;
            this.autoSaveTextBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoSaveTextBox.Hint = "минуты";
            this.autoSaveTextBox.LeadingIcon = null;
            this.autoSaveTextBox.Location = new System.Drawing.Point(17, 48);
            this.autoSaveTextBox.MaxLength = 50;
            this.autoSaveTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.autoSaveTextBox.Multiline = false;
            this.autoSaveTextBox.Name = "autoSaveTextBox";
            this.autoSaveTextBox.Size = new System.Drawing.Size(208, 36);
            this.autoSaveTextBox.TabIndex = 1;
            this.autoSaveTextBox.Text = "5";
            this.autoSaveTextBox.TrailingIcon = null;
            this.autoSaveTextBox.UseTallSize = false;
            this.autoSaveTextBox.TextChanged += new System.EventHandler(this.AutoSaveTextBoxTextChanged);
            // 
            // autoSaveSwitch
            // 
            this.autoSaveSwitch.AutoSize = true;
            this.autoSaveSwitch.Checked = true;
            this.autoSaveSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSaveSwitch.Depth = 0;
            this.autoSaveSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoSaveSwitch.Location = new System.Drawing.Point(14, 8);
            this.autoSaveSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.autoSaveSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.autoSaveSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoSaveSwitch.Name = "autoSaveSwitch";
            this.autoSaveSwitch.Ripple = true;
            this.autoSaveSwitch.Size = new System.Drawing.Size(211, 37);
            this.autoSaveSwitch.TabIndex = 0;
            this.autoSaveSwitch.Text = "Автосохранение";
            this.autoSaveSwitch.UseVisualStyleBackColor = true;
            this.autoSaveSwitch.Click += new System.EventHandler(this.AutoSaveSwitchClicked);
            // 
            // ColorCard
            // 
            this.ColorCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ColorCard.Controls.Add(this.colorPurpleRadioButton);
            this.ColorCard.Controls.Add(this.colorRedRadioButton);
            this.ColorCard.Controls.Add(this.colorBlueRadioButton);
            this.ColorCard.Controls.Add(this.colorOrangeRadioButton);
            this.ColorCard.Controls.Add(this.colorGreenRadioButton);
            this.ColorCard.Controls.Add(this.ColorLabel);
            this.ColorCard.Depth = 0;
            this.ColorCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorCard.Location = new System.Drawing.Point(17, 160);
            this.ColorCard.Margin = new System.Windows.Forms.Padding(14);
            this.ColorCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorCard.Name = "ColorCard";
            this.ColorCard.Padding = new System.Windows.Forms.Padding(14);
            this.ColorCard.Size = new System.Drawing.Size(239, 233);
            this.ColorCard.TabIndex = 3;
            // 
            // colorPurpleRadioButton
            // 
            this.colorPurpleRadioButton.AutoSize = true;
            this.colorPurpleRadioButton.Depth = 0;
            this.colorPurpleRadioButton.Location = new System.Drawing.Point(17, 188);
            this.colorPurpleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorPurpleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.colorPurpleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorPurpleRadioButton.Name = "colorPurpleRadioButton";
            this.colorPurpleRadioButton.Ripple = true;
            this.colorPurpleRadioButton.Size = new System.Drawing.Size(129, 37);
            this.colorPurpleRadioButton.TabIndex = 5;
            this.colorPurpleRadioButton.TabStop = true;
            this.colorPurpleRadioButton.Text = "Фиолетовый";
            this.colorPurpleRadioButton.UseVisualStyleBackColor = true;
            this.colorPurpleRadioButton.Click += new System.EventHandler(this.ColorPurpleRadioButtonClick);
            // 
            // colorRedRadioButton
            // 
            this.colorRedRadioButton.AutoSize = true;
            this.colorRedRadioButton.Depth = 0;
            this.colorRedRadioButton.Location = new System.Drawing.Point(17, 151);
            this.colorRedRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorRedRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.colorRedRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorRedRadioButton.Name = "colorRedRadioButton";
            this.colorRedRadioButton.Ripple = true;
            this.colorRedRadioButton.Size = new System.Drawing.Size(101, 37);
            this.colorRedRadioButton.TabIndex = 4;
            this.colorRedRadioButton.TabStop = true;
            this.colorRedRadioButton.Text = "Красный";
            this.colorRedRadioButton.UseVisualStyleBackColor = true;
            this.colorRedRadioButton.Click += new System.EventHandler(this.ColorRedRadioButtonClick);
            // 
            // colorBlueRadioButton
            // 
            this.colorBlueRadioButton.AutoSize = true;
            this.colorBlueRadioButton.Depth = 0;
            this.colorBlueRadioButton.Location = new System.Drawing.Point(17, 42);
            this.colorBlueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorBlueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.colorBlueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorBlueRadioButton.Name = "colorBlueRadioButton";
            this.colorBlueRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorBlueRadioButton.Ripple = true;
            this.colorBlueRadioButton.Size = new System.Drawing.Size(81, 37);
            this.colorBlueRadioButton.TabIndex = 1;
            this.colorBlueRadioButton.TabStop = true;
            this.colorBlueRadioButton.Text = "Синий";
            this.colorBlueRadioButton.UseVisualStyleBackColor = false;
            this.colorBlueRadioButton.Click += new System.EventHandler(this.ColorBlueRadioButtonClick);
            // 
            // colorOrangeRadioButton
            // 
            this.colorOrangeRadioButton.AutoSize = true;
            this.colorOrangeRadioButton.Depth = 0;
            this.colorOrangeRadioButton.Location = new System.Drawing.Point(17, 114);
            this.colorOrangeRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorOrangeRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.colorOrangeRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorOrangeRadioButton.Name = "colorOrangeRadioButton";
            this.colorOrangeRadioButton.Ripple = true;
            this.colorOrangeRadioButton.Size = new System.Drawing.Size(123, 37);
            this.colorOrangeRadioButton.TabIndex = 3;
            this.colorOrangeRadioButton.TabStop = true;
            this.colorOrangeRadioButton.Text = "Оранжевый";
            this.colorOrangeRadioButton.UseVisualStyleBackColor = true;
            this.colorOrangeRadioButton.Click += new System.EventHandler(this.ColorYellowRadioButtonClick);
            // 
            // colorGreenRadioButton
            // 
            this.colorGreenRadioButton.AutoSize = true;
            this.colorGreenRadioButton.Depth = 0;
            this.colorGreenRadioButton.Location = new System.Drawing.Point(17, 79);
            this.colorGreenRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorGreenRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.colorGreenRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorGreenRadioButton.Name = "colorGreenRadioButton";
            this.colorGreenRadioButton.Ripple = true;
            this.colorGreenRadioButton.Size = new System.Drawing.Size(100, 37);
            this.colorGreenRadioButton.TabIndex = 2;
            this.colorGreenRadioButton.TabStop = true;
            this.colorGreenRadioButton.Text = "Зеленый";
            this.colorGreenRadioButton.UseVisualStyleBackColor = true;
            this.colorGreenRadioButton.Click += new System.EventHandler(this.ColorGreenRadioButtonClick);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Depth = 0;
            this.ColorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorLabel.Location = new System.Drawing.Point(60, 14);
            this.ColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(123, 19);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Цветовая схема";
            // 
            // loggingCard
            // 
            this.loggingCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loggingCard.Controls.Add(this.loggingLabel);
            this.loggingCard.Controls.Add(this.loggingTextBox);
            this.loggingCard.Depth = 0;
            this.loggingCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loggingCard.Location = new System.Drawing.Point(284, 38);
            this.loggingCard.Margin = new System.Windows.Forms.Padding(14);
            this.loggingCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.loggingCard.Name = "loggingCard";
            this.loggingCard.Padding = new System.Windows.Forms.Padding(14, 8, 14, 14);
            this.loggingCard.Size = new System.Drawing.Size(239, 94);
            this.loggingCard.TabIndex = 4;
            // 
            // loggingLabel
            // 
            this.loggingLabel.AutoSize = true;
            this.loggingLabel.Depth = 0;
            this.loggingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loggingLabel.Location = new System.Drawing.Point(54, 14);
            this.loggingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loggingLabel.Name = "loggingLabel";
            this.loggingLabel.Size = new System.Drawing.Size(131, 19);
            this.loggingLabel.TabIndex = 2;
            this.loggingLabel.Text = "Журналирование";
            // 
            // loggingTextBox
            // 
            this.loggingTextBox.AnimateReadOnly = false;
            this.loggingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loggingTextBox.Depth = 0;
            this.loggingTextBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loggingTextBox.Hint = "минуты";
            this.loggingTextBox.LeadingIcon = null;
            this.loggingTextBox.Location = new System.Drawing.Point(14, 44);
            this.loggingTextBox.MaxLength = 50;
            this.loggingTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loggingTextBox.Multiline = false;
            this.loggingTextBox.Name = "loggingTextBox";
            this.loggingTextBox.Size = new System.Drawing.Size(208, 36);
            this.loggingTextBox.TabIndex = 1;
            this.loggingTextBox.Text = "5";
            this.loggingTextBox.TrailingIcon = null;
            this.loggingTextBox.UseTallSize = false;
            this.loggingTextBox.TextChanged += new System.EventHandler(this.LoggingTextBoxTextChanged);
            // 
            // highlightCard
            // 
            this.highlightCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.highlightCard.Controls.Add(this.commentsColorLabel);
            this.highlightCard.Controls.Add(this.stringsColorLabel);
            this.highlightCard.Controls.Add(this.methodsColorLabel);
            this.highlightCard.Controls.Add(this.classesColorLabel);
            this.highlightCard.Controls.Add(this.variablesColorLabel);
            this.highlightCard.Controls.Add(this.symbolsColorLabel);
            this.highlightCard.Controls.Add(this.numbersColorLabel);
            this.highlightCard.Controls.Add(this.keyWordsColorLabel);
            this.highlightCard.Controls.Add(this.highlightLabel);
            this.highlightCard.Depth = 0;
            this.highlightCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.highlightCard.Location = new System.Drawing.Point(284, 160);
            this.highlightCard.Margin = new System.Windows.Forms.Padding(14);
            this.highlightCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.highlightCard.Name = "highlightCard";
            this.highlightCard.Padding = new System.Windows.Forms.Padding(14);
            this.highlightCard.Size = new System.Drawing.Size(239, 233);
            this.highlightCard.TabIndex = 6;
            // 
            // commentsColorLabel
            // 
            this.commentsColorLabel.AutoSize = true;
            this.commentsColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentsColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.commentsColorLabel.ForeColor = System.Drawing.Color.Red;
            this.commentsColorLabel.Location = new System.Drawing.Point(119, 196);
            this.commentsColorLabel.Name = "commentsColorLabel";
            this.commentsColorLabel.Size = new System.Drawing.Size(113, 19);
            this.commentsColorLabel.TabIndex = 8;
            this.commentsColorLabel.Text = "Комментарии";
            this.commentsColorLabel.Click += new System.EventHandler(this.CommentsColorLabelClick);
            // 
            // stringsColorLabel
            // 
            this.stringsColorLabel.AutoSize = true;
            this.stringsColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stringsColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stringsColorLabel.ForeColor = System.Drawing.Color.Red;
            this.stringsColorLabel.Location = new System.Drawing.Point(143, 97);
            this.stringsColorLabel.Name = "stringsColorLabel";
            this.stringsColorLabel.Size = new System.Drawing.Size(63, 19);
            this.stringsColorLabel.TabIndex = 7;
            this.stringsColorLabel.Text = "Строки";
            this.stringsColorLabel.Click += new System.EventHandler(this.StringsColorLabelClick);
            // 
            // methodsColorLabel
            // 
            this.methodsColorLabel.AutoSize = true;
            this.methodsColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.methodsColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.methodsColorLabel.ForeColor = System.Drawing.Color.Red;
            this.methodsColorLabel.Location = new System.Drawing.Point(140, 146);
            this.methodsColorLabel.Name = "methodsColorLabel";
            this.methodsColorLabel.Size = new System.Drawing.Size(74, 19);
            this.methodsColorLabel.TabIndex = 6;
            this.methodsColorLabel.Text = "Функции";
            this.methodsColorLabel.Click += new System.EventHandler(this.MethodsColorLabelClick);
            // 
            // classesColorLabel
            // 
            this.classesColorLabel.AutoSize = true;
            this.classesColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classesColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.classesColorLabel.ForeColor = System.Drawing.Color.Red;
            this.classesColorLabel.Location = new System.Drawing.Point(34, 196);
            this.classesColorLabel.Name = "classesColorLabel";
            this.classesColorLabel.Size = new System.Drawing.Size(65, 19);
            this.classesColorLabel.TabIndex = 5;
            this.classesColorLabel.Text = "Классы";
            this.classesColorLabel.Click += new System.EventHandler(this.ClassesColorLabelClick);
            // 
            // variablesColorLabel
            // 
            this.variablesColorLabel.AutoSize = true;
            this.variablesColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variablesColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.variablesColorLabel.ForeColor = System.Drawing.Color.Red;
            this.variablesColorLabel.Location = new System.Drawing.Point(17, 146);
            this.variablesColorLabel.Name = "variablesColorLabel";
            this.variablesColorLabel.Size = new System.Drawing.Size(103, 19);
            this.variablesColorLabel.TabIndex = 4;
            this.variablesColorLabel.Text = "Переменные";
            this.variablesColorLabel.Click += new System.EventHandler(this.VariablesColorLabelClick);
            // 
            // symbolsColorLabel
            // 
            this.symbolsColorLabel.AutoSize = true;
            this.symbolsColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.symbolsColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.symbolsColorLabel.ForeColor = System.Drawing.Color.Red;
            this.symbolsColorLabel.Location = new System.Drawing.Point(137, 52);
            this.symbolsColorLabel.Name = "symbolsColorLabel";
            this.symbolsColorLabel.Size = new System.Drawing.Size(79, 19);
            this.symbolsColorLabel.TabIndex = 3;
            this.symbolsColorLabel.Text = "Символы";
            this.symbolsColorLabel.Click += new System.EventHandler(this.SymbolsColorLabelClick);
            // 
            // numbersColorLabel
            // 
            this.numbersColorLabel.AutoSize = true;
            this.numbersColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numbersColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numbersColorLabel.ForeColor = System.Drawing.Color.Red;
            this.numbersColorLabel.Location = new System.Drawing.Point(38, 97);
            this.numbersColorLabel.Name = "numbersColorLabel";
            this.numbersColorLabel.Size = new System.Drawing.Size(55, 19);
            this.numbersColorLabel.TabIndex = 2;
            this.numbersColorLabel.Text = "Числа";
            this.numbersColorLabel.Click += new System.EventHandler(this.NumbersColorLabelClick);
            // 
            // keyWordsColorLabel
            // 
            this.keyWordsColorLabel.AutoSize = true;
            this.keyWordsColorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyWordsColorLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.keyWordsColorLabel.ForeColor = System.Drawing.Color.Red;
            this.keyWordsColorLabel.Location = new System.Drawing.Point(18, 52);
            this.keyWordsColorLabel.Name = "keyWordsColorLabel";
            this.keyWordsColorLabel.Size = new System.Drawing.Size(102, 19);
            this.keyWordsColorLabel.TabIndex = 1;
            this.keyWordsColorLabel.Text = "Ключ. слова";
            this.keyWordsColorLabel.Click += new System.EventHandler(this.KeyWordColorLabelClick);
            // 
            // highlightLabel
            // 
            this.highlightLabel.AutoSize = true;
            this.highlightLabel.Depth = 0;
            this.highlightLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.highlightLabel.Location = new System.Drawing.Point(53, 14);
            this.highlightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.highlightLabel.Name = "highlightLabel";
            this.highlightLabel.Size = new System.Drawing.Size(137, 19);
            this.highlightLabel.TabIndex = 0;
            this.highlightLabel.Text = "Цвета синтаксиса";
            // 
            // compileCard
            // 
            this.compileCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.compileCard.Controls.Add(this.compileTextBox);
            this.compileCard.Controls.Add(this.compileLabel);
            this.compileCard.Depth = 0;
            this.compileCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.compileCard.Location = new System.Drawing.Point(17, 421);
            this.compileCard.Margin = new System.Windows.Forms.Padding(14);
            this.compileCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.compileCard.Name = "compileCard";
            this.compileCard.Padding = new System.Windows.Forms.Padding(14);
            this.compileCard.Size = new System.Drawing.Size(506, 83);
            this.compileCard.TabIndex = 7;
            // 
            // compileTextBox
            // 
            this.compileTextBox.AnimateReadOnly = true;
            this.compileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compileTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compileTextBox.Depth = 0;
            this.compileTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.compileTextBox.Hint = "Путь к компилятору csc.exe";
            this.compileTextBox.LeadingIcon = null;
            this.compileTextBox.Location = new System.Drawing.Point(17, 35);
            this.compileTextBox.MaxLength = 50;
            this.compileTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.compileTextBox.Multiline = false;
            this.compileTextBox.Name = "compileTextBox";
            this.compileTextBox.ReadOnly = true;
            this.compileTextBox.Size = new System.Drawing.Size(472, 36);
            this.compileTextBox.TabIndex = 7;
            this.compileTextBox.Text = "";
            this.compileTextBox.TrailingIcon = null;
            this.compileTextBox.UseTallSize = false;
            this.compileTextBox.Click += new System.EventHandler(this.CompileTextBoxClick);
            // 
            // compileLabel
            // 
            this.compileLabel.AutoSize = true;
            this.compileLabel.Depth = 0;
            this.compileLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.compileLabel.Location = new System.Drawing.Point(194, 8);
            this.compileLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.compileLabel.Name = "compileLabel";
            this.compileLabel.Size = new System.Drawing.Size(118, 19);
            this.compileLabel.TabIndex = 6;
            this.compileLabel.Text = "C# Компилятор";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 520);
            this.Controls.Add(this.compileCard);
            this.Controls.Add(this.highlightCard);
            this.Controls.Add(this.loggingCard);
            this.Controls.Add(this.ColorCard);
            this.Controls.Add(this.autoSaveCard);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximumSize = new System.Drawing.Size(539, 520);
            this.MinimumSize = new System.Drawing.Size(539, 520);
            this.Name = "SettingsWindow";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "Settings";
            this.autoSaveCard.ResumeLayout(false);
            this.autoSaveCard.PerformLayout();
            this.ColorCard.ResumeLayout(false);
            this.ColorCard.PerformLayout();
            this.loggingCard.ResumeLayout(false);
            this.loggingCard.PerformLayout();
            this.highlightCard.ResumeLayout(false);
            this.highlightCard.PerformLayout();
            this.compileCard.ResumeLayout(false);
            this.compileCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard autoSaveCard;
        private MaterialSkin.Controls.MaterialCard ColorCard;
        private MaterialSkin.Controls.MaterialLabel ColorLabel;
        private MaterialSkin.Controls.MaterialRadioButton colorBlueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton colorGreenRadioButton;
        private MaterialSkin.Controls.MaterialTextBox autoSaveTextBox;
        private MaterialSkin.Controls.MaterialSwitch autoSaveSwitch;
        private MaterialSkin.Controls.MaterialRadioButton colorOrangeRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton colorRedRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton colorPurpleRadioButton;
        private MaterialSkin.Controls.MaterialCard loggingCard;
        private MaterialSkin.Controls.MaterialLabel loggingLabel;
        private MaterialSkin.Controls.MaterialTextBox loggingTextBox;
        private MaterialSkin.Controls.MaterialCard highlightCard;
        private MaterialSkin.Controls.MaterialLabel highlightLabel;
        private System.Windows.Forms.Label keyWordsColorLabel;
        private System.Windows.Forms.Label classesColorLabel;
        private System.Windows.Forms.Label variablesColorLabel;
        private System.Windows.Forms.Label symbolsColorLabel;
        private System.Windows.Forms.Label numbersColorLabel;
        private System.Windows.Forms.Label commentsColorLabel;
        private System.Windows.Forms.Label stringsColorLabel;
        private System.Windows.Forms.Label methodsColorLabel;
        private MaterialSkin.Controls.MaterialCard compileCard;
        private MaterialSkin.Controls.MaterialTextBox compileTextBox;
        private MaterialSkin.Controls.MaterialLabel compileLabel;
    }
}