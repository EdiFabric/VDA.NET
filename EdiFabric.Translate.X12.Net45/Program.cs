using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Translate.X12.Net45
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Demo for X12 004010
            //  Download additional X12 versions from https://support.edifabric.com/hc/en-us/categories/360001758952
            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\PurchaseOrders_850.txt"), "EdiFabric.Templates.X12", new X12ReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TS850>();
        }
    }
}