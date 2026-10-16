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
    [Message("VDA", "4913")]
    public class TS4913 : EdiMessage
    {
        [Required]
        [Pos(1)]
        public S711 S711 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4913_S712Loop> S712Loop { get; set; }

        [Required]
        [Pos(3)]
        public S719 S719 { get; set; }        
    }
    
    [DataContract()]
    [Serializable()]
    [Group(typeof(S712))]
    public class TS4913_S712Loop
    {
        
        [Required]
        [Pos(1)]
        public S712 S712 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4913_S713Loop> S713 { get; set; }       
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(S713))]
    public class TS4913_S713Loop
    {

        [Required]
        [Pos(1)]
        public S713 S713 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4913_S714Loop> S714 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Group(typeof(S714))]
    public class TS4913_S714Loop
    {

        [Required]
        [Pos(1)]
        public S714 S714 { get; set; }

        [Pos(2)]
        public List<S718> S718 { get; set; }

        [Pos(3)]
        public S716 S716 { get; set; }

        [Pos(4)]
        public List<S715> S715 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("711", false, ' ')]
    public class S711
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("711_01", typeof(VDA_ID_711_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("711_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("711_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomerCode_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("711_04", typeof(VDA_AN))]
        [Pos(4)]
        public string SupplierCode_04 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("711_05", typeof(VDA_N0))]
        [Pos(5)]
        public string TransmissionNumberOld_05 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("711_06", typeof(VDA_N0))]
        [Pos(6)]
        public string TransmissionNumberNew_06 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("711_07", typeof(VDA_DT))]
        [Pos(7)]
        public string TransmissionDate_07 { get; set; }

        [StringLength(9, 9)]
        [DataElement("711_08", typeof(VDA_AN))]
        [Pos(8)]
        public string SubsupplierNumber_08 { get; set; }

        [StringLength(9, 9)]
        [DataElement("711_09", typeof(VDA_AN))]
        [Pos(9)]
        public string CarrierId_09 { get; set; }

        [StringLength(1, 1)]
        [DataElement("711_10", typeof(VDA_AN))]
        [Pos(10)]
        public string KeyToStockList_10 { get; set; }

        [StringLength(1, 1)]
        [DataElement("711_11", typeof(VDA_AN))]
        [Pos(11)]
        public string DeliveryCode_11 { get; set; }

        [Required]
        [StringLength(69, 69)]
        [DataElement("711_12", typeof(VDA_AN))]
        [Pos(12)]
        public string Blanks_12 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("712", false, ' ')]
    public class S712
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("712_01", typeof(VDA_ID_712_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("712_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("712_03", typeof(VDA_AN))]
        [Pos(3)]
        public string ShipmentLoadReferenceNumber_03 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("712_04", typeof(VDA_AN))]
        [Pos(4)]
        public string PlantSupplier_04 { get; set; }

        [Required]
        [StringLength(14, 14)]
        [DataElement("712_05", typeof(VDA_AN))]
        [Pos(5)]
        public string Carrier_05 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("712_06", typeof(VDA_DT))]
        [Pos(6)]
        public string CarrierTransferDate_06 { get; set; }

        [StringLength(4, 4)]
        [DataElement("712_07", typeof(VDA_TM))]
        [Pos(7)]
        public string CarrierTransferTime_07 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("712_08", typeof(VDA_N0))]
        [Pos(8)]
        public string GrossShipmentWeight_08 { get; set; }

        [StringLength(7, 7)]
        [DataElement("712_09", typeof(VDA_N0))]
        [Pos(9)]
        public string NetShipmentWeight_09 { get; set; }

        [StringLength(2, 2)]
        [DataElement("712_10", typeof(VDA_ID_712_10))]
        [Pos(10)]
        public string PrepaymentOfChargesKey_10 { get; set; }

        [StringLength(1, 1)]
        [DataElement("712_11", typeof(VDA_AN))]
        [Pos(11)]
        public string CarrierTransmissionKey_11 { get; set; }

        [StringLength(4, 4)]
        [DataElement("712_12", typeof(VDA_N0))]
        [Pos(12)]
        public string NumberOfPackages_12 { get; set; }

        [StringLength(14, 14)]
        [DataElement("712_13", typeof(VDA_AN))]
        [Pos(13)]
        public string TransportPartnerID_13 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("712_14", typeof(VDA_ID_712_10))]
        [Pos(14)]
        public string KeyToMeansOfTransport_14 { get; set; }

        [Required]
        [StringLength(25, 25)]
        [DataElement("712_15", typeof(VDA_AN))]
        [Pos(15)]
        public string MeansOfTransportNumber_15 { get; set; }

        [StringLength(1, 1)]
        [DataElement("712_16", typeof(VDA_ID_712_16))]
        [Pos(16)]
        public string CodeForItem712_16 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("712_17", typeof(VDA_AN))]
        [Pos(17)]
        public string ContentInAaccordanceWithItemIn712_17 { get; set; }

        [StringLength(6, 6)]
        [DataElement("712_18", typeof(VDA_DT))]
        [Pos(18)]
        public string TargetArrivalDate_18 { get; set; }

        [StringLength(4, 4)]
        [DataElement("712_19", typeof(VDA_TM))]
        [Pos(19)]
        public string TargetArrivalTime_19 { get; set; }

        [StringLength(3, 3)]
        [DataElement("712_20", typeof(VDA_N0))]
        [Pos(20)]
        public string LoadMetre_20 { get; set; }

        [StringLength(1, 1)]
        [DataElement("712_21", typeof(VDA_TM))]
        [Pos(21)]
        public string LorryTypeCode_21 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("712_22", typeof(VDA_AN))]
        [Pos(22)]
        public string Blanks_22 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("713", false, ' ')]
    public class S713
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("713_01", typeof(VDA_ID_713_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("713_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("713_03", typeof(VDA_N0))]
        [Pos(3)]
        public string DeliveryNoteNumber_03 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("713_04", typeof(VDA_DT))]
        [Pos(4)]
        public string DespatchDate_04 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("713_05", typeof(VDA_AN))]
        [Pos(5)]
        public string UnloadingPoint_05 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("713_06", typeof(VDA_ID_713_06))]
        [Pos(6)]
        public string DispatchType_06 { get; set; }

        [StringLength(4, 4)]
        [DataElement("713_07", typeof(VDA_AN))]
        [Pos(7)]
        public string CustomerReferenceNumber_07 { get; set; }

        [StringLength(12, 12)]
        [DataElement("713_08", typeof(VDA_AN))]
        [Pos(8)]
        public string ContactOrderNumber_08 { get; set; }

        [StringLength(2, 2)]
        [DataElement("713_09", typeof(VDA_ID_713_09))]
        [Pos(9)]
        public string ProcessCode_09 { get; set; }

        [StringLength(4, 4)]
        [DataElement("713_10", typeof(VDA_AN))]
        [Pos(10)]
        public string Empty_10 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("713_11", typeof(VDA_AN))]
        [Pos(11)]
        public string CustomerPlant_11 { get; set; }

        [StringLength(8, 8)]
        [DataElement("713_12", typeof(VDA_N0))]
        [Pos(12)]
        public string Consigment_12 { get; set; }

        [StringLength(9, 9)]
        [DataElement("713_13", typeof(VDA_AN))]
        [Pos(13)]
        public string GoodsReceiverID_13 { get; set; }

        [StringLength(1, 1)]
        [DataElement("713_14", typeof(VDA_AN))]
        [Pos(14)]
        public string Empty2_14 { get; set; }

        [StringLength(7, 7)]
        [DataElement("713_15", typeof(VDA_AN))]
        [Pos(15)]
        public string ShipToCustomreStorageLocation_15 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("713_16", typeof(VDA_AN))]
        [Pos(16)]
        public string SupplierID_16 { get; set; }

        [StringLength(14, 14)]
        [DataElement("713_17", typeof(VDA_AN))]
        [Pos(17)]
        public string PointOfAssembling_17 { get; set; }

        [StringLength(4, 4)]
        [DataElement("713_18", typeof(VDA_AN))]
        [Pos(18)]
        public string ReleaseNumber_18 { get; set; }

        [StringLength(6, 6)]
        [DataElement("713_19", typeof(VDA_AN))]
        [Pos(19)]
        public string CustomerReference_19 { get; set; }

        [StringLength(14, 14)]
        [DataElement("713_20", typeof(VDA_AN))]
        [Pos(20)]
        public string CustomerReferenceNumber_20 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("713_21", typeof(VDA_AN))]
        [Pos(21)]
        public string Blanks_21 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("714", false, ' ')]
    public class S714
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("714_01", typeof(VDA_ID_714_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("714_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("714_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomReferenceNumber_03 { get; set; }

        [StringLength(22, 22)]
        [DataElement("714_04", typeof(VDA_AN))]
        [Pos(4)]
        public string SupplierReferenceNumber_04 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("714_05", typeof(VDA_N0))]
        [Pos(5)]
        public string CountryOfOrigin_05 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("714_06", typeof(VDA_N3))]
        [Pos(6)]
        public string DeliveryQuantity1_06 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("714_07", typeof(VDA_ID_714_07))]
        [Pos(7)]
        public string UnitOfQuantity1_07 { get; set; }

        [StringLength(13, 13)]
        [DataElement("714_08", typeof(VDA_N3))]
        [Pos(8)]
        public string DeliveryQuantity2_08 { get; set; }

        [StringLength(2, 2)]
        [DataElement("714_09", typeof(VDA_ID_714_09))]
        [Pos(9)]
        public string UnitOfQuantity2_09 { get; set; }

        [StringLength(3, 3)]
        [DataElement("714_10", typeof(VDA_N0))]
        [Pos(10)]
        public string VatRate_10 { get; set; }

        [StringLength(1, 1)]
        [DataElement("714_11", typeof(VDA_AN))]
        [Pos(11)]
        public string Empty_11 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("714_12", typeof(VDA_N0))]
        [Pos(12)]
        public string DeliveryNoteItemNumber_12 { get; set; }

        [StringLength(1, 1)]
        [DataElement("714_13", typeof(VDA_AN))]
        [Pos(13)]
        public string ReleaseKey_13 { get; set; }

        [StringLength(15, 15)]
        [DataElement("714_14", typeof(VDA_AN))]
        [Pos(14)]
        public string BatchNumber_14 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("714_15", typeof(VDA_AN))]
        [Pos(15)]
        public string CodeUsage_15 { get; set; }

        [StringLength(8, 8)]
        [DataElement("714_16", typeof(VDA_AN))]
        [Pos(16)]
        public string DangerousGoodsCode_16 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("714_17", typeof(VDA_ID_714_17))]
        [Pos(17)]
        public string PreferenceStatus_17 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("714_18", typeof(VDA_AN))]
        [Pos(18)]
        public string DutiableGoods_18 { get; set; }

        [StringLength(1, 1)]
        [DataElement("714_19", typeof(VDA_AN))]
        [Pos(19)]
        public string Empty2_19 { get; set; }

        [StringLength(1, 1)]
        [DataElement("714_20", typeof(VDA_AN))]
        [Pos(20)]
        public string InventoryStatus_20 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("714_21", typeof(VDA_AN))]
        [Pos(21)]
        public string ModifiedVersionCode_21 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("714_22", typeof(VDA_AN))]
        [Pos(22)]
        public string OriginalDeliveryNoteNumber_22 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("715", false, ' ')]
    public class S715
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("715_01", typeof(VDA_ID_715_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("715_02", typeof(VDA_ID_V3))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("715_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomerPackagingTypeCoded_03 { get; set; }

        [StringLength(22, 22)]
        [DataElement("715_04", typeof(VDA_AN))]
        [Pos(4)]
        public string SupplierPackagingTypeCoded_04 { get; set; }

        [Required]
        [StringLength(13, 13)]
        [DataElement("715_05", typeof(VDA_N0))]
        [Pos(5)]
        public string NumberOfPackaging_05 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("715_06", typeof(VDA_N0))]
        [Pos(6)]
        public string DeliveryNoteItemNumber_06 { get; set; }

        [StringLength(13, 13)]
        [DataElement("715_07", typeof(VDA_N3))]
        [Pos(7)]
        public string MaximumQuantity_07 { get; set; }

        [StringLength(9, 9)]
        [DataElement("715_08", typeof(VDA_AN))]
        [Pos(8)]
        public string PackageNumberFrom_08 { get; set; }

        [StringLength(9, 9)]
        [DataElement("715_09", typeof(VDA_AN))]
        [Pos(9)]
        public string PackageNumberTo_09 { get; set; }

        [StringLength(12, 12)]
        [DataElement("715_10", typeof(VDA_N0))]
        [Pos(10)]
        public string PackagingDimensions_10 { get; set; }

        [StringLength(1, 1)]
        [DataElement("715_11", typeof(VDA_N0))]
        [Pos(11)]
        public string StackingFactor_11 { get; set; }

        [StringLength(15, 15)]
        [DataElement("715_12", typeof(VDA_AN))]
        [Pos(12)]
        public string WarehouseReleaseNumber_12 { get; set; }

        [StringLength(1, 1)]
        [DataElement("715_13", typeof(VDA_ID_715_13))]
        [Pos(13)]
        public string LabelIndicator_13 { get; set; }
        
        [StringLength(1, 1)]
        [DataElement("715_14", typeof(VDA_AN))]
        [Pos(14)]
        public string PackagingCode_14 { get; set; }

        [StringLength(1, 1)]
        [DataElement("715_15", typeof(VDA_AN))]
        [Pos(15)]
        public string PropertyCode_15 { get; set; }

        [StringLength(1, 1)]
        [DataElement("715_16", typeof(VDA_AN))]
        [Pos(16)]
        public string Blanks_16 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("716", false, ' ')]
    public class S716
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("716_01", typeof(VDA_ID_716_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("716_02", typeof(VDA_ID_V2))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(40, 40)]
        [DataElement("716_03", typeof(VDA_AN))]
        [Pos(3)]
        public string Text1_03 { get; set; }

        [StringLength(40, 40)]
        [DataElement("716_04", typeof(VDA_AN))]
        [Pos(4)]
        public string Text2_04 { get; set; }

        [Required]
        [StringLength(40, 40)]
        [DataElement("716_05", typeof(VDA_AN))]
        [Pos(5)]
        public string Text3_05 { get; set; }

        [StringLength(3, 3)]
        [DataElement("716_06", typeof(VDA_AN))]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("718", false, ' ')]
    public class S718
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("718_01", typeof(VDA_ID_718_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("718_02", typeof(VDA_ID_V2))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("718_03", typeof(VDA_N0))]
        [Pos(3)]
        public string DeliveryNoteNumber_03 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_04", typeof(VDA_AN))]
        [Pos(4)]
        public string ManufacturingReferenceNumber1_04 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_05", typeof(VDA_AN))]
        [Pos(5)]
        public string ManufacturingReferenceNumber2_05 { get; set; }
        
        [Required]
        [StringLength(10, 10)]
        [DataElement("718_06", typeof(VDA_AN))]
        [Pos(6)]
        public string ManufacturingReferenceNumber3_06 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_07", typeof(VDA_AN))]
        [Pos(7)]
        public string ManufacturingReferenceNumber4_07 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_08", typeof(VDA_AN))]
        [Pos(8)]
        public string ManufacturingReferenceNumber5_08 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_09", typeof(VDA_AN))]
        [Pos(9)]
        public string ManufacturingReferenceNumber6_09 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_10", typeof(VDA_AN))]
        [Pos(10)]
        public string ManufacturingReferenceNumber7_10 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_11", typeof(VDA_AN))]
        [Pos(11)]
        public string ManufacturingReferenceNumber8_11 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_12", typeof(VDA_AN))]
        [Pos(12)]
        public string ManufacturingReferenceNumber9_12 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_13", typeof(VDA_AN))]
        [Pos(13)]
        public string ManufacturingReferenceNumber10_13 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("718_14", typeof(VDA_AN))]
        [Pos(14)]
        public string ManufacturingReferenceNumber11_14 { get; set; }

        [StringLength(5, 5)]
        [DataElement("718_15", typeof(VDA_AN))]
        [Pos(15)]
        public string Blanks_15 { get; set; }
    }

    [DataContract()]
    [Serializable()]
    [Segment("719", false, ' ')]
    public class S719
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("719_01", typeof(VDA_ID_719_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("719_02", typeof(VDA_ID_V2))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_03", typeof(VDA_N0))]
        [Pos(3)]
        public string CounterRecordType711_03 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_04", typeof(VDA_N0))]
        [Pos(4)]
        public string CounterRecordType712_04 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_05", typeof(VDA_N0))]
        [Pos(5)]
        public string CounterRecordType713_05 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_06", typeof(VDA_N0))]
        [Pos(6)]
        public string CounterRecordType714_06 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_07", typeof(VDA_N0))]
        [Pos(7)]
        public string CounterRecordType715_07 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_08", typeof(VDA_N0))]
        [Pos(8)]
        public string CounterRecordType716_08 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_09", typeof(VDA_N0))]
        [Pos(9)]
        public string CounterRecordType718_09 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_10", typeof(VDA_N0))]
        [Pos(10)]
        public string CounterRecordType719_10 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("719_11", typeof(VDA_N0))]
        [Pos(11)]
        public string CounterRecordType717_11 { get; set; }

        [Required]
        [StringLength(60, 60)]
        [DataElement("719_12", typeof(VDA_AN))]
        [Pos(12)]
        public string Blanks_12 { get; set; }
    }
}
