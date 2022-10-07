using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Masking_Personal_Information
    {
        public string MaskPII(string s)
        {
            if (s.IndexOf("@") > 0)
            {
                int idx = s.IndexOf("@");
                s = s.ToLower();
                return s[0] + "*****" + s[idx - 1] + s.Substring(idx);
            }
            else
            {
                s = s.Replace("+", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                int digit = s.Length - 10;
                StringBuilder sb = new StringBuilder();
                if (digit == 1)
                {
                    sb.Append("+*-");
                }
                else if (digit == 2)
                {
                    sb.Append("+**-");
                }
                else if (digit == 3)
                {
                    sb.Append("+***-");
                }
                sb.Append("***-***-");
                sb.Append(s[s.Length - 4].ToString());
                sb.Append(s[s.Length - 3].ToString());
                sb.Append(s[s.Length - 2].ToString());
                sb.Append(s[s.Length - 1].ToString());
                return sb.ToString();
            }
        }
    }
}
