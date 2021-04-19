using System;
using System.Collections;
namespace Assignment_2
{
    class Program
    {
        static bool match(string source)
        {
            ArrayList list = new ArrayList();
            int stack = 0;
            int i = 0;
            foreach (char ch in source)
            {
                
                list.Add(source[i]);
                for (int j = source.Length-1 ; j>=0; j--)
                {
                    if (source[j]!=ch)
                    {
                        stack=1;
                        
                    }
                    else { stack = 0; }
                }
                i++;
            }
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Stack = "+stack);
            return stack == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(match("312213"));

        }
    }
}
