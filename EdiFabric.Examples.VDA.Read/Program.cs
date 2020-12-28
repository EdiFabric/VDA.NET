using EdiFabric.Examples.VDA.Common;

namespace EdiFabric.Examples.VDA.Read
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(TrialLicense.SerialKey);

            ReadVDA.Run();
            ReadVDABatch.Run();
            ReadVDAAsync.Run();
        }
    }
}
