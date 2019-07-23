using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Hipaa5010;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Translate.HIPAA.Core20
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Demo for HIPAA 5010
            //  Download additional HIPAA versions from https://support.edifabric.com/hc/en-us/categories/360001758952
            List<IEdiItem> ediItems;
            using (var reader = new X12Reader(File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\ClaimPayments_837P.txt"), "EdiFabric.Templates.Hipaa", new X12ReaderSettings { ContinueOnError = true } ))
                ediItems = reader.ReadToEnd().ToList();

            var claims = ediItems.OfType<TS837P>();
        }
    }
}