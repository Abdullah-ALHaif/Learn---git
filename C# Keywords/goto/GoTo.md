<div dir="rtl">

# مفهوم GoTo:
هو نوع من أنواع الـ Jump statements والتي يمكن من خلالها الانتقال إلى أي مكان في الكود.

#### مثال:

</div>

```
using System;

namespace Class0301_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string seven = "";
        hi:
            Console.WriteLine("Please enter a text contains '7': ");
            seven = Console.ReadLine();
            count++;

            if(!seven.Contains('7'))
            goto hi; //it is going to jump to Console.WriteLine ...
        }
    }
}


```