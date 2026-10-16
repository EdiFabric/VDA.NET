using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Vda;

namespace EdiFabric.Templates.Vda
{
    [DataContract()]
    [Serializable()]
    [Message("VDA", "4906")]
    public class TS4906 : EdiMessage
    {
        [Required]
        [Pos(1)]
        public S811 S811 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4906_S812Loop> S812Loop { get; set; }

        [Required]
        [Pos(3)]
        public S819 S819 { get; set; }        
    }
    
    [DataContract()]
    [Serializable()]
    [Group(typeof(S812))]
    public class TS4906_S812Loop
    {
        [Required]
        [Pos(1)]
        public S812 S812 { get; set; }

        [Required]
        [Pos(2)]
        public List<S813> S813 { get; set; }

        [Required]
        [Pos(3)]
        public List<S814> S814 { get; set; }    
    }

    [DataContract()]
    [Serializable()]
    [Segment("811", false, ' ')]
    public class S811
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("811_01", typeof(VDA_ID_811_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("811_02", typeof(VDA_ID_V2))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("811_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomerNumber_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("811_04", typeof(VDA_AN))]
        [Pos(4)]
        public string SupplierNumber_04 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("811_05", typeof(VDA_N0))]
        [Pos(5)]
        public string TransmissionNumberOld_05 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("811_06", typeof(VDA_N0))]
        [Pos(6)]
        public string TransmissionNumberNew_06 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("811_07", typeof(VDA_DT))]
        [Pos(7)]
        public string TransmissionDate_07 { get; set; }

        [Required]
        [StringLength(20, 20)]
        [DataElement("811_08", typeof(VDA_AN))]
        [Pos(8)]
        public string VatNumberOfRecipient_08 { get; set; }
        
        [Required]
        [StringLength(20, 20)]
        [DataElement("811_09", typeof(VDA_AN))]
        [Pos(9)]
        public string VatNumberOfSender_09 { get; set; }

        [Required]
        [StringLength(49, 49)]
        [DataElement("811_10", typeof(VDA_AN))]
        [Pos(10)]
        public string Blanks_10 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("812", false, ' ')]
    public class S812
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("812_01", typeof(VDA_ID_812_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("812_02", typeof(VDA_ID_V2))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("812_03", typeof(VDA_AN))]
        [Pos(3)]
        public string InvoiceNumber_03 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("812_04", typeof(VDA_DT))]
        [Pos(4)]
        public string InvoiceDate_04 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("812_05", typeof(VDA_N2))]
        [Pos(5)]
        public string AmountOfVat_05 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("812_06", typeof(VDA_N2))]
        [Pos(6)]
        public string InvoiceFinalValue_06 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("812_07", typeof(VDA_N0))]
        [Pos(7)]
        public string Currency_07 { get; set; }

        [StringLength(10, 10)]
        [DataElement("812_08", typeof(VDA_AN))]
        [Pos(8)]
        public string ReferenceNumber_08 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("812_09", typeof(VDA_N1))]
        [Pos(9)]
        public string VatRate_09 { get; set; }

        [StringLength(3, 3)]
        [DataElement("812_10", typeof(VDA_AN))]
        [Pos(10)]
        public string PlantNumber_10 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("812_11", typeof(VDA_N2))]
        [Pos(11)]
        public string Fee_11 { get; set; }

        [Required]
        [StringLength(51, 51)]
        [DataElement("812_12", typeof(VDA_AN))]
        [Pos(12)]
        public string Blanks_12 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("813", false, ' ')]
    public class S813
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("813_01", typeof(VDA_ID_813_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("813_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("813_03", typeof(VDA_AN))]
        [Pos(3)]
        public string DeliveryNoteNumber_03 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("813_04", typeof(VDA_DT))]
        [Pos(4)]
        public string ShippingDate_04 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("813_05", typeof(VDA_AN))]
        [Pos(5)]
        public string UnloadingPoint_05 { get; set; }

        [StringLength(2, 2)]
        [DataElement("813_06", typeof(VDA_N0))]
        [Pos(6)]
        public string ShipmentType_06 { get; set; }

        [Required]
        [StringLength(4, 4)]
        [DataElement("813_07", typeof(VDA_AN))]
        [Pos(7)]
        public string OrdererTag_07 { get; set; }

        [Required]
        [StringLength(12, 12)]
        [DataElement("813_08", typeof(VDA_AN))]
        [Pos(8)]
        public string FinalOrderNumber_08 { get; set; }

        [StringLength(13, 13)]
        [DataElement("813_09", typeof(VDA_N2))]
        [Pos(9)]
        public string ShippingCosts_09 { get; set; }

        [StringLength(13, 13)]
        [DataElement("813_10", typeof(VDA_N2))]
        [Pos(10)]
        public string PackagingCosts_10 { get; set; }
        
        [Required]
        [StringLength(60, 60)]
        [DataElement("813_11", typeof(VDA_AN))]
        [Pos(11)]
        public string Blanks_11 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("814", false, ' ')]
    public class S814
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("814_01", typeof(VDA_ID_814_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("814_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("814_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomerPartNumber_03 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("814_04", typeof(VDA_AN))]
        [Pos(4)]
        public string SupplierPartNumber_04 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("814_05", typeof(VDA_N3))]
        [Pos(5)]
        public string DeliveryQuantity_05 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("814_06", typeof(VDA_N0))]
        [Pos(6)]
        public string PriceUnit_06 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("814_07", typeof(VDA_N3))]
        [Pos(7)]
        public string UnitPrice_07 { get; set; }

        [StringLength(13, 13)]
        [DataElement("814_08", typeof(VDA_N3))]
        [Pos(8)]
        public string TotalPrice_08 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("814_09", typeof(VDA_AN))]
        [Pos(9)]
        public string Empty_09 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("814_10", typeof(VDA_N0))]
        [Pos(10)]
        public string CountryOfOrigin_10 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("814_11", typeof(VDA_AN))]
        [Pos(11)]
        public string VatPreference_11 { get; set; }

        [StringLength(4, 4)]
        [DataElement("814_12", typeof(VDA_N2))]
        [Pos(12)]
        public string AdvancePaymentPercentage_12 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("814_13", typeof(VDA_AN))]
        [Pos(13)]
        public string TradingPreference_13 { get; set; }

        [Required]
        [StringLength(26, 26)]
        [DataElement("814_14", typeof(VDA_AN))]
        [Pos(14)]
        public string Blanks_14 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("819", false, ' ')]
    public class S819
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("819_01", typeof(VDA_ID_819_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("819_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("819_03", typeof(VDA_N0))]
        [Pos(3)]
        public string CounterRecordType811_03 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("819_04", typeof(VDA_N0))]
        [Pos(4)]
        public string CounterRecordType812_04 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("819_05", typeof(VDA_N0))]
        [Pos(5)]
        public string CounterRecordType813_05 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("819_06", typeof(VDA_N0))]
        [Pos(6)]
        public string CounterRecordType814_06 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("819_07", typeof(VDA_N0))]
        [Pos(7)]
        public string CounterRecordType819_07 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("819_08", typeof(VDA_N2))]
        [Pos(8)]
        public string InvoiceTotalFinalValue_08 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("819_09", typeof(VDA_N2))]
        [Pos(9)]
        public string SumOfFees1_09 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("819_10", typeof(VDA_N2))]
        [Pos(10)]
        public string SumOfVatAmount1_10 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("819_11", typeof(VDA_N1))]
        [Pos(11)]
        public string VatRate1_11 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("819_12", typeof(VDA_N2))]
        [Pos(12)]
        public string SumOfFees2_12 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("819_13", typeof(VDA_N2))]
        [Pos(13)]
        public string SumOfVatAmount2_13 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("819_14", typeof(VDA_N1))]
        [Pos(14)]
        public string VatRate2_14 { get; set; }

        [Required]
        [StringLength(17, 17)]
        [DataElement("819_15", typeof(VDA_AN))]
        [Pos(15)]
        public string Blanks_15 { get; set; }
    }
}
