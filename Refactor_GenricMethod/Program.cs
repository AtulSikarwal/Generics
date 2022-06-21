namespace GenericsAss
{
    class Program
    {
        public static void Main(String[] args)
        {
            Method method = new Method();

            Console.WriteLine(method.intMax(50, 39, 22));
            Console.WriteLine(method.floatMax(50.2, 39.2, 2.2));
            Console.WriteLine(method.FindMaxString("Atul","Arjun","Sikarwal"));

            GenricMethod result=new GenricMethod();
               result.ToMax<int>(3, 4, 2);
            result.ToMax<double>(3.3, 4.2, 2.1);
            result.ToMax<string>("Atul", "Arjun", "Sikarwal");

        }
    }
}