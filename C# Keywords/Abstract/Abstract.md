<div dir="rtl">

# مفهوم Abstract:

Abstract: هو نوع من أنواع الكلاسات والذي يمكن أن يكون base ولكن لا يمكن إنشاء Objects منه حيث يمكن إنشاء Objects من الكلاسات التي ترث منه فقط. حيث أنه مخصص لتعريف الدوال فقط وليس لاستدعائها أو التعامل معها مباشرة من نفس الكلاس.

#### مثال:

</div>

```
using System;

namespace Night0204
{
    public abstract class Shape 
    
    {
        public abstract void draw();
    }

    public class Rectangle : Shape //Inherited
    {
        public override void draw()
        {
            Console.WriteLine("Rectangle ..");
        }
    }

    public class Square : Shape //Inherited
    {
        public override void draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class Triangle : Shape //Inherited
    {
        public override void draw()
        {
            Console.WriteLine("Triangle ..");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Circle");
        }
    }
    class Program
    {
        static void doAction (Shape s) //cannot be read as an object -> Shape or any subclass which it inherit from
        {

        }

        static void drawShape (Shape s)
        {
            s.draw();
        }

        

        static void Main(string[] args)
        {
            //Polymorphism

            // Polymorphism must be abstract...
            Shape[] shapes =
            {
                new Rectangle(),
                new Triangle(),
                new Circle(),
                new Square()
            };


            

            Shape newShape = new Rectangle();
            Rectangle r = (Rectangle)shapes[0];
            Shape s = shapes[0];  // as a pointer .. takes a role of an object but it's not an object.

            
            s.draw();

           /* foreach (Shape shape in shapes)
            {
                shape.draw();
            }*/

            
            Circle c = new Circle();
            
            s.draw();
            

            
        }
    }
}


```