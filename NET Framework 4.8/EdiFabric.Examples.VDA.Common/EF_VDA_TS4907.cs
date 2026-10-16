using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Vda;
using System;
using System.Collections.Generic;

namespace EdiFabric.Templates.Vda
{
    [Serializable]
    [Message("VDA", "4907")]
    public class TS4907 : EdiMessage
	{
		[Required]
		[Pos(1)]
		public S911 S911 { get; set; }

		[Required]
		[Pos(2)]
		public List<TS4907_S912Loop> S912Loop { get; set; }

		[Required]
		[Pos(3)]
		public S919 S919 { get; set; }
	}

	[Serializable()]
	[Group(typeof(S912))]
	public class TS4907_S912Loop
	{

		[Required]
		[Pos(1)]
		public S912 S912 { get; set; }
	}

	[Serializable]
	[Segment("911", false, ' ')]
	public class S911
	{
		[Required]
		[StringLength(3, 3)]
		[DataElement("911_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }

		[Required]
		[StringLength(2, 2)]
		[DataElement("911_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }

		[Required]
		[StringLength(9, 9)]
		[DataElement("911_03", typeof(VDA_AN))]
		[Pos(3)]
		public string CustomerCode_03 { get; set; }

		[Required]
		[StringLength(9, 9)]
		[DataElement("911_04", typeof(VDA_AN))]
		[Pos(4)]
		public string SupplierCode_04 { get; set; }

		[Required]
		[StringLength(5, 5)]
		[DataElement("911_05", typeof(VDA_N0))]
		[Pos(5)]
		public string TransmissionNumberOld_05 { get; set; }

		[Required]
		[StringLength(5, 5)]
		[DataElement("911_06", typeof(VDA_N0))]
		[Pos(6)]
		public string TransmissionNumberNew_06 { get; set; }
		
		[Required]
		[StringLength(6, 6)]
		[DataElement("911_07", typeof(VDA_DT))]
		[Pos(7)]
		public string TransmissionDate_07 { get; set; }
		
		[Required]
		[StringLength(6, 6)]
		[DataElement("911_08", typeof(VDA_DT))]
		[Pos(8)]
		public string PaymentDate_08 { get; set; }
		
		[Required]
		[StringLength(6, 6)]
		[DataElement("911_09", typeof(VDA_AN))]
		[Pos(9)]
		public string PaymentNoticeNumber_09 { get; set; }
		
		[Required]
		[StringLength(77, 77)]
		[DataElement("911_09", typeof(VDA_AN))]
		[Pos(10)]
		public string Empty_10 { get; set; }		
	}
	
	[Serializable()]
	[Segment("912", false, ' ')]
	public class S912
	{
		[Required]
		[StringLength(3, 3)]
		[DataElement("912_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }
		
		[Required]
		[StringLength(2, 2)]
		[DataElement("912_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }
		
		[Required]
		[StringLength(8, 8)]
		[DataElement("912_03", typeof(VDA_AN))]
		[Pos(3)]
		public string DeliveryNoteNumber_03 { get; set; }
		
		[Required]
		[StringLength(2, 2)]
		[DataElement("912_04", typeof(VDA_N0))]
		[Pos(4)]
		public string DeliveryType_04 { get; set; }
		
		[Required]
		[StringLength(8, 8)]
		[DataElement("912_05", typeof(VDA_AN))]
		[Pos(5)]
		public string InvoiceNumber_05 { get; set; }
		
		[Required]
		[StringLength(6, 6)]
		[DataElement("912_06", typeof(VDA_DT))]
		[Pos(6)]
		public string InvoiceDate_06 { get; set; }
		
		[Required]
		[StringLength(13, 13)]
		[DataElement("912_07", typeof(VDA_N0))]
		[Pos(7)]
		public string InvoiceFinalValue_07 { get; set; }
		
		[Required]
		[StringLength(1, 1)]
		[DataElement("912_08", typeof(VDA_N0))]
		[Pos(8)]
		public string PlusMinusSign_08 { get; set; }
		
		[Required]
		[StringLength(13, 13)]
		[DataElement("912_09", typeof(VDA_N0))]
		[Pos(9)]
		public string AmountOfDiscount_09 { get; set; }
		
		[Required]
		[StringLength(8, 8)]
		[DataElement("912_10", typeof(VDA_AN))]
		[Pos(10)]
		public string BookNumber_10 { get; set; }
		
		[Required]
		[StringLength(3, 3)]
		[DataElement("912_11", typeof(VDA_N0))]
		[Pos(11)]
		public string Currency_11 { get; set; }
		
		[Required]
		[StringLength(6, 6)]
		[DataElement("912_12", typeof(VDA_AN))]
		[Pos(12)]
		public string PaymentNumber_12 { get; set; }
		
		[Required]
		[StringLength(3, 3)]
		[DataElement("912_13", typeof(VDA_AN))]
		[Pos(13)]
		public string CustomerPlant_13 { get; set; }
		
		[Required]
		[StringLength(52, 52)]
		[DataElement("912_14", typeof(VDA_AN))]
		[Pos(14)]
		public string Empty_14 { get; set; }
	}
	
	[Serializable()]
	[Segment("919", false, ' ')]
	public class S919
	{
		[Required]
		[StringLength(3, 3)]
		[DataElement("919_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }
		
		[Required]
		[StringLength(2, 2)]
		[DataElement("919_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }
		
		[Required]
		[StringLength(7, 7)]
		[DataElement("919_03", typeof(VDA_N0))]
		[Pos(3)]
		public string CounterRecordType911_03 { get; set; }
		
		[Required]
		[StringLength(7, 7)]
		[DataElement("919_04", typeof(VDA_N0))]
		[Pos(4)]
		public string CounterRecordType912_04 { get; set; }
		
		[Required]
		[StringLength(7, 7)]
		[DataElement("919_05", typeof(VDA_N0))]
		[Pos(5)]
		public string CounterRecordType913_05 { get; set; }
		
		[Required]
		[StringLength(1, 1)]
		[DataElement("919_06", typeof(VDA_N0))]
		[Pos(6)]
		public string PaymentMethod_06 { get; set; }
		
		[Required]
		[StringLength(13, 13)]
		[DataElement("919_07", typeof(VDA_N0))]
		[Pos(7)]
		public string PaymentFinalValue_07 { get; set; }
		
		[Required]
		[StringLength(13, 13)]
		[DataElement("919_08", typeof(VDA_N0))]
		[Pos(8)]
		public string FinalValueOfDiscount_08 { get; set; }
		
		[Required]
		[StringLength(13, 13)]
		[DataElement("919_09", typeof(VDA_N0))]
		[Pos(9)]
		public string InvoiceTotal_09 { get; set; }
		
		[Required]
		[StringLength(62, 62)]
		[DataElement("919_10", typeof(VDA_AN))]
		[Pos(10)]
		public string Empty_10 { get; set; }
	}
}
