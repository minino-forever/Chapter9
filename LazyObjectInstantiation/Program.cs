namespace LazyObjectInstantiation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with Lazy Instantiation**\n");

            MediaPlayer myPlayer = new MediaPlayer();

            myPlayer.Play();

            MediaPlayer yourPlayer = new MediaPlayer();

            AllTracks yourMusic = yourPlayer.GetAllTracks();
        }
    }
}
