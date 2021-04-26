<div dir="rtl">

# As Keyword:

هي نوع من أنواع العمليات والتي يمكن من خلالها التحويل من وإلى أنواع بيانات الـ Reference Type أو البيانات التي يمكن أن ترجع null وأيضاً عند إخفاق عملية التحويل فإن as يمكن أن ترجع null بدلاً من أن يحصل خطأ يتسبب بإيقاف البرنامج.

#### مثال:

</div>

```
 string str1 = "GFG";
          
        // taking an Object type variable
        // assigning var1 to it
        object obj1 = str1;
          
        // now try it to cast to a string
        string str2 = obj1 as string;

```