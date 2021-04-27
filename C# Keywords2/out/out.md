<div dir="rtl">

# out keyword:
هي keyword يتم استخدامها لتمرير متغير إلى method كنوع Reference. وأيضاً يمكن استخدامها لإرجاع قيمة من الـ method بدون استخدام جملة return.

#### مثال:
بالمثال التالي أنشأنا متغير من نوع integer وتم استخدام الكلمة out لتمريره إلى دالة يتم من خلالها وضع قيمة للمتغير G و هي بالمثال 80 وأيضاً جمعه مع نفسه ليكون الناتج 160

</div>

```cs
using System;
  
class Program {
    static public void Main()
    {
        int G; //Declare a variable..
        Sum(out G); //using 'out' to pass the variable G to Sum()
  
        Console.WriteLine(G); //Display the value of G which is going to be 160
    }
    public static void Sum(out int G)
    {
        G = 80;
        G += G;
    }
}

```