using MoodAnalayser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (!string.IsNullOrEmpty(message))
            {
                if (message.Contains("Sad") || message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            else
            {
                return "Happy";
            }
            
        }
    }
}
