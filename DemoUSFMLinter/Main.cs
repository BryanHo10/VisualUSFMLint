using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USFMToolsSharp;
using USFMToolsSharp.Linter;
using USFMToolsSharp.Linter.Models;
using USFMToolsSharp.Models.Markers;

namespace DemoUSFMLinter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            fileDataGrid.ColumnCount = 1;
            fileDataGrid.Columns[0].Name = "File";
            fileDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void BtnCheck_Click(object sender, EventArgs e)
        {

            Msg_Linter.ResetText();
            BtnCheck.Enabled = false;
            BtnAddFiles.Enabled = false;
            var parser = new USFMParser(new List<string> { "s5" });
            var usfm = new USFMDocument();
            DataGridViewSelectedCellCollection SelectedFiles = fileDataGrid.SelectedCells;
            USFMLinter lint = new USFMLinter();
            if (fileDataGrid.Rows.Count > 1)
            {
                foreach (DataGridViewCell SelectFile in SelectedFiles)
                {
                    if (SelectFile.OwningRow.Index != fileDataGrid.RowCount - 1)
                    {
                        

                        var cell = SelectFile.OwningRow.Cells[0];
                        if (cell.Value == null)
                        {
                            continue;
                        }
                        var filename = cell.Value.ToString();

                        var text = File.ReadAllText(filename);
                        usfm.Insert(parser.ParseFromString(text));
                        List<LinterResult> linterResults = await lint.LintAsync(usfm);
                        await DisplayErrors(linterResults,filename);
                        usfm = new USFMDocument();
                    }
                }
            }
            
            
            BtnCheck.Enabled = true;
            BtnAddFiles.Enabled = true;

        }
        private async Task DisplayErrors(List<LinterResult> errors,string filename)
        {
            
            foreach (LinterResult result in errors)
            {
                Msg_Linter.Text += $"Level: ({result.Level}) in {Path.GetFileName(filename)} | Message: {result.Message}{Environment.NewLine}";
            }
        }
        private void BtnAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "USFM files (*.usfm)|*.usfm|Text files (*.txt)|*.txt",
                Multiselect = true,
                ShowHelp = true
            };
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            foreach (var filePath in openFileDialog.FileNames)
            {
                if (filePath.ToLower().EndsWith(".usfm") ||
                    filePath.ToLower().EndsWith(".txt"))
                {
                    fileDataGrid.Rows.Add(new String[] { filePath });
                }
            }
        }
    }
}
