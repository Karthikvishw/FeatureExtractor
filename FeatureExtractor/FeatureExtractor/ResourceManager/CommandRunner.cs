using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using FeatureExtractor.LogManager;

namespace FeatureExtractor.ResourceManager
{
    class CommandRunner
    {
        private const string _system32 = @"C:\Windows\System32";
        private const string _cmdPromptPath = @"C:\Windows\System32\cmd.exe";
        private const string _newLine = "\n";

        private ApplicationLogger _logger = new ApplicationLogger();
        private ProcessStartInfo _cmdPrompt = new ProcessStartInfo();
        private Process _process = new Process();

        public bool ExecuteCommand(string command)
        {
            try
            {
                _cmdPrompt.FileName = _cmdPromptPath;
                _cmdPrompt.Arguments = "/C " + command;
                _cmdPrompt.WindowStyle = ProcessWindowStyle.Hidden;
                _process.StartInfo = _cmdPrompt;
                _process.Start();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogMessage(e.Message + _newLine);
                return false;
            }
        }
    }
}
