using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureExtractor.FileManager;
using FeatureExtractor.ResourceManager;
using FeatureExtractor.LogManager;

namespace FeatureExtractor.ApplicationManager
{
    class LanguageAnalysis
    {
        private FileOperations _fileOperations;
        private CommandRunner _cmdRunner = new CommandRunner();
        private ApplicationLogger _logger = new ApplicationLogger();

        private const string _txlcommand ="txl";
        private const string _quiet = " -q ";
        private const string _parserFile = " \"C:\\Users\\karth\\Desktop\\TXL\\Tools\\RemoveTxlComments\\grm.txl\"";
        private const string _stackSize = " -s 1000";
        private const string _toTempFile = " > \"C:\\Users\\karth\\Desktop\\TXL\\Temp\\temp.grm\"";

        private const string _txlCleanseFailed = "TXL failed to cleanse the language grammar file, use the latest grammar file.\n";
        private const string _txlCleanseSuccess = "TXL grammar file cleansed, proceeding to TXL code generation.\n";
        public LanguageAnalysis(FileOperations txlFile)
        {
            _fileOperations = txlFile;
        }
        public void ExtractFeatureVector()
        {
            cleanseTxlGrammar();
        }
        
        private void cleanseTxlGrammar()
        {
            string txlCommand = _txlcommand + _quiet + _fileOperations.GetTxlFilePath() + _parserFile + _stackSize + _toTempFile;
            if (_cmdRunner.ExecuteCommand(txlCommand))
                _logger.LogMessage(_txlCleanseSuccess);
            else   
                _logger.LogMessage(_txlCleanseFailed);
        }
    }
}
