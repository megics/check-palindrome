using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    class FillStack
    {
        string s;
        public Stack<char> letter = new Stack<char>();

        public FillStack(string s)
        {
            this.s = s.ToUpper();
        }

        public void Filler()
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    letter.Push(s[i]);
                }
            }
        }
    }
}
