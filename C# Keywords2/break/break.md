<div dir="rtl">

# مفهوم break:

break هي جملة برمجية يمكن استخدامها للخروج من حلقة التكرار (loop) كـ for loop مثلاً وكذلك يمكن استخدامها للخروج من Switch وهي نوع من أنواع الـ Jump Statements.

#### مثال:
المثال التالي عبارة عن حلقة تكرار يفترض أن تطبع الأرقام من 1 إلى 100 ولكن تم وضع شرط أنه عن وصول i عند الرقم 5 فإنه يجب الخروج من حلقة التكرار والإنتقال إلى جملة الطباعة والتي تطبع: Break Example


 لذلك سيكون الناتج كالتالي:



</div>

```
1
2
3
4
Break Example
```

```CS
class BreakTest
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i == 5)
            {
                break; // It's going to break the loop..
            }
            Console.WriteLine(i);
        }

        Console.WriteLine("Break Example");

       
    }
}

```

