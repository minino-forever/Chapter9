namespace SimpleDispose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fun with Dispose****\n");

            MyResourceWrapper rw = new MyResourceWrapper();

            if (rw is IDisposable)
            {
                rw.Dispose();
            }

            Console.WriteLine("\nDemonsrate using declarations");

            UsingDeclaration();
        }

        private static void UsingDeclaration()
        {
            using var rw = new MyResourceWrapper();

            Console.WriteLine("About to dispose");
        }
    }
}
