using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont;
            while (true)
            {
                Console.WriteLine("Enter text: ");
                string s = Console.ReadLine();
                FillQueue fq = new FillQueue(s);
                fq.Filler();
                FillStack fs = new FillStack(s);
                fs.Filler();
                IsPalindrome p = new IsPalindrome(fs.letter, fq.letter);
                p.PalindromeCheck();
                Console.WriteLine("Do you want continue? (Y/N)");
                cont = Console.ReadKey().KeyChar;
                Console.WriteLine(" ");
                if (cont == 'y' || cont == 'Y')
                {
                    continue;
                }
                else if (cont == 'n' || cont == 'N')
                {
                    break;
                }
                else
                    Console.WriteLine("You have entered an invalid value ..!");
            }
        }
    }
}
