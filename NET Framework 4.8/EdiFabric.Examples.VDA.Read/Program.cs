using EdiFabric.Examples.VDA.Common;

namespace EdiFabric.Examples.VDA.Read
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            ReadVDA.Run();
            ReadVDABatch.Run();
            ReadVDAAsync.Run();
        }
    }
}
