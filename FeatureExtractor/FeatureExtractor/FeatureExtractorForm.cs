using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeatureExtractor.ApplicationManager;
using FeatureExtractor.FileManager;
using FeatureExtractor.LogManager;


namespace FeatureExtractor
{
    public partial class featureExtractor : Form
    {
        private LanguageAnalysis _analysisInput;
        private FileOperations _fileOperations;

        private const string _logInitialMessage = "Feature Extractor Log\n-------------------------------------------------------\n";
        private const string _emptyString = "";
        private const string _validationPassed = "Input validated, proceeding to cleanse TXL grammar file.\n";
        private const string _validationFailed = "Input validation failed.\n";

        public featureExtractor()
        {
            InitializeComponent();
        }

        private void SubmitRequest_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                updateLog(_validationPassed);
                _analysisInput = new LanguageAnalysis(_fileOperations);
                _analysisInput.ExtractFeatureVector();
            }
            else
            {
                updateLog(_validationFailed);
            }
        }

        private bool validateForm()
        {
            return
                HasInput() &&
                IsGrammarValid();
        }

        private bool IsGrammarValid()
        {
            return _fileOperations.SingleGrammarFileAvailable();
        }

        private bool HasInput()
        {
            return
            (!IsEmptyTextBox(languageGrammar, "target programming language")
            &&
            !IsEmptyTextBox(targetProject, "target project"));
        }

        private bool IsEmptyTextBox(TextBox textBox, string fieldDesc)
        {
            if (textBox.Text == "")
            {
                formError.SetError(textBox, MessageBox.Show("Please enter the details of "+ fieldDesc).ToString());
                return true;
            }
            else
                return false;
        }

        private void OnlyLUV_CheckedChanged(object sender, EventArgs e)
        {
            levelOfContext.Visible = !onlyLUV.Checked;
            levelOfContextLabel.Visible = !onlyLUV.Checked;
        }

        private void BrowseLanguageGrammar_Click(object sender, EventArgs e)
        {
            targetLanguageGrammarPath.ShowDialog();
            languageGrammar.Text = targetLanguageGrammarPath.SelectedPath;
            _fileOperations = new FileOperations(targetLanguageGrammarPath.SelectedPath);
            enableButton(clearRequest, true);
        }

        private void BrowseProject_Click(object sender, EventArgs e)
        {
            targetProjectPath.ShowDialog();
            targetProject.Text = targetProjectPath.SelectedPath;
            enableButton(clearRequest, true);
        }

        private void ClearRequest_Click(object sender, EventArgs e)
        {
            languageGrammar.Text = _emptyString;
            targetProject.Text = _emptyString;

            applicationLog.Text = _logInitialMessage;

            enableButton(clearRequest,false);
        }

        private void enableButton(Button button, bool value)
        {
            button.Enabled = value;
        }
        public void updateLog(string log)
        {
            applicationLog.AppendText(log);
            applicationLog.Refresh();
        }
    }
}
