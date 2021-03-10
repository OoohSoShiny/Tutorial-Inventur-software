﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inventory_manager
{
    public class Variables
    {

        //Connection string for MySQL Database "inventur"
        private string connection_String = "datasource=127.0.0.1;port=3306;username=root;password=;database=inventur;";
        public string Connection_String
        { get {return connection_String;} }

        //MAIN WINDOW SIZE 295; 130
        private int mainWindowWidth = 295; private int mainWindowHeight = 130;
        public int MainWindow_Width
        { get { return mainWindowWidth; } }
        public int MainWindow_Height
        { get { return mainWindowHeight; } }

        //Window size with datagrid 535;385
        private int mainWindowDataGridWidth = 540; private int mainWindowDataGridHeight = 385;
        public int Window_DataGrid_Width
        { get { return mainWindowDataGridWidth; } }
        public int Window_DataGrid_Height
        { get { return mainWindowDataGridHeight; } }

        //Window size in the "Current Inventory => Add Ware" Tab
        private int addWareWindowSizeWidth = 205; private int addWareWindowSizeHeight = 275;
        public int AddWares_WindowWidth
        { get { return addWareWindowSizeWidth; } }
        public int AddWares_WindowHeight
        { get { return addWareWindowSizeHeight; } }




        //Place of the buttons in the MAIN WINDOW
        private Point newInventoryBtnPlace = new Point(13,13);
        private Point shipmentIncBtnPlace = new Point(145, 12);
        private Point currentInventoryBtnPlace = new Point(13, 53);
        private Point shipmentOutBtnPlace = new Point(145, 53);

        public Point NewInvetory_BtnPlace
        { get { return newInventoryBtnPlace; } }
        public Point ShipmentInc_BtnPlace
        { get { return shipmentIncBtnPlace; } }
        public Point CurrentInventory_BtnPlace
        { get { return currentInventoryBtnPlace; } }
        public Point ShipmentOut_BtnPlace
        { get { return shipmentOutBtnPlace; } }


        //Size and Place of the DataGrid in the CURRENT INVENTORY
        private int datagridWidth = 500; private int datagridHeight = 230;
        public int DataGrid_Width
        { get { return datagridWidth; } }
        public int DataGrid_Height
        { get { return datagridHeight; } }

        private Point dataGridPoint = new Point(7,104);

        public Point DataGrid_Point
        { get { return dataGridPoint; } }

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

        //Strings for Adding new wares into the database
        private string userInputName = "";
        private string userInputPrice = "";
        private string userInputCount = "";
        private string userInputUnit = "";

        private float userInputPriceParsed;

        public float UserInput_PriceParsed
        { get { return userInputPriceParsed; } set { userInputPriceParsed = value; } }
        public string UserInput_WaresName
        { get { return userInputName; } set { userInputName = value; } }
        public string UserInput_WaresPrice
        { get { return userInputPrice; } set { userInputPrice = value; } }
        public string UserInput_WaresCount
        { get { return userInputCount; } set { userInputCount = value; } }
        public string UserInput_WaresUnit
        { get { return userInputUnit; } set { userInputUnit = value; } }

    }
}