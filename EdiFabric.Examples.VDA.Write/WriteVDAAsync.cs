using EdiFabric.Examples.VDA.Common;
using EdiFabric.Framework.Writers;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.VDA.Write
{
    /// <summary>
    /// Generate and write VDA document to a stream async
    /// </summary>
    class WriteVDAAsync
    {
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the document
            var deliveryInstruction = TS4905Builder.BuildDeliveryInstruction(22, 23);

            using (var stream = new MemoryStream())
            {
                using (var writer = new VdaWriter(stream, Environment.NewLine))
                {
                    //  2. Write it out
                    await writer.WriteAsync(deliveryInstruction);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
