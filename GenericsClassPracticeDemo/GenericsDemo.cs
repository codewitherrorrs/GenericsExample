using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassPracticeDemo
{
    //Generic means the general form .
    //It doesn't specific to a particular dataytype datatype.
    //We are using <> (Angular Bracket) with type name.
    // TypeName<T> T is your Type parameter.
    //Generic allow us to a single class or method that can be used in different datatype.
    //Advantages is like we can reuse our code.
    public class GenericsDemo<T>
    {
        //It is variable of type T.
        public T data;
        //Generic Constructor.
        public GenericsDemo(T data) 
        {
            this.data = data;
            Console.WriteLine($"Data : {this.data}");
        }

        public void DemoData(T data)
        {
            Console.WriteLine($"Data : {data}");
        }
        public void DemoMethod<T>(T data)
        {
            Console.WriteLine($"Data : {data}");
        }
    }
}
