using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Edifact;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Translate.EDIFACT.Core20
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Demo for EDIFACT D.96A
            //  Download additional EDIFACT versions from https://support.edifabric.com/hc/en-us/categories/360001758952
            List<IEdiItem> ediItems;
            using (var reader = new EdifactReader(File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Invoices_INVOIC.txt"), "EdiFabric.Templates.Edifact", new EdifactReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            var invoices = ediItems.OfType<TSINVOIC>();
        }
    }
}