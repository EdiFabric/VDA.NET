using EdiFabric.Examples.VDA.Common;
using System;

namespace EdiFabric.Examples.VDA.Write
{
    class Program
    {
        static void Main(string[] args)
        {
            License.SetSerial(Config.TrialSerialKey);

            WriteVDA.Run();
            WriteVDABatch.Run();
            WriteVDAAsync.Run();
        }
    }
}
