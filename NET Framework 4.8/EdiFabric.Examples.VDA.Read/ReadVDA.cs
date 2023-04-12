using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.VDA.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EdiFabric.Examples.VDA.Read
{
    class ReadVDA
    {
        /// <summary>
        /// Reads 4905.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\Vda_4905_02.txt");

            //  2.  Read a single transaction
            List<IEdiItem> ediItems;

            using (var ediReader = new VdaReader(ediStream, MessageContextFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }       
        }
        private static MessageContext MessageContextFactory(string segment)
        {
            var id = segment.Substring(0, 5);
            switch (id)
            {
                case "51102":
                    return From4905(segment);
            }

            return null;
        }

        private static MessageContext From4905(string segment)
        {
            var newControlNumber = segment.Substring(29, 5);
            var sender = segment.Substring(15, 9);
            var receiver = segment.Substring(6, 9);

            return new MessageContext("4905", newControlNumber, "1", null, "VDA", null, sender, "", receiver, "", mc => Assembly.Load(new AssemblyName("EdiFabric.Templates.Vda")));
        }
    }
}
