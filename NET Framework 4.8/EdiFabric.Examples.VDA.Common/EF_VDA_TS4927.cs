using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Vda;
using System;
using System.Collections.Generic;

namespace EdiFabric.Templates.Vda
{
    [Serializable]
    [Message("VDA", "4927")]
    public class TS4927 : EdiMessage
	{
		[Required]
		[Pos(1)]
		public S721 S721 { get; set; }

		[Required]
		[Pos(2)]
		public List<TS4927_S722Loop> S722Loop { get; set; }

		[Required]
		[Pos(3)]
		public S729 S729 { get; set; }
	}

	[Serializable()]
	[Group(typeof(S722))]
	public class TS4927_S722Loop
	{

		[Required]
		[Pos(1)]
		public S722 S722 { get; set; }

		[Required]
		[Pos(2)]
		public List<TS4927_S723Loop> S723Loop { get; set; }
	}

	[Serializable()]
	[Group(typeof(S723))]
	public class TS4927_S723Loop
	{

		[Required]
		[Pos(1)]
		public S723 S723 { get; set; }

		[Pos(2)]
		public List<TS4927_S724Loop> S724Loop { get; set; }
	}

	[Serializable()]
	[Group(typeof(S724))]
	public class TS4927_S724Loop
	{

		[Required]
		[Pos(1)]
		public S724 S724 { get; set; }

		[Pos(3)]
		public S725 S725 { get; set; }
	}

	[Serializable]
	[Segment("721", false, ' ')]
	public class S721
	{
		[Required]
		[StringLength(3)]
		[DataElement("721_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }

		[Required]
		[StringLength(2)]
		[DataElement("721_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }

		[Required]
		[StringLength(9)]
		[DataElement("721_03", typeof(VDA_AN))]
		[Pos(3)]
		public string RecipientNumber_03 { get; set; }

		[Required]
		[StringLength(9)]
		[DataElement("721_04", typeof(VDA_AN))]
		[Pos(4)]
		public string TransmitterNumber_04 { get; set; }

		[Required]
		[StringLength(5)]
		[DataElement("721_05", typeof(VDA_N0))]
		[Pos(5)]
		public string TransmissionNumberOld_05 { get; set; }

		[Required]
		[StringLength(5)]
		[DataElement("721_06", typeof(VDA_N0))]
		[Pos(6)]
		public string TransmissionNumberNew_06 { get; set; }
		
		[Required]
		[StringLength(6)]
		[DataElement("721_07", typeof(VDA_DT))]
		[Pos(7)]
		public string TransmissionDate_07 { get; set; }
		
		[Required]
		[StringLength(2)]
		[DataElement("721_08", typeof(VDA_ID_721_08))]
		[Pos(8)]
		public string TransmissionPurposeCode_08 { get; set; }
		
		[Required]
		[StringLength(40)]
		[DataElement("721_09", typeof(VDA_AN))]
		[Pos(9)]
		public string Text1_09 { get; set; }

		[Required]
		[StringLength(40)]
		[DataElement("721_10", typeof(VDA_AN))]
		[Pos(10)]
		public string Text2_10 { get; set; }

		[Required]
		[StringLength(7)]
		[DataElement("721_11", typeof(VDA_AN))]
		[Pos(11)]
		public string Empty_11 { get; set; }		
	}
	
	[Serializable()]
	[Segment("722", false, ' ')]
	public class S722
	{
		[Required]
		[StringLength(3)]
		[DataElement("722_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }
		
		[Required]
		[StringLength(2)]
		[DataElement("722_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }
		
		[Required]
		[StringLength(9)]
		[DataElement("722_03", typeof(VDA_AN))]
		[Pos(3)]
		public string SupplierNumber_03 { get; set; }
		
		[Required]
		[StringLength(5)]
		[DataElement("722_04", typeof(VDA_AN))]
		[Pos(4)]
		public string SupplierLocationCode_04 { get; set; }
		
		[Required]
		[StringLength(9)]
		[DataElement("722_05", typeof(VDA_AN))]
		[Pos(5)]
		public string CustomerNumber_05 { get; set; }
		
		[Required]
		[StringLength(5)]
		[DataElement("722_06", typeof(VDA_AN))]
		[Pos(6)]
		public string CustomerLocationCode_06 { get; set; }
		
		[Required]
		[StringLength(40)]
		[DataElement("722_07", typeof(VDA_AN))]
		[Pos(7)]
		public string Text1_07 { get; set; }
		
		[Required]
		[StringLength(31)]
		[DataElement("722_08", typeof(VDA_AN))]
		[Pos(8)]
		public string Text2_08 { get; set; }
		
		[Required]
		[StringLength(9)]
		[DataElement("722_09", typeof(VDA_AN))]
		[Pos(9)]
		public string TextCode_09 { get; set; }
				
		[Required]
		[StringLength(15)]
		[DataElement("722_10", typeof(VDA_AN))]
		[Pos(10)]
		public string Empty_10 { get; set; }
	}
	
	[Serializable()]
	[Segment("723", false, ' ')]
	public class S723
	{
		[Required]
		[StringLength(3)]
		[DataElement("723_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }
		
		[Required]
		[StringLength(2)]
		[DataElement("723_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }
		
		[Required]
		[StringLength(22)]
		[DataElement("723_03", typeof(VDA_AN))]
		[Pos(3)]
		public string PartNumberCustomer_03 { get; set; }
		
		[Required]
		[StringLength(9)]
		[DataElement("723_04", typeof(VDA_AN))]
		[Pos(4)]
		public string PackagingGroup_04 { get; set; }
		
		[Required]
		[StringLength(22)]
		[DataElement("723_05", typeof(VDA_AN))]
		[Pos(5)]
		public string PartNumberSupplier_05 { get; set; }
		
		[Required]
		[StringLength(13)]
		[DataElement("723_06", typeof(VDA_N0))]
		[Pos(6)]
		public string OldPackagingStockQuantity_06 { get; set; }
		
		[Required]
		[StringLength(1)]
		[DataElement("723_07", typeof(VDA_AN))]
		[Pos(7)]
		public string OldStockPrefix_07 { get; set; }
		
		[Required]
		[StringLength(6)]
		[DataElement("723_08", typeof(VDA_DT))]
		[Pos(8)]
		public string OldStockBookingDate_08 { get; set; }
		
		[Required]
		[StringLength(13)]
		[DataElement("723_09", typeof(VDA_N0))]
		[Pos(9)]
		public string NewPackagingStockQuantity_09 { get; set; }
		
		[Required]
		[StringLength(1)]
		[DataElement("723_10", typeof(VDA_AN))]
		[Pos(10)]
		public string NewStockPrefix_10 { get; set; }

		[Required]
		[StringLength(6)]
		[DataElement("723_11", typeof(VDA_DT))]
		[Pos(11)]
		public string NewStockBookingDate_11 { get; set; }

		[Required]
		[StringLength(1)]
		[DataElement("723_12", typeof(VDA_ID_723_12))]
		[Pos(12)]
		public string ProcessDataPresentFlag_12 { get; set; }

		[Required]
		[StringLength(13)]
		[DataElement("723_13", typeof(VDA_N0))]
		[Pos(13)]
		public string DebitValueQuantity_13 { get; set; }

		[Required]
		[StringLength(3)]
		[DataElement("723_14", typeof(VDA_N0))]
		[Pos(14)]
		public string DebitValueDays_14 { get; set; }

		[Required]
		[StringLength(13)]
		[DataElement("723_15", typeof(VDA_AN))]
		[Pos(15)]
		public string Empty_15 { get; set; }
	}

	[Serializable()]
	[Segment("724", false, ' ')]
	public class S724
	{
		[Required]
		[StringLength(3)]
		[DataElement("724_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }

		[Required]
		[StringLength(2)]
		[DataElement("724_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }

		[Required]
		[StringLength(2)]
		[DataElement("724_03", typeof(VDA_ID_724_03))]
		[Pos(3)]
		public string ProcessCode_03 { get; set; }

		[Required]
		[StringLength(8)]
		[DataElement("724_04", typeof(VDA_AN))]
		[Pos(4)]
		public string LabelNumber_04 { get; set; }

		[Required]
		[StringLength(3)]
		[DataElement("724_05", typeof(VDA_N0))]
		[Pos(5)]
		public string LabelItem1_05 { get; set; }

		[Required]
		[StringLength(3)]
		[DataElement("724_06", typeof(VDA_N0))]
		[Pos(6)]
		public string LabelItem2_06 { get; set; }

		[Required]
		[StringLength(6)]
		[DataElement("724_07", typeof(VDA_DT))]
		[Pos(7)]
		public string LabelDate_07 { get; set; }

		[Required]
		[StringLength(13)]
		[DataElement("724_08", typeof(VDA_N0))]
		[Pos(8)]
		public string PackagingQuantity_08 { get; set; }

		[Required]
		[StringLength(1)]
		[DataElement("724_09", typeof(VDA_AN))]
		[Pos(9)]
		public string PackagingQuantityPrefix_09 { get; set; }

		[Required]
		[StringLength(6)]
		[DataElement("724_10", typeof(VDA_DT))]
		[Pos(10)]
		public string BookingDate_10 { get; set; }

		[Required]
		[StringLength(14)]
		[DataElement("724_11", typeof(VDA_AN))]
		[Pos(11)]
		public string TransportationPartnerNumber_11 { get; set; }

		[Required]
		[StringLength(8)]
		[DataElement("724_12", typeof(VDA_AN))]
		[Pos(12)]
		public string ReferenceLabelNumber_12 { get; set; }

		[Required]
		[StringLength(3)]
		[DataElement("724_13", typeof(VDA_N0))]
		[Pos(13)]
		public string ReferenceLabelItemNo1_13 { get; set; }

		[Required]
		[StringLength(3)]
		[DataElement("724_14", typeof(VDA_N0))]
		[Pos(14)]
		public string ReferenceLabelItemNo2_14 { get; set; }

		[Required]
		[StringLength(6)]
		[DataElement("724_15", typeof(VDA_DT))]
		[Pos(15)]
		public string ReferenceLabelDate_15 { get; set; }

		[Required]
		[StringLength(13)]
		[DataElement("724_16", typeof(VDA_N0))]
		[Pos(16)]
		public string ReferenceQuantity_16 { get; set; }

		[Required]
		[StringLength(1)]
		[DataElement("724_17", typeof(VDA_AN))]
		[Pos(17)]
		public string ReferenceQuantityPrefix_17 { get; set; }

		[Required]
		[StringLength(6)]
		[DataElement("724_18", typeof(VDA_DT))]
		[Pos(18)]
		public string ReferenceBookingDate_18 { get; set; }

		[Required]
		[StringLength(6)]
		[DataElement("724_19", typeof(VDA_DT))]
		[Pos(19)]
		public string DeliveryDate_19 { get; set; }

		[Required]
		[StringLength(3)]
		[DataElement("724_20", typeof(VDA_AN))]
		[Pos(20)]
		public string CustomerPlant_20 { get; set; }

		[Required]
		[StringLength(18)]
		[DataElement("724_21", typeof(VDA_AN))]
		[Pos(21)]
		public string Empty_21 { get; set; }
	}

	[Serializable()]
	[Segment("725", false, ' ')]
	public class S725
	{
		[Required]
		[StringLength(3)]
		[DataElement("725_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }

		[Required]
		[StringLength(2)]
		[DataElement("725_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }

		[Required]
		[StringLength(40)]
		[DataElement("725_03", typeof(VDA_AN))]
		[Pos(3)]
		public string Text1_03 { get; set; }

		[Required]
		[StringLength(10)]
		[DataElement("725_04", typeof(VDA_AN))]
		[Pos(4)]
		public string Text2a_04 { get; set; }

		[Required]
		[StringLength(30)]
		[DataElement("725_05", typeof(VDA_AN))]
		[Pos(5)]
		public string Text2b_05 { get; set; }

		[Required]
		[StringLength(4)]
		[DataElement("725_06", typeof(VDA_AN))]
		[Pos(6)]
		public string Text2c_06 { get; set; }

		[Required]
		[StringLength(9)]
		[DataElement("725_07", typeof(VDA_AN))]
		[Pos(7)]
		public string Text2d_07 { get; set; }

		[Required]
		[StringLength(27)]
		[DataElement("725_08", typeof(VDA_AN))]
		[Pos(8)]
		public string Text3_08 { get; set; }

		[Required]
		[StringLength(3)]
		[DataElement("725_09", typeof(VDA_AN))]
		[Pos(9)]
		public string Empty_09 { get; set; }
	}

	[Serializable()]
	[Segment("729", false, ' ')]
	public class S729
	{
		[Required]
		[StringLength(3)]
		[DataElement("729_01", typeof(VDA_N0))]
		[Pos(1)]
		public string RecordType_01 { get; set; }

		[Required]
		[StringLength(2)]
		[DataElement("729_02", typeof(VDA_N0))]
		[Pos(2)]
		public string Version_02 { get; set; }

		[Required]
		[StringLength(7)]
		[DataElement("729_03", typeof(VDA_N0))]
		[Pos(3)]
		public string CounterSA721_03 { get; set; }

		[Required]
		[StringLength(7)]
		[DataElement("729_04", typeof(VDA_N0))]
		[Pos(4)]
		public string CounterSA722_04 { get; set; }

		[Required]
		[StringLength(7)]
		[DataElement("729_05", typeof(VDA_N0))]
		[Pos(5)]
		public string CounterSA723_05 { get; set; }

		[Required]
		[StringLength(7)]
		[DataElement("729_06", typeof(VDA_N0))]
		[Pos(6)]
		public string CounterSA724_06 { get; set; }

		[Required]
		[StringLength(7)]
		[DataElement("729_07", typeof(VDA_N0))]
		[Pos(7)]
		public string CounterSA725_07 { get; set; }

		[Required]
		[StringLength(7)]
		[DataElement("729_08", typeof(VDA_N0))]
		[Pos(8)]
		public string CounterSA729_08 { get; set; }

		[Required]
		[StringLength(81)]
		[DataElement("729_09", typeof(VDA_AN))]
		[Pos(9)]
		public string Empty_09 { get; set; }
	}
}
