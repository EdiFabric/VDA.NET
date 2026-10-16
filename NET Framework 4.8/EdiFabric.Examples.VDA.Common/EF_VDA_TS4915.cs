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
    [Message("VDA", "4915")]
    public class TS4915 : EdiMessage
    {
        [Required]
        [DataMember()]
        [Pos(1)]
        public S551 S551 { get; set; }

        [Required]
        [DataMember()]
        [Pos(2)]
        public List<TS4915_S552Loop> S552Loop { get; set; }

        [Required]
        [DataMember()]
        [Pos(3)]
        public S559 S559 { get; set; }        
    }
    
    [DataContract()]
    [Serializable()]
    [Group(typeof(S552))]
    public class TS4915_S552Loop
    {
        [Required]
        [DataMember()]
        [Pos(1)]
        public S552 S552 { get; set; }

        [Required]
        [ListCount(3)]
        [DataMember()]
        [Pos(2)]
        public List<S553> S553 { get; set; }

        [Required]
        [DataMember()]
        [Pos(3)]
        public List<S554> S554 { get; set; }

        [DataMember()]
        [Pos(4)]
        public S555 S555 { get; set; }

        [ListCount(3)]
        [DataMember()]
        [Pos(5)]
        public List<S556> S556 { get; set; }
        
        [ListCount(3)]
        [DataMember()]
        [Pos(6)]
        public List<S557> S557 { get; set; }       
    }

    [DataContract()]
    [Serializable()]
    [Segment("551", false, ' ')]
    public class S551
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("551_01", typeof(VDA_ID_551_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("551_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("551_03", typeof(VDA_AN))]
        [DataMember()]
        [Pos(3)]
        public string CustomerCode_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("551_04", typeof(VDA_AN))]
        [DataMember()]
        [Pos(4)]
        public string SupplierCode_04 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("551_05", typeof(VDA_N0))]
        [DataMember()]
        [Pos(5)]
        public string TransmissionNumberOld_05 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("551_06", typeof(VDA_N0))]
        [DataMember()]
        [Pos(6)]
        public string TransmissionNumberNew_06 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("551_07", typeof(VDA_DT))]
        [DataMember()]
        [Pos(7)]
        public string TransmissionDate_07 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("551_08", typeof(VDA_DT))]
        [DataMember()]
        [Pos(8)]
        public string StartingDate_08 { get; set; }

        [Required]
        [StringLength(83, 83)]
        [DataElement("551_09", typeof(VDA_AN))]
        [DataMember()]
        [Pos(9)]
        public string Blanks_09 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("552", false, ' ')]
    public class S552
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("552_01", typeof(VDA_ID_552_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("552_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("552_03", typeof(VDA_AN))]
        [DataMember()]
        [Pos(3)]
        public string CustomerPlantCode_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("552_04", typeof(VDA_N0))]
        [DataMember()]
        [Pos(4)]
        public string ReleaseNumber_04 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("552_05", typeof(VDA_DT))]
        [DataMember()]
        [Pos(5)]
        public string ReleaseDate_05 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("552_06", typeof(VDA_AN))]
        [DataMember()]
        [Pos(6)]
        public string CustomerPartNumber_06 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("552_07", typeof(VDA_AN))]
        [DataMember()]
        [Pos(7)]
        public string SupplierPartNumber_07 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("552_08", typeof(VDA_AN))]
        [DataMember()]
        [Pos(8)]
        public string ReceivingLocation_08 { get; set; }

        [StringLength(7, 7)]
        [DataElement("552_09", typeof(VDA_AN))]
        [DataMember()]
        [Pos(9)]
        public string CustomerStorageLocation_09 { get; set; }

        [StringLength(1, 1)]
        [DataElement("552_10", typeof(VDA_AN))]
        [DataMember()]
        [Pos(10)]
        public string CriticalPartIndicator_10 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("552_11", typeof(VDA_AN))]
        [DataMember()]
        [Pos(11)]
        public string RequirementIndicator_11 { get; set; }

        [StringLength(6, 6)]
        [DataElement("552_12", typeof(VDA_N0))]
        [DataMember()]
        [Pos(12)]
        public string DCIHorizon_12 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("552_13", typeof(VDA_AN))]
        [DataMember()]
        [Pos(13)]
        public string ReceivingShippingIndicator_13 { get; set; }

        [StringLength(12, 12)]
        [DataElement("552_14", typeof(VDA_AN))]
        [DataMember()]
        [Pos(14)]
        public string OrderNumberFinisCode_14 { get; set; }

        [StringLength(10, 10)]
        [DataElement("552_15", typeof(VDA_N0))]
        [DataMember()]
        [Pos(15)]
        public string OrderDelivery_15 { get; set; }

        [StringLength(14, 14)]
        [DataElement("552_16", typeof(VDA_AN))]
        [DataMember()]
        [Pos(16)]
        public string UsageLocationCode_16 { get; set; }

        [Required]
        [StringLength(4, 4)]
        [DataElement("552_17", typeof(VDA_AN))]
        [DataMember()]
        [Pos(17)]
        public string Blanks_17 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("553", false, ' ')]
    public class S553
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("553_01", typeof(VDA_ID_553_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("553_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("553_03", typeof(VDA_N0))]
        [DataMember()]
        [Pos(3)]
        public string CumulativeQuantity_03 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("553_04", typeof(VDA_DT))]
        [DataMember()]
        [Pos(4)]
        public string ReceivingDate1_04 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("553_05", typeof(VDA_N0))]
        [DataMember()]
        [Pos(5)]
        public string AdviseNoteNumber1_05 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("553_06", typeof(VDA_DT))]
        [DataMember()]
        [Pos(6)]
        public string AdviseNoteDate1_06 { get; set; }

        [Required]
        [StringLength(12, 12)]
        [DataElement("553_07", typeof(VDA_N0))]
        [DataMember()]
        [Pos(7)]
        public string DeliveredQuantity1_07 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("553_08", typeof(VDA_AN))]
        [DataMember()]
        [Pos(8)]
        public string DeliveryStatusIndicator1_08 { get; set; }

        [StringLength(6, 6)]
        [DataElement("553_09", typeof(VDA_DT))]
        [DataMember()]
        [Pos(9)]
        public string ReceivingDate2_09 { get; set; }

        [StringLength(8, 8)]
        [DataElement("553_10", typeof(VDA_N0))]
        [DataMember()]
        [Pos(10)]
        public string AdviseNoteNumber2_10 { get; set; }

        [StringLength(6, 6)]
        [DataElement("553_11", typeof(VDA_DT))]
        [DataMember()]
        [Pos(11)]
        public string AdviseNoteDate2_11 { get; set; }

        [StringLength(12, 12)]
        [DataElement("553_12", typeof(VDA_N0))]
        [DataMember()]
        [Pos(12)]
        public string DeliveredQuantity2_12 { get; set; }

        [StringLength(1, 1)]
        [DataElement("553_13", typeof(VDA_AN))]
        [DataMember()]
        [Pos(13)]
        public string DeliveryStatusIndicator2_13 { get; set; }

        [StringLength(6, 6)]
        [DataElement("553_14", typeof(VDA_DT))]
        [DataMember()]
        [Pos(14)]
        public string ReceivingDate3_14 { get; set; }

        [StringLength(8, 8)]
        [DataElement("553_15", typeof(VDA_N0))]
        [DataMember()]
        [Pos(15)]
        public string AdviseNoteNumber3_15 { get; set; }

        [StringLength(6, 6)]
        [DataElement("553_16", typeof(VDA_DT))]
        [DataMember()]
        [Pos(16)]
        public string AdviseNoteDate3_16 { get; set; }

        [StringLength(12, 12)]
        [DataElement("553_17", typeof(VDA_N0))]
        [DataMember()]
        [Pos(17)]
        public string DeliveredQuantity3_17 { get; set; }

        [StringLength(1, 1)]
        [DataElement("553_18", typeof(VDA_AN))]
        [DataMember()]
        [Pos(18)]
        public string DeliveryStatusIndicator3_18 { get; set; }

        [Required]
        [StringLength(14, 14)]
        [DataElement("553_19", typeof(VDA_AN))]
        [DataMember()]
        [Pos(19)]
        public string Blanks_19 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("554", false, ' ')]
    public class S554
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("554_01", typeof(VDA_ID_554_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("554_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("554_03", typeof(VDA_DT))]
        [DataMember()]
        [Pos(3)]
        public string CallInDate1_03 { get; set; }

        [StringLength(4, 4)]
        [DataElement("554_04", typeof(VDA_TM))]
        [DataMember()]
        [Pos(4)]
        public string CallInTime1_04 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("554_05", typeof(VDA_N0))]
        [DataMember()]
        [Pos(5)]
        public string CallInQuantity1_05 { get; set; }

        [StringLength(1, 1)]
        [DataElement("554_06", typeof(VDA_AN))]
        [DataMember()]
        [Pos(6)]
        public string CallInIndicator1_06 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("554_07", typeof(VDA_DT))]
        [DataMember()]
        [Pos(7)]
        public string CallInDate2_07 { get; set; }

        [StringLength(4, 4)]
        [DataElement("554_08", typeof(VDA_TM))]
        [DataMember()]
        [Pos(8)]
        public string CallInTime2_08 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("554_09", typeof(VDA_N0))]
        [DataMember()]
        [Pos(9)]
        public string CallInQuantity2_09 { get; set; }

        [StringLength(1, 1)]
        [DataElement("554_10", typeof(VDA_AN))]
        [DataMember()]
        [Pos(10)]
        public string CallInIndicator2_10 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("554_11", typeof(VDA_DT))]
        [DataMember()]
        [Pos(11)]
        public string CallInDate3_11 { get; set; }

        [StringLength(4, 4)]
        [DataElement("554_12", typeof(VDA_TM))]
        [DataMember()]
        [Pos(12)]
        public string CallInTime3_12 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("554_13", typeof(VDA_N0))]
        [DataMember()]
        [Pos(13)]
        public string CallInQuantity3_13 { get; set; }

        [StringLength(1, 1)]
        [DataElement("554_14", typeof(VDA_AN))]
        [DataMember()]
        [Pos(14)]
        public string CallInIndicator3_14 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("554_15", typeof(VDA_DT))]
        [DataMember()]
        [Pos(15)]
        public string CallInDate4_15 { get; set; }

        [StringLength(4, 4)]
        [DataElement("554_16", typeof(VDA_TM))]
        [DataMember()]
        [Pos(16)]
        public string CallInTime4_16 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("554_17", typeof(VDA_N0))]
        [DataMember()]
        [Pos(17)]
        public string CallInQuantity4_17 { get; set; }

        [StringLength(1, 1)]
        [DataElement("554_18", typeof(VDA_AN))]
        [DataMember()]
        [Pos(18)]
        public string CallInIndicator4_18 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("554_19", typeof(VDA_DT))]
        [DataMember()]
        [Pos(19)]
        public string CallInDate5_19 { get; set; }

        [StringLength(4, 4)]
        [DataElement("554_20", typeof(VDA_TM))]
        [DataMember()]
        [Pos(20)]
        public string CallInTime5_20 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("554_21", typeof(VDA_N0))]
        [DataMember()]
        [Pos(21)]
        public string CallInQuantity5_21 { get; set; }

        [StringLength(1, 1)]
        [DataElement("554_22", typeof(VDA_AN))]
        [DataMember()]
        [Pos(22)]
        public string CallInIndicator5_22 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("554_23", typeof(VDA_DT))]
        [DataMember()]
        [Pos(23)]
        public string CallInDate6_23 { get; set; }

        [StringLength(4, 4)]
        [DataElement("554_24", typeof(VDA_TM))]
        [DataMember()]
        [Pos(24)]
        public string CallInTime6_24 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("554_25", typeof(VDA_N0))]
        [DataMember()]
        [Pos(25)]
        public string CallInQuantity6_25 { get; set; }

        [StringLength(1, 1)]
        [DataElement("554_26", typeof(VDA_AN))]
        [DataMember()]
        [Pos(26)]
        public string CallInIndicator6_26 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("554_27", typeof(VDA_AN))]
        [DataMember()]
        [Pos(27)]
        public string Blanks_27 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("555", false, ' ')]
    public class S555
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("555_01", typeof(VDA_ID_555_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("555_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [StringLength(9, 9)]
        [DataElement("555_03", typeof(VDA_AN))]
        [DataMember()]
        [Pos(3)]
        public string BetweenSupplier_03 { get; set; }

        [StringLength(22, 22)]
        [DataElement("555_04", typeof(VDA_AN))]
        [DataMember()]
        [Pos(4)]
        public string AdditionalItemNumber_04 { get; set; }

        [StringLength(10, 10)]
        [DataElement("555_05", typeof(VDA_N0))]
        [DataMember()]
        [Pos(5)]
        public string Progress_05 { get; set; }

        [Required]
        [StringLength(82, 82)]
        [DataElement("555_06", typeof(VDA_AN))]
        [DataMember()]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("556", false, ' ')]
    public class S556
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("556_01", typeof(VDA_ID_556_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("556_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("556_03", typeof(VDA_AN))]
        [DataMember()]
        [Pos(3)]
        public string PackagingCodeCustomer_03 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("556_04", typeof(VDA_AN))]
        [DataMember()]
        [Pos(4)]
        public string PackagingCodeSupplier_04 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("556_05", typeof(VDA_N0))]
        [DataMember()]
        [Pos(5)]
        public string NumberOfPartsPerPallet_05 { get; set; }

        [Required]
        [StringLength(72, 72)]
        [DataElement("556_06", typeof(VDA_AN))]
        [DataMember()]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("557", false, ' ')]
    public class S557
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("557_01", typeof(VDA_ID_557_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("557_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(40, 40)]
        [DataElement("557_03", typeof(VDA_AN))]
        [DataMember()]
        [Pos(3)]
        public string Text1_03 { get; set; }

        [StringLength(40, 40)]
        [DataElement("557_04", typeof(VDA_AN))]
        [DataMember()]
        [Pos(4)]
        public string Text2_04 { get; set; }

        [StringLength(40, 40)]
        [DataElement("557_05", typeof(VDA_AN))]
        [DataMember()]
        [Pos(5)]
        public string Text3_05 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("557_06", typeof(VDA_AN))]
        [DataMember()]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("559", false, ' ')]
    public class S559
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("559_01", typeof(VDA_ID_559_01))]
        [DataMember()]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("559_02", typeof(VDA_ID_V1))]
        [DataMember()]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_03", typeof(VDA_N0))]
        [DataMember()]
        [Pos(3)]
        public string CounterRecordType551_03 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_04", typeof(VDA_N0))]
        [DataMember()]
        [Pos(4)]
        public string CounterRecordType552_04 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_05", typeof(VDA_N0))]
        [DataMember()]
        [Pos(5)]
        public string CounterRecordType553_05 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_06", typeof(VDA_N0))]
        [DataMember()]
        [Pos(6)]
        public string CounterRecordType554_06 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_07", typeof(VDA_N0))]
        [DataMember()]
        [Pos(7)]
        public string CounterRecordType556_07 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_08", typeof(VDA_N0))]
        [DataMember()]
        [Pos(8)]
        public string CounterRecordType557_08 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_09", typeof(VDA_N0))]
        [DataMember()]
        [Pos(9)]
        public string CounterRecordType559_09 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("559_10", typeof(VDA_N0))]
        [DataMember()]
        [Pos(10)]
        public string CounterRecordType555_10 { get; set; }

        [Required]
        [StringLength(67, 67)]
        [DataElement("559_11", typeof(VDA_AN))]
        [DataMember()]
        [Pos(11)]
        public string Blanks_11 { get; set; }
    }
}
