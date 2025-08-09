namespace SimpleGC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********GC Basic*******\n");

            Car refToMyCar = new Car("Zippy", 50);

            Console.WriteLine($"{refToMyCar.ToString()}\n");

            Console.WriteLine("*******Fun with System.GC*****\n");

            Console.WriteLine($"Estimated bytes on heap: {GC.GetTotalMemory(false)}");

            Console.WriteLine($"This OS has {GC.MaxGeneration + 1} object generation.\n");

            Car refToMyCar2 = new Car("Zippy", 100);

            Console.WriteLine(refToMyCar2.ToString());

            Console.WriteLine($"Generation of refToMyCar is: {GC.GetGeneration(refToMyCar2)}");
        }

        static void MakeACar()
        {
            Car myCar = new Car();

            myCar = null;
        }
    }
}
