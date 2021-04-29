<div dir="rtl">

# params:
هي keyword تستخدم لاستقبال عدد كبير من الـ arguments ولكن يجب أن تكون من نفس النوع، ومن شروطها أن يتم تحديد نوع الـ arguments وأن تكون على شكل array ذات صف واحد فقط حيث أنها لا تقبل multi-dimensional array.

#### مثال:
في هذا المثال تم استخدام params ووضعه بدالة لاستقبال مصفوفة من نوع integer وتم استدعاءها لطباعة الأرقام من 1 إلى 6.

</div>

```cs
class Program
    {
        public static void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            UseParams(1, 2, 3, 4, 5, 6); 
        }
    }

```