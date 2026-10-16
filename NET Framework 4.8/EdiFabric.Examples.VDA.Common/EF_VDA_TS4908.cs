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
    [Message("VDA", "4908")]
    public class TS4908 : EdiMessage
    {
        [Required]
        [Pos(1)]
        public S821 S821 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4908_S822Loop> S822Loop { get; set; }

        [Required]
        [Pos(3)]
        public S829 S829 { get; set; }        
    }
    
    [DataContract()]
    [Serializable()]
    [Group(typeof(S822))]
    public class TS4908_S822Loop
    {
        [Required]
        [Pos(1)]
        public S822 S822 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4908_S823Loop> S823Loop { get; set; }

        [Pos(3)]
        public S828 S828 { get; set; }     
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(S823))]
    public class TS4908_S823Loop
    {
        [Required]
        [Pos(1)]
        public S823 S823 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4908_S824Loop> S824Loop { get; set; }

        [Pos(3)]
        public S827 S827 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(S824))]
    public class TS4908_S824Loop
    {
        [Required]
        [Pos(1)]
        public S824 S824 { get; set; }

        [Pos(2)]
        public S825 S825 { get; set; }

        [Required]
        [Pos(3)]
        public S826 S826 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("821", false, ' ')]
    public class S821
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("821_01", typeof(VDA_ID_821_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("821_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("821_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomerCode_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("821_04", typeof(VDA_AN))]
        [Pos(4)]
        public string SupplierCode_04 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("821_05", typeof(VDA_N0))]
        [Pos(5)]
        public string TransmissionNumberOld_05 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("821_06", typeof(VDA_N0))]
        [Pos(6)]
        public string TransmissionNumberNew_06 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("821_07", typeof(VDA_DT))]
        [Pos(7)]
        public string TransmissionDate_07 { get; set; }

        [StringLength(20, 20)]
        [DataElement("821_08", typeof(VDA_AN))]
        [Pos(8)]
        public string VatNumberOfRecipient_08 { get; set; }

        [StringLength(20, 20)]
        [DataElement("821_09", typeof(VDA_AN))]
        [Pos(9)]
        public string VatNumberOfSender_09 { get; set; }

        [StringLength(25, 25)]
        [DataElement("821_10", typeof(VDA_AN))]
        [Pos(10)]
        public string CompanyRegistrationNumber_10 { get; set; }

        [Required]
        [StringLength(24, 24)]
        [DataElement("821_11", typeof(VDA_AN))]
        [Pos(11)]
        public string Blanks_11 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("822", false, ' ')]
    public class S822
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("822_01", typeof(VDA_ID_822_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("822_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("822_03", typeof(VDA_AN))]
        [Pos(3)]
        public string SelfBillingInvoiceNumber_03 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("822_04", typeof(VDA_DT))]
        [Pos(4)]
        public string SelfBillingInvoiceDate_04 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("822_05", typeof(VDA_DT))]
        [Pos(5)]
        public string DueDate_05 { get; set; }

        [StringLength(13, 13)]
        [DataElement("822_06", typeof(VDA_N0))]
        [Pos(6)]
        public string SurchargesDeductions_06 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("822_07", typeof(VDA_N0))]
        [Pos(7)]
        public string SignCode_07 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("822_08", typeof(VDA_N0))]
        [Pos(8)]
        public string TotalCashDiscountAmount_08 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("822_09", typeof(VDA_N0))]
        [Pos(9)]
        public string TotalVatamount_09 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("822_10", typeof(VDA_N0))]
        [Pos(10)]
        public string TotalSelfBillingInvoice_10 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("822_11", typeof(VDA_N0))]
        [Pos(11)]
        public string SignCode_11 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("822_12", typeof(VDA_AN))]
        [Pos(12)]
        public string Currency_12 { get; set; }

        [StringLength(14, 14)]
        [DataElement("822_13", typeof(VDA_AN))]
        [Pos(13)]
        public string ConsignmentIdentification_13 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("822_14", typeof(VDA_N0))]
        [Pos(14)]
        public string SelfBillingInvoiceCode_14 { get; set; }

        [StringLength(2, 2)]
        [DataElement("822_15", typeof(VDA_AN))]
        [Pos(15)]
        public string CountryCode_15 { get; set; }

        [StringLength(8, 8)]
        [DataElement("822_16", typeof(VDA_N0))]
        [Pos(16)]
        public string CreditorBookingNumber_16 { get; set; }

        [Required]
        [StringLength(21, 21)]
        [DataElement("822_17", typeof(VDA_AN))]
        [Pos(17)]
        public string Blanks_17 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("823", false, ' ')]
    public class S823
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("823_01", typeof(VDA_ID_823_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("823_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("823_03", typeof(VDA_AN))]
        [Pos(3)]
        public string DeliveryNoteNumber_03 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("823_04", typeof(VDA_AN))]
        [Pos(4)]
        public string PlantCustomer_04 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("823_05", typeof(VDA_DT))]
        [Pos(5)]
        public string DispatchDate_05 { get; set; }

        [StringLength(13, 13)]
        [DataElement("823_06", typeof(VDA_N0))]
        [Pos(6)]
        public string TotalSurchargesDeductions_06 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("823_07", typeof(VDA_N0))]
        [Pos(7)]
        public string SignCode_07 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("823_08", typeof(VDA_N0))]
        [Pos(8)]
        public string CashDiscountAmount_08 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("823_09", typeof(VDA_N0))]
        [Pos(9)]
        public string VatAmount_09 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("823_10", typeof(VDA_N0))]
        [Pos(10)]
        public string DeliveryNoteTotal_10 { get; set; }

        [StringLength(1, 1)]
        [DataElement("823_11", typeof(VDA_N0))]
        [Pos(11)]
        public string SignCode_11 { get; set; }

        [StringLength(12, 12)]
        [DataElement("823_12", typeof(VDA_AN))]
        [Pos(12)]
        public string ContractualPurchaseOrderNumber_12 { get; set; }

        [StringLength(5, 5)]
        [DataElement("823_13", typeof(VDA_AN))]
        [Pos(13)]
        public string UnloadingPoint_13 { get; set; }

        [StringLength(8, 8)]
        [DataElement("823_14", typeof(VDA_AN))]
        [Pos(14)]
        public string BookingUnloadingNumber_14 { get; set; }

        [StringLength(6, 6)]
        [DataElement("823_15", typeof(VDA_DT))]
        [Pos(15)]
        public string StockReceiptDate_15 { get; set; }

        [StringLength(15, 15)]
        [DataElement("823_16", typeof(VDA_AN))]
        [Pos(16)]
        public string CustomerPersonToContact_16 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("823_17", typeof(VDA_N0))]
        [Pos(17)]
        public string Blanks_17 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("824", false, ' ')]
    public class S824
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("824_01", typeof(VDA_ID_824_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("824_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("824_03", typeof(VDA_N0))]
        [Pos(3)]
        public string TransactionCode_03 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("824_04", typeof(VDA_AN))]
        [Pos(4)]
        public string CustomerReferenceNumber_04 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("824_05", typeof(VDA_N0))]
        [Pos(5)]
        public string DeliveryQuantity_05 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("824_06", typeof(VDA_AN))]
        [Pos(6)]
        public string UnitOfQuantity7_06 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("824_07", typeof(VDA_N0))]
        [Pos(7)]
        public string PriceUnit_07 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("824_08", typeof(VDA_N0))]
        [Pos(8)]
        public string UnitPrice_08 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("824_09", typeof(VDA_N0))]
        [Pos(9)]
        public string TotalPrice_09 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("824_10", typeof(VDA_N0))]
        [Pos(10)]
        public string SignCode_10 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("824_11", typeof(VDA_N0))]
        [Pos(11)]
        public string CashDiscountPercentage_11 { get; set; }

        [StringLength(13, 13)]
        [DataElement("824_12", typeof(VDA_N0))]
        [Pos(12)]
        public string CashdiscountAmount_12 { get; set; }

        [Required]
        [StringLength(4, 4)]
        [DataElement("824_13", typeof(VDA_N0))]
        [Pos(13)]
        public string VatRate_13 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("824_14", typeof(VDA_N0))]
        [Pos(14)]
        public string VatAmount_14 { get; set; }

        [StringLength(14, 14)]
        [DataElement("824_15", typeof(VDA_AN))]
        [Pos(15)]
        public string CustomerTestReportNumber_15 { get; set; }
        
        [Required]
        [StringLength(7, 7)]
        [DataElement("824_16", typeof(VDA_AN))]
        [Pos(16)]
        public string Blanks_16 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("825", false, ' ')]
    public class S825
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("825_01", typeof(VDA_ID_825_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("825_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("825_03", typeof(VDA_N0))]
        [Pos(3)]
        public string CodeSurchargeDeduction_03 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("825_04", typeof(VDA_N0))]
        [Pos(4)]
        public string AmountSurchargeDeduction_04 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("825_05", typeof(VDA_N0))]
        [Pos(5)]
        public string SignCode_05 { get; set; }
        
        [StringLength(107, 107)]
        [DataElement("825_06", typeof(VDA_AN))]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("826", false, ' ')]
    public class S826
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("826_01", typeof(VDA_ID_826_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("826_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("826_03", typeof(VDA_N0))]
        [Pos(3)]
        public string PriceUnit_03 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("826_04", typeof(VDA_N0))]
        [Pos(4)]
        public string NewPrice_04 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("826_05", typeof(VDA_DT))]
        [Pos(5)]
        public string ValidityDate_05 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("826_06", typeof(VDA_N0))]
        [Pos(6)]
        public string TotalDifference_06 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("826_07", typeof(VDA_N0))]
        [Pos(7)]
        public string SignCode_07 { get; set; }

        [Required]
        [StringLength(88, 88)]
        [DataElement("826_08", typeof(VDA_N0))]
        [Pos(8)]
        public string Blanks_08 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("827", false, ' ')]
    public class S827
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("827_01", typeof(VDA_ID_827_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("827_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(40, 40)]
        [DataElement("827_03", typeof(VDA_AN))]
        [Pos(3)]
        public string Text1_03 { get; set; }

        [Required]
        [StringLength(40, 40)]
        [DataElement("827_04", typeof(VDA_AN))]
        [Pos(4)]
        public string Text2_04 { get; set; }

        [Required]
        [StringLength(40, 40)]
        [DataElement("827_05", typeof(VDA_AN))]
        [Pos(5)]
        public string Text3_05 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("827_06", typeof(VDA_AN))]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("828", false, ' ')]
    public class S828
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("828_01", typeof(VDA_ID_828_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("828_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("828_03", typeof(VDA_AN))]
        [Pos(3)]
        public string Currency_03 { get; set; }

        [StringLength(17, 17)]
        [DataElement("828_04", typeof(VDA_N0))]
        [Pos(4)]
        public string ExchangeRate_04 { get; set; }

        [StringLength(6, 6)]
        [DataElement("828_05", typeof(VDA_DT))]
        [Pos(5)]
        public string ExchangeRateDate_05 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("828_06", typeof(VDA_N0))]
        [Pos(6)]
        public string TotalSelfBillingInvoiceIncludingVat_06 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("828_07", typeof(VDA_N0))]
        [Pos(7)]
        public string TotalSelfBillingInvoiceWithoutVat_07 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("828_08", typeof(VDA_N0))]
        [Pos(8)]
        public string TotlaVatAmount_08 { get; set; }
        
        [Required]
        [StringLength(58, 58)]
        [DataElement("828_09", typeof(VDA_AN))]
        [Pos(09)]
        public string Blanks_09 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("829", false, ' ')]
    public class S829
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("829_01", typeof(VDA_ID_829_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("829_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_03", typeof(VDA_N0))]
        [Pos(3)]
        public string CounterRecordType821_03 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_04", typeof(VDA_N0))]
        [Pos(4)]
        public string CounterRecordType822_04 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_05", typeof(VDA_N0))]
        [Pos(5)]
        public string CounterRecordType823_05 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_06", typeof(VDA_N0))]
        [Pos(6)]
        public string CounterRecordType824_06 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_07", typeof(VDA_N0))]
        [Pos(7)]
        public string CounterRecordType825_07 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_08", typeof(VDA_N0))]
        [Pos(8)]
        public string CounterRecordType826_08 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_09", typeof(VDA_N0))]
        [Pos(9)]
        public string CounterRecordType827_09 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_10", typeof(VDA_N0))]
        [Pos(10)]
        public string CounterRecordType829_10 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("829_11", typeof(VDA_N0))]
        [Pos(11)]
        public string CounterRecordType828_11 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("829_12", typeof(VDA_N0))]
        [Pos(12)]
        public string TotalVatAmount_12 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("829_13", typeof(VDA_N0))]
        [Pos(13)]
        public string TotalPayment_13 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("829_14", typeof(VDA_N0))]
        [Pos(14)]
        public string SignCode_14 { get; set; }

        [StringLength(1, 1)]
        [DataElement("829_15", typeof(VDA_N0))]
        [Pos(15)]
        public string PaymentMode_15 { get; set; }

        [Required]
        [StringLength(32, 32)]
        [DataElement("829_16", typeof(VDA_AN))]
        [Pos(16)]
        public string Blanks_16 { get; set; }
    }
}
