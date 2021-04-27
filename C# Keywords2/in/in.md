<div dir="rtl">

# in keyword:

هي keyword يمكن استخدامها في جملة foreach عند تحديد المصفوفة Array أو List التي يتم التعامل معها وأيضاً يمكن استخدامها عند التعامل مع LinQ Queries عند تحديد عناصر معينة داخل مصفوفة.

وأيضاً in تقوم بنفس عمل ref ولكن  in لا تسمح للدالة التي تم استدعاءها بتغيير قيمة المتغير الممر لها.

#### مثال:
المثال التالي سيطبع عناصر المصفوفة results لأنها هي التي تم استخدامها داخل foreach

</div>

```cs
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
int[] results = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

foreach (int element in results)
{
    Console.WriteLine(element);
}
```

