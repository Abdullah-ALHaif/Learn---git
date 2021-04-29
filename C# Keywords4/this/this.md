<div dir="rtl">

# this:
هي keyword تشير إلى instance معين من نفس الكلاس وأيضاً يتم استخدامها للتفريق عند تشابه الأسماء لـ parameters لدالة معينة بنفس الكلاس والـ fields التي تتبع نفس الكلاس.

#### مثال:
في هذا المثال، تم استخدام 'this' للإشارة إلى الـ fields من نفس الكلاس وهنا يتضح استخدامها للتفريق بين أسماء fields والـ parameters تبع الـ constructor.

</div>

```cs
class Student {
   public int id, age;  
   public String name, subject;

   public Student(int id, String name, int age, String subject) {
      this.id = id;
      this.name = name;
      this.subject = subject;
      this.age = age;
   }

```