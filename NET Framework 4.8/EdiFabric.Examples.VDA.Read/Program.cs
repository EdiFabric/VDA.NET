using EdiFabric.Examples.VDA.Common;
using System;

namespace EdiFabric.Examples.VDA.Read
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
            //  Uncomment and then comment out the line above if you wish to use distributed cache for tokens
            //  TokenFileCache.Set();

            ReadVDA.Run();
            ReadVDABatch.Run();
            ReadVDAAsync.Run();
        }
    }
}
