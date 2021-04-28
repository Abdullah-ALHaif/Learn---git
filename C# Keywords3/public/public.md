<div dir="rtl">

# public:
هو نوع من أنواع الـ access modifiers والذي يسمح للـ classesو fieldsو method والخصائص بالوصول إليها من أي مكان بالكود.

#### مثال:
نلاحظ في هذا المثال أنه تم طباعة BMW بالرغم من وجودها في class آخر وذلك لأن المتغير public ولذلك تم الوصول إليه.

</div>



```CS
class Car
{
  public string model = "BMW";
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

