using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class StringToInteger
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            if (s.Length == 0)
                return 0;
            if (s.Length == 1 && (s[0] == '+' || s[0] == '-'))
                return 0;

            int startIdx = -1,endIdx = -1;
           
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-' || s[i] == '+')
                {
                    if (startIdx > -1 )
                    {
                        if (endIdx > -1)
                            break;
                        return 0;
                    }
                    startIdx = i;
                    continue;
                }

                if (s[i] >= 48 && s[i] <= 57)
                {
                    if (startIdx == -1)
                    {
                        startIdx = i;
                    }
                    endIdx = i;
                }
                else
                {
                    if (startIdx > -1)
                    {
                        endIdx = i - 1;
                        break;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            if (endIdx == -1)
            {
                endIdx = s.Length;
            }

            s = s.Substring(startIdx, endIdx - startIdx + 1);

            if (!Int32.TryParse(s, out int result))
            {
                if (!Int64.TryParse(s, out long result64))
                {
                    if (endIdx - startIdx > 11)
                    {
                        if (s[startIdx] == '-')
                            return Int32.MinValue;
                        return Int32.MaxValue;
                    }
                    return 0;
                }
                else
                {
                    if (s[startIdx] == '-')
                        return Int32.MinValue;
                    return Int32.MaxValue;
                }
            }
            return result;
        }
    }
}
