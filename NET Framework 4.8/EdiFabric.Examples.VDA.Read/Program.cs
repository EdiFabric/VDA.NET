using EdiFabric.Examples.VDA.Common;

namespace EdiFabric.Examples.VDA.Read
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            ReadVDA.Run();
            ReadVDABatch.Run();
            ReadVDAAsync.Run();
        }
    }
}
