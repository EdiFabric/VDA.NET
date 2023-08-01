using EdiFabric.Examples.VDA.Common;

namespace EdiFabric.Examples.VDA.Read
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);
            //  Uncomment and then comment out the line above if you wish to use distributed cache for tokens
            //  TokenFileCache.Set();

            ReadVDA.Run();
            ReadVDABatch.Run();
            ReadVDAAsync.Run();
        }
    }
}
