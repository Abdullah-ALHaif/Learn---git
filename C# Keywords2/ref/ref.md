<div dir="rtl">

# ref keyword:
هذه الـ keyword عملها مشابه لعمل 'out' حيث يتم تمرير المتغير إلى الدالة كنوع Reference ولكن الفرق أنه في out يجب تعيين قيمة للمتغير داخل الدالة قبل إرجاع القيمة وأما في ref يتم العكس حيث يجب تعيين قيمة للمتغير قبل استدعاء الدالة.

العلاقة بين in و ref هي أن in تقوم بنفس عمل ref ولكن in لا تسمح للدالة التي تم استدعاءها بتغيير قيمة المتغير الممر لها.

#### مثال:
بالمثال التالي تم تعيين قيمة Hello للمتغير str قبل إرساله إلى الدالة وتم تغيير القيمة داخل الدالة من Hello إلى Hi قبل إرجاعها ليكون الناتج كالتالي:
Hi


</div>

```cs
public static void Main()
    {
  
        string str = "Hello"; //set a value before calling SetValue() because it's required to use 'ref'
        SetValue(ref str);
  
        //Display the output after performing SetValue()
        Console.WriteLine(str);
    }
  
    static void SetValue(ref string str1)
    {
        // Assign the new value
        str1 = "Hi";
    }
```

