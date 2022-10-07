using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solutions
{
    public class Maximum_Number_of_Words_Found_in_Sentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int MaxWords = 0;
            foreach (string content in sentences)
            {
                string[] splitContent = content.Split(' ');
                if (MaxWords > splitContent.Length)
                    continue;
                MaxWords = splitContent.Length;
            }
            return MaxWords;
        }
    }
    
}
