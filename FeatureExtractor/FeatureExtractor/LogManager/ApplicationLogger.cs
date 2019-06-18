using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureExtractor;

namespace FeatureExtractor.LogManager
{
    class ApplicationLogger
    {
        private featureExtractor featureExtractorForm = new featureExtractor();
        public void LogMessage(string message)
        {
            featureExtractorForm.updateLog(message);
        }
    }
}

