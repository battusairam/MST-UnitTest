using MoodAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace MoodAnalyser

    public class moodAnalyzaer
    {
        public string HAPPYMOOD = "Happy";
        public string SADMOOD = "sad";
        public string AnalyzaerMood(string mood)
        {
            if (mood.Contains("Happy"))
            {
                Console.WriteLine("Happy");
                return HAPPYMOOD;
            }
            if (mood.Contains("sai"))
            {
                Console.WriteLine("sad");
                return SADMOOD;
            }
            return null;
            }
        }
    
