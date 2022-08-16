using System;

namespace Новая_папка
{
    
    class Program
    {
        static int DO(int index)
        {
            return index * index;
        }
        static void Main(string[] args)
        {
            // && - и
            // || - или
            int a = 15;
            int b = 20;
            int c = 12;
            int x = 0;
            bool flag = a > b;
            int index = flag ? DO(a): DO(b);
            Console.WriteLine(index);
            if((a > b && a > c) || (a == x)) // false true
            {

            }
        }
    }
}