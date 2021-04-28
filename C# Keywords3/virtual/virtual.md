<div dir="rtl">

# virtual:
virtual هو نوع من أنواع الـ modifiers والذي يجعل الـ class أو الـ method قابلة للتعديل عليها أو بمعنى آخر لا يتم تنفيذ ما بداخلها عند وجود override class أو method.

#### مثال:
في هذا المثال سيكون الـ الناتج: subClass Saying Hello! وذلك  لأن الـ Compiler سيقوم بتنفيذ ما بداخل override عوضاً عن ما بداخل virtual.

</div>

```cs
using System;  
namespace Hello_Word  
{  
    class baseClass  
    {  
        public virtual void Greetings()  
        {  
            Console.WriteLine("baseClass Saying Hello!");  
        }  
    }  
    class subClass : baseClass  
    {  
        public override void Greetings()  
        {  
            Console.WriteLine("subClass Saying Hello!");  
              
        }  
    }  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            baseClass obj1 = new subClass();  
            obj1.Greetings();   
        }  
    }  
} 
```

