<div dir="rtl">

# مفهوم Enum:

Enum أو Enumuration هو عبارة عن كلاس يحتوي مجموعة من القيم الثابتة التي يمكن استخدامها لأي غرض بالبرنامج.

#### مثال:
يمكن استخدام Enum لإضافة الأيام، الأشهر أو الاتجاهات لبرنامجك. في هذا المثال قمنا بطباعة بعض الأيام مع أرقامها.

المخرجات:

The day is: Sunday

Sunday: 0

Thursday: 4

</div>

```cs
class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thurusday, Friday, Saturday }
        static void Main(string[] args)
        {

            int WeekDayStart = (int)Days.Sunday;
            int WeekDayEnd = (int)Days.Thurusday;
            Days sun = (Days)WeekDayStart;
            Console.WriteLine("The day is: " + sun);
            Console.WriteLine("Sunday: {0}", WeekDayStart);
            Console.WriteLine("Thursday: {0}", WeekDayEnd);

        }
    }

```