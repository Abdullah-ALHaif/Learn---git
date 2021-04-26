<div dir="rtl">

# مفهوم Delegate:

هو متغير يشير إلى function بشرط أن الـ function يحترم شروط الـ delegate.

#### مثال:

</div>

```

using System;

namespace Night0205_delegate
{
    class Program
    {
        public static int sum(int a,int b)
        {
            return a + b;
        }
        public static int sub(int a,int b)
        {
            return a - b;
        }
        public static int mul(int a, int b)
        {
            return a * b;
        }

        public static int div(int a, int b)
        {
            return a / b;
        }

        public static int mod(int a,int b)
        {
            return a % b;
        }

        public delegate int MyAction(int a, int b);
        static void Main(string[] args)
        {
            MyAction ma = sum;
            int result = ma(1, 2);
            Console.WriteLine(result);
            ma = sub;
            result = ma(5, 2);
            Console.WriteLine(result);

            MyAction[] operations =
            {
                mul,div,sum,sub,mod
            };

            int r = 0;
            foreach (var operation in operations)
                r += operation(5, 6); //it will perform and return the value of all operations..(The best)
                                      //with this code we won't need to use 'if' statement or modify the code..


            ma += sub;
            ma += mul;
            ma += div;
            result = ma(10, 5);
            Console.WriteLine(result); //it will execute all the functions, but it will only return the value of the last function..
        }
    }
}


```