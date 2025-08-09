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

            object[] tonsOfObjects = new object[50000];

            for (int i = 0; i < 50000; i++)
            {
                tonsOfObjects[i] = new object();
            }

            Console.WriteLine("Force Garbage Collection");

            GC.Collect(0, GCCollectionMode.Forced);

            GC.WaitForPendingFinalizers();

            Console.WriteLine($"Generation of refToMyCar2 is: {GC.GetGeneration(refToMyCar2)}");

            if (tonsOfObjects[9000] != null){
                Console.WriteLine($"Generation of tonsOfObjects[9000] is: {GC.GetGeneration(tonsOfObjects[9000])}");
            }
            else
            {
                Console.WriteLine($"tonsOfObject[9000] is no longer alive.");
            }

            Console.WriteLine($"\nGen 0 has been swet {GC.CollectionCount(0)} times.");

            Console.WriteLine($"Gen 1 has been sweet {GC.CollectionCount(1)} times.");

            Console.WriteLine($"Gen 2 has been swet {GC.CollectionCount(2)} times.");
        }

        static void MakeACar()
        {
            Car myCar = new Car();

            myCar = null;
        }
    }
}
