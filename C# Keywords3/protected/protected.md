<div dir="rtl">

# protected:
هو نوع من أنواع الـ access modifiers والذي يسمح للـ methods والخصائص بالوصول إليها فقط في حال وجودها في نفس الـ class أو الكلاسات التي ترث منها فقط. ولا يمكن الوصول إليها من الكلاسات الأخرى.

#### مثال:
في هذا المثال سيظهر Error وذلك لأن المتغير protected ولا يمكن الوصول إليه إلا إذا كان في نفس الكلاس أو إذا كان مستدعى من كلاس موروث من نفس الكلاس.

</div>

```cs

    class Car
    {
        protected string model = "BMW";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }

```

