using EdiFabric.Templates.Vda;
using System.Collections.Generic;

namespace EdiFabric.Examples.VDA.Common
{
    public class TS4905Builder
    {
        /// <summary>
        /// Build delivery instruction.
        /// </summary>
        public static TS4905 BuildDeliveryInstruction(int oldNumber, int newNumber)
        {
            var result = new TS4905();

            //  Header record delivery instruction 
            result.S511 = new S511();
            result.S511.RecordType_01 = "511";
            result.S511.Version_02 = "02";
            result.S511.CustomerCode_03 = "59012";
            result.S511.SupplierCode_04 = "00323625";
            result.S511.TransmissionNumberOld_05 = oldNumber.ToString();
            result.S511.TransmissionNumberNew_06 = newNumber.ToString();
            result.S511.TransmissionDate_07 = "121115";
            result.S511.StartingDate_08 = "111231";

            //  Repeating 512 Groups
            result.S512Loop = new List<TS4905_S512Loop>();

            //  Begin 512 Group
            var s512Loop = new TS4905_S512Loop();

            //  Unique data to the article codes
            s512Loop.S512 = new S512();
            s512Loop.S512.RecordType_01 = "512";
            s512Loop.S512.Version_02 = "01";
            s512Loop.S512.CustomerPlantCode_03 = "03";
            s512Loop.S512.DeliveryCallOffNumberNew_04 = "187";
            s512Loop.S512.DeliveryCallOffDateNew_05 = "121115";
            s512Loop.S512.DeliveryCallOffNumberOld_06 = "186";
            s512Loop.S512.DeliveryCallOffDateOld_07 = "121109";
            s512Loop.S512.ArticleCodeCustomer_08 = "1514280009100";
            s512Loop.S512.OrderNumber_10 = "CGF-56026482";
            s512Loop.S512.DockGate_11 = "A 13";
            s512Loop.S512.QuantityUnitOfMeasure_13 = "ST";
            s512Loop.S512.DeliveryFrequency_14 = "L";

            //  Reconciliation and call-off data
            s512Loop.S513 = new S513();
            s512Loop.S513.RecordType_01 = "513";
            s512Loop.S513.Version_02 = "01";
            s512Loop.S513.DateOfLastRecordedReceipt_03 = "121113";
            s512Loop.S513.LastRecordedDeliveryNoteNumber_04 = "432701";
            s512Loop.S513.QuantityLastRecordedReceipt_06 = "000000346000";
            s512Loop.S513.CommulativeFigureReceipt_07 = "0000019427";
            s512Loop.S513.CallOffDate1_08 = "121115";

            //  Complementary data delivery call 
            s512Loop.S515 = new S515();
            s512Loop.S515.RecordType_01 = "515";
            s512Loop.S515.Version_02 = "01";
            s512Loop.S515.ManufacturingReleaseFinalDate_04 = "130213";
            s512Loop.S515.MaterialReleaseFinalDate_07 = "130315";

            //  Repeating 518
            s512Loop.S518 = new List<S518>();

            //  Text data 1
            var s5181 = new S518();
            s5181.RecordType_01 = "518";
            s5181.Version_02 = "01";
            s5181.DeliveryInstructionText1_03 = "07-08140295/04";
            s5181.DeliveryInstructionText2_04 = "23-09140029";
            s512Loop.S518.Add(s5181);

            //  Text data 2
            var s5182 = new S518();
            s5182.RecordType_01 = "518";
            s5182.Version_02 = "01";
            s512Loop.S518.Add(s5182);

            //  End 512 Group
            result.S512Loop.Add(s512Loop);

            //  Trailer record delivery instruction 
            result.S519 = new S519();
            result.S519.RecordType_01 = "519";
            result.S519.Version_02 = "01";
            result.S519.CounterRecordType511_03 = "1";
            result.S519.CounterRecordType512_04 = "1";
            result.S519.CounterRecordType513_05 = "1";
            result.S519.CounterRecordType518_08 = "2";
            result.S519.CounterRecordType519_09 = "1";
            result.S519.CounterRecordType515_10 = "1";


            return result;
        }
    }
}
