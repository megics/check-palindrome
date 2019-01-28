using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    class IsPalindrome
    {
        Stack<char> st;
        Queue<char> qu;

        public IsPalindrome(Stack<char> st, Queue<char> qu)
        {
            this.st = st;
            this.qu = qu;
        }

        public void PalindromeCheck()
        {
            while (st.Count != 0)
            {
                if (st.Pop() != qu.Dequeue())
                {
                    Console.WriteLine("Not palindrome!");
                    return;
                }
            }
            Console.WriteLine("Yes palindrome..");
        }
    }
}
