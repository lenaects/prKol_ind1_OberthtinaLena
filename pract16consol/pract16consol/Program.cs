using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract16consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Stack<char> chStack = new Stack<char>();

            foreach (char ch in s1)
                chStack.Push(ch);
            int j = 0;
            bool flag = true;
            while (chStack.Count != 0)
            {
                if (s2[j] != chStack.Pop())
                {
                    flag = false;
                    break;
                }
                j++;
            }
            if (flag == true) Console.WriteLine("строка обратная");
            else Console.WriteLine("строка не обратна");           
            Console.ReadLine();
        }   

    }
    
}
