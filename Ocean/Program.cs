namespace Ocean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleOutput output = new ConsoleOutput();
            Ocean ocean = new Ocean(output);
            ocean.InputValues();
            ocean.InitCells();
            ocean.Run();
        }
    }
}


