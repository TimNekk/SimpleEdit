using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SimpleEdit.Properties;

namespace SimpleEdit
{
    /// <summary>
    /// Main form
    /// </summary>
    partial class MainWindow
    {
        /// <summary>
        /// Colorizes selected file
        /// </summary>
        private void ColorizeCSharpCode()
        {
            if (TryGetCurrentTextBox(out RichTextBox textBox) is false) return;
            Cursor.Current = Cursors.WaitCursor;
            textBox.SelectAll();
            textBox.SelectionColor = Color.Black;

            // Key words
            var keyWords = File.ReadAllLines(_keyWordsFile);
            ColorizeParts(textBox, Settings.Default.keyWordsColor, keyWords, RichTextBoxFinds.WholeWord ^ RichTextBoxFinds.MatchCase);
            
            // Numbers
            ColorizeParts(textBox, Settings.Default.numbersColor, "0123456789".ToCharArray().Select(c => c.ToString()).ToArray());
            
            // Symbols
            ColorizeParts(textBox, Settings.Default.symbolsColor, "(){}<>[]=!^&%$@*-+|?".ToCharArray().Select(c => c.ToString()).ToArray());
            
            ColorizeVariablesClassesMethods(textBox, Settings.Default.variablesColor, Settings.Default.classesColor, Settings.Default.methodsColor);
            ColorizeComments(textBox, Settings.Default.commentsColor);
            ColorizeStrings(textBox, Settings.Default.stringsColor);
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Colorizes given parts of text
        /// </summary>
        /// <param name="textBox">Text box</param>
        /// <param name="color">Color of parts</param>
        /// <param name="parts">Parts to colorize</param>
        /// <param name="findOption">Find option</param>
        private void ColorizeParts(RichTextBox textBox, Color color, string[] parts, RichTextBoxFinds findOption = RichTextBoxFinds.None)
        {
            foreach (var part in parts)
            {
                int findIndex = 0;
                while (true)
                {
                    if (findIndex >= textBox.TextLength) break;
                    int startIndex = textBox.Find(part, findIndex, findOption);
                    if (startIndex == -1) break;
                    findIndex = startIndex + part.Length;
                    textBox.Select(startIndex, part.Length);
                    textBox.SelectionColor = color;
                }
            }
        }
        
        /// <summary>
        /// Colorizes Variables, Classes and Methods
        /// </summary>
        /// <param name="textBox">Text box</param>
        /// <param name="variableColor">Color of variables</param>
        /// <param name="typeColor">Color of classes</param>
        /// <param name="methodColor">Color of methods</param>
        private void ColorizeVariablesClassesMethods(RichTextBox textBox, Color variableColor, Color typeColor, Color methodColor)
        {
            var classes = ColorizeClasses(textBox, typeColor);
            foreach (var type in File.ReadAllLines(_typesFile).Concat(classes))
            {
                var findIndex = 0;
                while (true)
                {
                    if (findIndex >= textBox.TextLength) break;
                    int typeStartIndex = textBox.Find(type, findIndex, RichTextBoxFinds.WholeWord ^ RichTextBoxFinds.MatchCase);
                    if (typeStartIndex == -1) break;
                    
                    int typeEndIndex = typeStartIndex + type.Length;
                    if (textBox.Text[typeEndIndex..(typeEndIndex + 2)] == "[]") typeEndIndex += 2;
                    textBox.Select(typeStartIndex, typeEndIndex - typeStartIndex);
                    textBox.SelectionColor = typeColor;
                    
                    int equalIndex = textBox.Find("=", typeEndIndex, RichTextBoxFinds.None);
                    int commaIndex = textBox.Find(",", typeEndIndex, RichTextBoxFinds.None);
                    int inIndex = textBox.Find("in", typeEndIndex, RichTextBoxFinds.WholeWord);
                    int bracketIndex = textBox.Find(")", typeEndIndex, RichTextBoxFinds.None);
                    int semicolonIndex = textBox.Find(";", typeEndIndex, RichTextBoxFinds.None);
                    var endIndexList = new[] {equalIndex, bracketIndex, commaIndex, inIndex, semicolonIndex}.Where(x => x >= 0).ToList();
                    if (endIndexList.Count == 0) break;
                    string variable = textBox.Text[typeEndIndex..endIndexList.Min()].Trim();
                    Color color = variableColor;
                    if (variable.Contains("("))
                    {
                        variable = variable.Split("(").First().Trim();
                        color = methodColor;
                    }
                    findIndex = typeEndIndex + variable.Length;
                    ColorizeAllWords(textBox, variable, 0, color);
                }
            }
        }

        /// <summary>
        /// Colorizes classes
        /// </summary>
        /// <param name="textBox">Text box</param>
        /// <param name="color">Color of classes</param>
        /// <returns>List of found classes</returns>
        private List<string> ColorizeClasses(RichTextBox textBox, Color color)
        {
            var classes = new List<string>();
            int findIndex = 0;
            while (true)
            {
                if (findIndex >= textBox.TextLength) break;
                int typeStartIndex = textBox.Find("class", findIndex, RichTextBoxFinds.WholeWord ^ RichTextBoxFinds.MatchCase);
                if (typeStartIndex == -1) break;
                int typeEndIndex = typeStartIndex + 5;

                int colonIndex = textBox.Find(":", typeEndIndex, RichTextBoxFinds.None);
                int curlyBraceIndex = textBox.Find("{", typeEndIndex, RichTextBoxFinds.None);
                int newLineIndex = textBox.Find("\n", typeEndIndex, RichTextBoxFinds.None);
                var endIndexList = new[] {colonIndex, curlyBraceIndex, newLineIndex}.Where(x => x >= 0).ToList();
                if (endIndexList.Count == 0) break;
                
                string className = textBox.Text[typeEndIndex..endIndexList.Min()].Trim();
                classes.Add(className);
                findIndex = typeEndIndex + className.Length;
                ColorizeAllWords(textBox, className, typeEndIndex + 1, color);
            }

            return classes;
        }

        /// <summary>
        /// Colorizes every word in text
        /// </summary>
        /// <param name="textBox">Text box</param>
        /// <param name="word">Word to colorize</param>
        /// <param name="findIndex">Index of search start</param>
        /// <param name="color">Color of word</param>
        private void ColorizeAllWords(RichTextBox textBox, string word, int findIndex, Color color)
        {
            while (true)
            {
                if (findIndex >= textBox.TextLength) break;
                int startIndex = textBox.Find(word, findIndex, RichTextBoxFinds.WholeWord ^ RichTextBoxFinds.MatchCase);
                if (startIndex == -1) break;
                findIndex = startIndex + word.Length;
                if (textBox.Text[startIndex - 1] == '.' && textBox.Text[startIndex - 2] != '.') continue;
                textBox.Select(startIndex, word.Length);
                textBox.SelectionColor = color;
            }
        }
        
        /// <summary>
        /// Colorizes comments
        /// </summary>
        /// <param name="textBox">Text box</param>
        /// <param name="color">Color of comments</param>
        private void ColorizeComments(RichTextBox textBox, Color color)
        {
            int findIndex = 0;
            while (true)
            {
                if (findIndex >= textBox.TextLength) break;
                int startIndex = textBox.Find("//", findIndex, RichTextBoxFinds.None);
                if (startIndex == -1) break;
                int lineIndex = textBox.GetLineFromCharIndex(startIndex);
                int newLineFirstCharacterIndex = textBox.GetFirstCharIndexFromLine(lineIndex + 1);
                findIndex = newLineFirstCharacterIndex;
                textBox.Select(startIndex, newLineFirstCharacterIndex - 1 - startIndex);
                textBox.SelectionColor = color;
            }
        }
        
        /// <summary>
        /// Colorizes strings
        /// </summary>
        /// <param name="textBox">Text box</param>
        /// <param name="color">Color of strings</param>
        private void ColorizeStrings(RichTextBox textBox, Color color)
        {
            int findIndex = 0;
            while (true)
            {
                if (findIndex >= textBox.TextLength) break;
                int startIndex = textBox.Find("\"", findIndex, RichTextBoxFinds.None);
                if (startIndex == -1 || startIndex > 0 && textBox.Text[startIndex - 1] == '\\') break;
                
                int endIndex;
                int endFindIndex = startIndex + 1;
                while (true)
                {
                    endIndex = textBox.Find("\"", endFindIndex, RichTextBoxFinds.None);
                    if (endIndex == -1) break;
                    if (textBox.Text[endIndex - 1] != '\\') break;
                    endFindIndex = endIndex + 1;
                }
                if (endIndex == -1) break;
                findIndex = endIndex + 1;
                textBox.Select(startIndex, endIndex - startIndex + 1);
                textBox.SelectionColor = color;
            }
        }

        /// <summary>
        /// Compiles code of opened file
        /// </summary>
        private void CompileCSharpCode()
        {
            if (TryGetCurrentTab(out TabPage tabPage) is false || tabPage.Text.EndsWith(".cs") is false) return;
            string compiler = Settings.Default.compiler;
            if (compiler == "")
            {
                MessageBox.Show("Выберите компилятор в настройках");
                return;
            }

            string output = _compilationsFolder + "\\" + tabPage.Text.Replace("*", "")[..^3] + ".exe";
            string command = $"\"{compiler}\" /out:\"{output}\" \"{tabPage.Name}\"";

            if (Directory.Exists(_compilationsFolder) is false) Directory.CreateDirectory(_compilationsFolder);

            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C \"" + command + "\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); 
            
            string compilationOutput = process.StandardOutput.ReadToEnd();

            if (compilationOutput.Contains("error"))
            {
                MessageBox.Show(compilationOutput, "Ошибка компиляции");
            }
            else
            {
                var result = MessageBox.Show($"{output}\n\nОткрыть скомпилированный файл?", "Успешно скомпилировалось", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) Process.Start(output);
            }
        }
    }
}