<div dir="rtl">

# Object:
Object هو عبارة عن كائن يمكن أن يخرج لي قيمة من class معين أو لينفذ method معين بداخله.

#### مثال:

في هذا المثال تم إنشاء Object من كلاس Cat واستدعاءه لينفذ ما بداخل print ليطبع كلمة Object.

</div>

```cs
class Program
    {
        static void Main(string[] args)
        {
            Animal.Cat c = new Animal.Cat();
            c.print();
        }
        
        public class Cat
        {
            public void print()
            {
                Console.WriteLine("Object");
            }
        }
    }

```