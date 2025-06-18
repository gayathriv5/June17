namespace helloclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hello Hi=new Hello();
            Console.WriteLine(Hi.SayHello());  
        }
    }
}
