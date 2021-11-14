using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilities
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var summary = "A summary is written in your own words. A summary contains only the ideas of the original text. Do not insert any of your own opinions, interpretations, deductions or comments into a summary. Identify in order the significant sub-claims the author uses to defend the main point.";

            Console.WriteLine(EllipsisText(summary));
        }


        static string EllipsisText(string text, int maxLength = 30)
        {
            if (text.Length < maxLength)
                return text;

            //words from string split by space
            var words = text.Split(' ');
            //store words 
            var summaryWords = new List<string>();
            //count character
            var count = 0;

            foreach (var word in words)
            {
                count += word.Length;
                if (count > maxLength)
                    break;

                summaryWords.Add(word);
            }

            return String.Join(" ", summaryWords) + "...";
        }

    }
}
