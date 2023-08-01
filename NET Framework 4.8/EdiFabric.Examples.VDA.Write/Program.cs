using EdiFabric.Examples.VDA.Common;

namespace EdiFabric.Examples.VDA.Write
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);

            WriteVDA.Run();
            WriteVDABatch.Run();
            WriteVDAAsync.Run();
        }
    }
}
