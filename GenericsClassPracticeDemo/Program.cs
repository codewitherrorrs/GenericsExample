namespace GenericsClassPracticeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericsDemo<string> genericDemo = new GenericsDemo<string>("Sagar");
            GenericsDemo<int> generic = new GenericsDemo<int>(9);
            GenericsDemo<double> gen = new GenericsDemo<double>(9.52);
            genericDemo.DemoData("Shahu");
            genericDemo.DemoMethod<string>("Krishna");
            genericDemo.DemoMethod<int>(25);
            genericDemo.DemoMethod<double>(25.256);
            Console.ReadKey();

        } 
    }
}