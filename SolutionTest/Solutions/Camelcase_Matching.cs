using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Camelcase_Matching
    {
        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            List<bool> result = new List<bool>();

            List<string> PatternSplit = SplitStringByUpperChar(pattern);

            foreach (string query in queries)
            {
                List<string> QuerySplit = SplitStringByUpperChar(query);

                //Result Analyse

                //Count Not Match early return
                if (QuerySplit.Count != PatternSplit.Count)
                {
                    result.Add(false);
                    continue;
                }

                for (int i = 0; i < PatternSplit.Count; i++)
                {
                    bool fail = false;
                    string queryTemp = QuerySplit[i];

                    //Analyse querystring is match pattern word or not
                    for (int j = 0; j < PatternSplit[i].Length; j++)
                    {
                        //find scentence if pattern word match index will > 0
                        int SubIdx = queryTemp.IndexOf(PatternSplit[i][j]);
                        if (SubIdx >= 0)
                        {
                            if (j == PatternSplit[i].Length - 1)
                            {
                                break;
                            }
                            //query string scentence cutting
                            queryTemp = queryTemp.Substring(SubIdx + 1);
                            continue;
                        }
                        fail = true;
                        break;
                    }

                    //querystring does not match pattern
                    if (fail)
                    {
                        result.Add(false);
                        break;
                    }

                    //querystring run to last pattern and match all
                    if (i == PatternSplit.Count - 1)
                    {
                        result.Add(true);
                        break;
                    }
                }

            }
            return result;
        }
        private List<string> SplitStringByUpperChar(string Source)
        {
            List<string> StringSplitByUpper = new List<string>();

            //clear front lower characters
            for (int i = 0; i < Source.Length; i++)
            {
                if (Source[i] >= 'A' && Source[i] <= 'Z')
                {
                    Source = Source.Substring(i);
                    break;
                }
            }

            //Split Sentences
            string split = string.Empty;
            foreach (char word in Source)
            {
                if (word >= 'A' && word <= 'Z')
                {
                    if (string.IsNullOrEmpty(split))
                    {
                        split += word;
                    }
                    else
                    {
                        StringSplitByUpper.Add(split);
                        split = "" + word;
                    }
                }
                if (word >= 'a' && word <= 'z')
                {
                    split += word;
                }
            }
            StringSplitByUpper.Add(split);
            return StringSplitByUpper;
        }
    }
}
