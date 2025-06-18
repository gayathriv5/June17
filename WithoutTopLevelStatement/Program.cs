namespace WithoutTopLevelStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Hello());
            Console.WriteLine(Helloname("arya"));
            Console.WriteLine(Hellonamelocation("sree","ktym"));

            
        }
        public static string Hello()
        {
            return "Hellowwww";

        }
        public static string Helloname(string  name)
        {
            return $"Hello{name}";

        }
        public static string Hellonamelocation(string name,string location)
        {
            return $"Hello{name},from{location}";

        }
    }
    
}
