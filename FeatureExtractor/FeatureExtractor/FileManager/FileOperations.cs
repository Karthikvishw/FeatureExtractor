using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FeatureExtractor.LogManager;

namespace FeatureExtractor.FileManager
{
    class FileOperations
    {
        private string[] _grammarExtensions = new string[] { "*.Grm", "*.Grammar", "*.grammer" };
        private const string _txlGrammarExtension = ".grm";
        private const string _validTXLFiles = "*.grm";
        private const string _backSlash = "\\";
        private const string _quote = "\"";
        private const string _multipleGrammarFileError = "More that one input Grammar loaded in the input stack. Please process a single Language grammar.\n";
        private const string _noGrammarFileError = "No Grammar file found in the given directory\n";

        private DirectoryInfo _grammarFolder;
        private FileInfo[] _grammarFiles;

        private ApplicationLogger _logger = new ApplicationLogger(); 

        public FileOperations(string grammarPath)
        {
            _grammarFolder = new DirectoryInfo(@grammarPath);
            _grammarFiles = getGrammarFiles();
        }

        public bool SingleGrammarFileAvailable()
        {
            FileInfo[] files = _grammarFolder.GetFiles(_validTXLFiles);
            if (files.Length == 1)
                return true;
            else if (files.Length > 1)
            {
                _logger.LogMessage(_multipleGrammarFileError);
            }
            else
                _logger.LogMessage(_noGrammarFileError);
            return false;
        }

        public string GetTxlFilePath()
        {
            FileInfo[] files = _grammarFolder.GetFiles(_validTXLFiles);
            return _quote + _grammarFolder.ToString() + _backSlash + files[0].ToString() + _quote;
        }
        private FileInfo[] getGrammarFiles()
        {
            UpdateGrammarExtentions();
            FileInfo[] files = _grammarFolder.GetFiles(_validTXLFiles);
            return files;
        }

        private void UpdateGrammarExtentions()
        {
            FileInfo[] files;
            foreach (string extension in _grammarExtensions)
            {
                files = _grammarFolder.GetFiles(extension);
                foreach (FileInfo file in files)
                {
                    string sourceFile = _grammarFolder + _backSlash + file.ToString();
                    string destinationFile = _grammarFolder + _backSlash + updateTxlExtension(file);
                    File.Move(sourceFile, destinationFile);
                }
            }
        }
        private string updateTxlExtension(FileInfo file)
        {
            return Path.ChangeExtension(file.ToString(), _txlGrammarExtension);
        }
    }
}
