using System;

namespace Assignment_1
{
    class Program
    {
        class JSBuilder
        {
            private string js;

            public JSBuilder()
            {
                this.js = "";
            }
            public JSBuilder content(string content)
            {
                this.js += content;
                return this;
            }
            public JSBuilder function(string function, string data)
            {
                this.js += "function " + function + " " + "(" + data + ")" + "{ \n";
                return this;
            }
            public JSBuilder end(string end)
            {
                this.js += end + "}";
                return this;
            }
            


            public string get()
            {
                return this.js;
            }
        }
        static void Main(string[] args)
        {
                   
            JSBuilder js = new JSBuilder();

            string r = js.function("findElement","array, element")
                .content("var z=false; \n for (var i=0; i<array.length;i++){ \n if (array[i]==element){ \n" +
                "z=true; \n } \n } \n return z;")
                .end("\n").get();

            Console.WriteLine(r);
        }
    }
}
