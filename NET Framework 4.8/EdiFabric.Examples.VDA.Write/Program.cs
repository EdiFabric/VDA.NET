using EdiFabric.Examples.VDA.Common;
using System;

namespace EdiFabric.Examples.VDA.Write
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            WriteVDA.Run();
            WriteVDABatch.Run();
            WriteVDAAsync.Run();
        }
    }
}
