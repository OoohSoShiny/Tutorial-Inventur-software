using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inventory_manager
{
    public class Variables
    {
        #region Window_Sizes_And_Basic_Variables
        //Connection string for MySQL Database "inventur"
        private readonly string connection_String = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventur;";
        public string Connection_String
        { get {return connection_String;} }

        //The string array for the old stockpile
        string[] oldStockpile = new string[] { };
        public string[] OldInventory_StringArray
        { 
            get { return oldStockpile; }
            set { oldStockpile = value; }
        }

        bool newInventory = false;

        public bool OldInventory_OldBool
        { 
            get { return newInventory; }
            set { newInventory = value; }
        }


        //The integer to walk the above stockpile array
        private int arrayWalker = 4;
        public int OldInventory_ArrayWalker
        {
            get { return arrayWalker; }
            set { arrayWalker = value; }
        }


        //MAIN WINDOW SIZE 295; 130
        private readonly int mainWindowWidth = 300; private int mainWindowHeight = 170;
        public int MainWindow_Width
        { get { return mainWindowWidth; } }
        public int MainWindow_Height
        { get { return mainWindowHeight; } }

        //Window size with datagrid 535;385
        private readonly int mainWindowDataGridWidth = 540; private readonly int mainWindowDataGridHeight = 385;
        public int Window_DataGrid_Width
        { get { return mainWindowDataGridWidth; } }
        public int Window_DataGrid_Height
        { get { return mainWindowDataGridHeight; } }

        //Window size in the "Current Inventory => Add Ware" Tab
        private readonly int addWareWindowSizeWidth = 205; private readonly int addWareWindowSizeHeight = 275;
        public int AddWares_WindowWidth
        { get { return addWareWindowSizeWidth; } }
        public int AddWares_WindowHeight
        { get { return addWareWindowSizeHeight; } }

        //Window size in the "Incoming Wares" Tab
        private readonly int waresIncWindowSizeWidth = 365; private readonly int waresIncWindowSizeHeight = 220;

        public int WaresInc_WindowWidth
        { get { return waresIncWindowSizeWidth; } }
        public int WaresInc_WindowHeight
        { get { return waresIncWindowSizeHeight; } }

        //Window size in the "New inventory" Tab
        int newInvenWindowSizeWidth = 367; int newInvenWindowSizeHeight = 310;

        //Window size in the "last inventory" Tab 257; 249
        int lastInventoryWindowSizeWidth = 260; int lastInventoryWindowSizeHeight = 250;
        
        public int LastInventory_WindowWidth
        { get { return lastInventoryWindowSizeWidth; } }
        public int LastInventory_WindowHeight
        { get { return lastInventoryWindowSizeHeight; } }

        public int NewInven_WindowWidth
        { get { return newInvenWindowSizeWidth; } }
        public int NewInven_WindowHeight
        { get { return newInvenWindowSizeHeight; } }

        //Window size in the "Counting" Tab
        int newCountWindowWidth = 357; int newCountWindowHeight = 322;
        public int NewCount_WindowWidth
        { get { return newCountWindowWidth; } }
        public int NewCount_WindowHeight
        { get { return newCountWindowHeight; } }
        #endregion

        #region IncOut_Wares
        //Places of the ComboBoxes in the "Incoming Wares" Tab
        private Point waresIncComboOne = new Point(12, 29);
        private Point waresIncComboTwo = new Point(12, 56);
        private Point waresIncComboThree = new Point(12, 83);
        private Point waresIncComboFour = new Point(12, 110);
        private Point waresIncComboFive = new Point(12, 137);

        public Point WaresInc_ComboOne
        { get { return waresIncComboOne; } }
        public Point WaresInc_ComboTwo
        { get { return waresIncComboTwo; } }
        public Point WaresInc_ComboThree
        { get { return waresIncComboThree; } }
        public Point WaresInc_ComboFour
        { get { return waresIncComboFour; } }
        public Point WaresInc_ComboFive
        { get { return waresIncComboFive; } }

        //The bool to decide if the wares are incoming/outgoing
        bool incomingwares = false;

        public bool WaresInc_IncBool
        { get { return incomingwares; } 
          set { incomingwares = value; }
        }

        //Places of the textboxes in the "Incoming Wares" Tab
        private Point waresIncTextOne = new Point(139, 29);
        private Point waresIncTextTwo = new Point(139, 56);
        private Point waresIncTextThree = new Point(139, 83);
        private Point waresIncTextFour = new Point(139, 110);
        private Point waresIncTextFive = new Point(139, 137);

        public Point WaresInc_TxtboxOne
        { get { return waresIncTextOne; } }
        public Point WaresInc_TxtboxTwo
        { get { return waresIncTextTwo; } }
        public Point WaresInc_TxtboxThree
        { get { return waresIncTextThree; } }
        public Point WaresInc_TxtboxFour
        { get { return waresIncTextFour; } }
        public Point WaresInc_TxtboxFive
        { get { return waresIncTextFive; } }

        //Places of the labels in the "Incoming Wares" Tab
        private Point waresIncLabelWare = new Point(12,9);
        private Point waresIncLabelCount = new Point(136, 9);

        public Point WaresInc_LabelWare
        { get { return waresIncLabelWare; } }
        public Point WaresInc_LabelCount
        { get { return waresIncLabelCount; } }

        //Places of the buttons in the "Incoming Wares" Tab
        private Point waresIncButtonCancel = new Point(255, 39);
        private Point waresIncButtonSend = new Point(254, 134);

        public Point WaresInc_ButtonCancel
        { get { return waresIncButtonCancel; } }
        public Point WaresInc_ButtonSend
        { get { return waresIncButtonSend; } }
        #endregion

        #region MainWindow
        //Place of the buttons in the MAIN WINDOW letzte inventur 12; 90, close 147; 90
        private Point newInventoryBtnPlace = new Point(13,13);
        private Point shipmentIncBtnPlace = new Point(145, 12);
        private Point currentInventoryBtnPlace = new Point(13, 53);
        private Point shipmentOutBtnPlace = new Point(145, 53);
        private Point lastInventoryBtnPlace = new Point(12, 90);
        private Point closeProgramButtonPlace = new Point(145, 90);

        public Point LastInventory_ButtonPlace
        { get { return lastInventoryBtnPlace; } }
        public Point CloseProgram_ButtonPlace
        { get { return closeProgramButtonPlace; } }
        public Point NewInvetory_BtnPlace
        { get { return newInventoryBtnPlace; } }
        public Point ShipmentInc_BtnPlace
        { get { return shipmentIncBtnPlace; } }
        public Point CurrentInventory_BtnPlace
        { get { return currentInventoryBtnPlace; } }
        public Point ShipmentOut_BtnPlace
        { get { return shipmentOutBtnPlace; } }
        #endregion

        #region CurrentInventory
        //Size and Place of the DataGrid in the CURRENT INVENTORY
        private int datagridWidth = 500; private int datagridHeight = 230;
        public int DataGrid_Width
        { get { return datagridWidth; } }
        public int DataGrid_Height
        { get { return datagridHeight; } }

        private Point dataGridPoint = new Point(7,104);

        public Point DataGrid_Point
        { get { return dataGridPoint; } }

        //Places of the textbox and the label
        private Point currentWaresDelLabel = new Point(254, 44);
        private Point currentWaresDelTextbox = new Point(402, 41);

        public Point CurrentWares_DelLabelPlace
        { get { return currentWaresDelLabel; } }
        public Point CurrentWares_TxtBoxPlace
        { get { return currentWaresDelTextbox; } }

        //Places of the buttons in the CURRENT INVENTORY Tab
        private Point currentInventoryBtnBack = new Point(13, 13);
        private Point currentInventoryBtnAdd = new Point(193, 13);
        private Point currentInventoryBtnDel = new Point(402, 13);
        public Point CurrentInventory_BackBtnPlace
        { get { return currentInventoryBtnBack; } }
        public Point CurrentInventory_AddBtnPlace
        { get { return currentInventoryBtnAdd; } }
        public Point CurrentInventory_DelBtnPlace
        { get { return currentInventoryBtnDel; } }
        #endregion

        #region AddingWares
        //Places of Labels in the ADD WARE Tab
        private Point addWareMainLabelPoint = new Point(13, 13);
        private Point addWareLabelNamePoint = new Point(25, 54);
        private Point addWareLabelPricePoint = new Point(30, 80);
        private Point addWareLabelCountPoint = new Point(20, 105);
        private Point addWareLabelUnitPoint = new Point(1, 131);

        //Places of textboxes in the ADD WARE Tab
        private Point addWareTxtName = new Point(66, 51);
        private Point addWareTxtPrice = new Point(66, 77);
        private Point addWareTxtCount = new Point(66, 102);
        private Point addWareTxtUnit = new Point(66, 128);

        //Place of the button in the ADD WARE Tab
        private Point addWareAddButtonPoint = new Point(16, 178);
        private Point addWareCancelButtonPoint = new Point(102, 178);

        public Point AddWareMainLabelPoint
        { get { return addWareMainLabelPoint; } }
        public Point AddWareLabelNamePoint
        { get { return addWareLabelNamePoint; } }
        public Point AddWareLabelPricePoint
        { get { return addWareLabelPricePoint; } }
        public Point AddWareLabelCountPoint
        { get { return addWareLabelCountPoint; } }
        public Point AddWareLabelUnitPoint
        { get { return addWareLabelUnitPoint; } }

        public Point AddWareTxtName
        { get { return addWareTxtName; } }
        public Point AddWareTxtPrice
        { get { return addWareTxtPrice; } }
        public Point AddWareTxtCount
        { get { return addWareTxtCount; } }
        public Point AddWareTxtUnit
        { get { return addWareTxtUnit; } }

        public Point AddWareAddButtonPoint
        { get { return addWareAddButtonPoint; } }
        public Point AddWareCancelButtonPoint
        { get { return addWareCancelButtonPoint; } }
        #endregion

        #region NewInventory
        //Places of labels in the NEW INVENTORY tab
        Point newInvenLabelReason = new Point(13, 20);
        Point newInvenLabelDate = new Point(13, 58);
        Point newInvenLabelLeader = new Point(13, 100);
        Point newInvenLabelAccount = new Point(13, 135);

        public Point NewInven_LabelReasonPlace
        { get { return newInvenLabelReason; } }
        public Point NewInven_LabelDatePlace
        { get { return newInvenLabelDate; } }
        public Point NewInven_LabelLeaderPlace
        { get { return newInvenLabelLeader; } }
        public Point NewInven_LabelAccountPlace
        { get { return newInvenLabelAccount; } }

        //place of the buttons in the NEW INVENTORY tab
        Point newInvenBtnNew = new Point(16, 174);
        Point newInvenBtnCancel = new Point(64, 236);
        public Point NewInven_ButtonNewPlace
        { get { return newInvenBtnNew; } }
        public Point NewInven_ButtonCancel
        { get { return newInvenBtnCancel; } }

        //Place of radio buttons in the NEW INVENTORY tab
        Point newInvenRadioYes = new Point(87, 133);
        Point NewInvenRadioNo = new Point(129, 133);

        public Point NewInven_RadioYesPlace
        { get { return newInvenRadioYes; } }
        public Point NewInven_RadioNoPlace
        { get { return NewInvenRadioNo; } }

        //places of the textboxes in the NEW INVENTORY tab
        Point newInventxtDate = new Point(87, 55);
        Point newInventxtLeader = new Point(87, 97);
        Point newInventxtAccount = new Point(182 , 132);

        public Point NewInven_TxtDatePlace
        { get { return newInventxtDate; } }
        public Point NewInven_TxtLeaderPlace
        { get { return newInventxtLeader; } }
        public Point NewInven_TxtAccountPlace
        { get { return newInventxtAccount; } }

        //Place of the combobox in the NEW INVENTORY tab
        Point newInvenComboReason = new Point(87, 17);
        public Point NewInven_ComboReasonPlace
        { get { return newInvenComboReason; } }
        #endregion

        #region CountingTab
        //Place of the labels in the COUNTING tab
        Point newCountWareFixed = new Point(13, 13);
        Point newCountWareCurrent = new Point(78, 13);
        Point newCountCountFixed = new Point(13, 57);
        Point newCountCountUpdating = new Point(146, 57);

        public Point NewCount_LabelWareFixedPlace
        { get { return newCountWareFixed; } }
        public Point NewCount_LabelWareCurrentPlace
        { get { return newCountWareCurrent; } }
        public Point NewCount_LabelCountFixedPlace
        { get { return newCountCountFixed; } }
        public Point NewCount_LabelCountCurrentPlace
        { get { return newCountCountUpdating; } }


        //Place of the buttons in the COUNTING tab
        Point newCountPlusOne = new Point(12, 135);
        Point newCountPlusFive = new Point(93, 135);
        Point newCountPluseTen = new Point(174, 135);
        Point newCountPlusFifty = new Point(255, 135);
        Point newCountSend = new Point(93, 248);
        Point newCountMinusOne = new Point(12, 186);
        Point newCountMinusTen = new Point(174, 186);

        public Point NewCount_PlusOnePlace
        { get { return newCountPlusOne; } }
        public Point NewCount_PluseFivePlace
        { get { return newCountPlusFive; } }
        public Point NewCount_PlusTenPlace
        { get { return newCountPluseTen; } }
        public Point NewCount_PlusFiftyPlace
        { get { return newCountPlusFifty; } }
        public Point NewCount_SendButtonPlace
        { get { return newCountSend; } }
        public Point NewCount_MinusOnePlace
        { get { return newCountMinusOne; } }
        public Point NewCount_MinusTenPlace
        { get { return newCountMinusTen; } }

        //Needed variables for the new inventory/Counting tab
        string inventurString = "";
        int inventurCounter = 0;
        int databaseCounter = 0;

        public string NewInven_DataInput
        { get { return inventurString; } set { inventurString = value; } }
        public int NewCount_Counter
        { get {return inventurCounter;} set { inventurCounter = value; } }
        public int NewCount_DatabaseWalker
        { get { return databaseCounter; } set { databaseCounter = value; } }
        #endregion

        #region LastInventory
        //labels 53; 151          // << 15; 146         // >> 197; 146
        Point reasonFixed = new Point(12, 9);
        Point reasonCurrent = new Point(87, 9);
        Point leaderFixed = new Point(12, 42);
        Point leaderCurrent = new Point(87, 42);
        Point dateFixed = new Point(12, 75);
        Point dateCurrent = new Point(87, 75);
        Point accountFixed = new Point(12, 108);
        Point accountCurrent = new Point(87, 108);
        Point currentWares = new Point(53, 151);

        //buttons
        Point lastInventoryButtonBack = new Point(15, 175);
        Point lastInventoryButtonPrevious = new Point(15, 146);
        Point lastInventoryButtonNext = new Point(197, 146);

        public Point LastInventory_ReasonFixed
        { get { return reasonFixed; } }
        public Point LastInventory_ReasonCurrent
        { get { return reasonCurrent; } }
        public Point LastInventory_LeaderFixed
        { get { return leaderFixed; } }
        public Point LastInventory_LeaderCurrent
        { get { return leaderCurrent; } }
        public Point LastInventory_DateFixed
        { get { return dateFixed; } }
        public Point LastInventory_DateCurrent
        { get { return dateCurrent; } }
        public Point LastInventory_AccountFixed
        { get { return accountFixed; } }
        public Point LastInventory_AccountCurrent
        { get { return accountCurrent; } }
        public Point LastInventory_CurrentWaresLabel
        { get { return currentWares; } }
        public Point LastInventory_ButtonBack
        { get { return lastInventoryButtonBack; } }
        public Point LastInventory_ButtonPrevious
        { get { return lastInventoryButtonPrevious; } }
        public Point LastInventory_ButtonNext
        { get { return lastInventoryButtonNext; } }

        #endregion
    }
}
