<div dir="rtl">

# private:

هي نوع من أنواع الـ access modifiers وهي ذات أعلى مستوى من الخصوصية حيث تجعل الكلاسات والـ methods غير قابلة للوصول إليها إلا من نفس الكلاس ولا يمكن الوصول إليها من كلاسات أخرى حتى لو كانت موروثة منه.

#### مثال:
في هذا المثال سيظهر خطأ ولا يمكن طباعة موديل السيارة لأنها موجودة بداخل متغير من نوع private.

</div>

```cs
class Car
{
  private string model = "BMW";
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

