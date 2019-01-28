using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    class FillQueue
    {
        string s;
        public Queue<char> letter = new Queue<char>();

        public FillQueue(string s)
        {
            this.s = s.ToUpper();
        }

        public void Filler()
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                    letter.Enqueue(s[i]);
            }
        }
    }
}
