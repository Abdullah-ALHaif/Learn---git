<div dir="rtl">

# Class keyword:

الكلاس هو هيكل البيانات والذي يمكن عن طريقه تعريف الـ الخصائص و الـ methods وكذلك يمكن عن طريقه تعريف البيانات وأنواعها وكذلك إنشاء الـ objects.

## مثال:

</div>

```
public class MyClass
{
    public string  myField = string.Empty;

    public MyClass()
    {
    }

    public void MyMethod(int parameter1, string parameter2)
    {
        Console.WriteLine("First Parameter {0}, second parameter {1}", 
                                                    parameter1, parameter2);
    }

    public int MyImplementedProperty { get; set; }

    private int myPropertyVar;
    
    public int MyProperty
    {
        get { return myPropertyVar; }
        set { myPropertyVar = value; }
    } 
}

```