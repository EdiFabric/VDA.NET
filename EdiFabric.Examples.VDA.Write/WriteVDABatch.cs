using EdiFabric.Examples.VDA.Common;
using EdiFabric.Framework.Writers;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace EdiFabric.Examples.VDA.Write
{
    /// <summary>
    /// Generate and write a batch of VDA documents to a stream
    /// </summary>
    class WriteVDABatch
    {
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Construct the first document
            var deliveryInstruction1 = TS4905Builder.BuildDeliveryInstruction(22, 23);

            //  2.  Construct the second document
            var deliveryInstruction2 = TS4905Builder.BuildDeliveryInstruction(23, 24);

            using (var stream = new MemoryStream())
            {
                using (var writer = new VdaWriter(stream, Environment.NewLine))
                {
                    //  3. Write them out
                    writer.Write(deliveryInstruction1);
                    writer.Write(deliveryInstruction2);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
