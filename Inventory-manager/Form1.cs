using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventory_manager
{
    public partial class MainFrame : Form
    {   
        //Starting initliazing of necessary classes, arrays etc.
        Variables variables;
        MySqlConnection databaseConnection;
        MySqlCommand commandDatabase;
        MySqlDataReader myReader;
        Label[] addWaresLabels;
        TextBox[] addWaresTextboxes;
        Button[] mainWindowButtons, currentInventoryButtons, addWaresButtons;
        Point[] mainWindowButtonPoints, currentInventoryPoints, addWaresLabelsPoints, addWaresTextboxPoints, addWareButtonPoints;

        public MainFrame()
        {   
            InitializeComponent();
            variables = new Variables();
            //Main Window
            mainWindowButtons = new Button[] { btnInventoryCurrent, btnNewInventory, btnShipmentInc, btnShipmentOut };
            mainWindowButtonPoints = new Point[] { variables.CurrentInventory_BtnPlace, variables.NewInvetory_BtnPlace, variables.ShipmentInc_BtnPlace, variables.ShipmentOut_BtnPlace };
            //Current Inventory Window
            currentInventoryButtons = new Button[] { btnCurrentInventoryBack, btnCurrentInventoryAdd, btnCurrentInventoryDel };
            currentInventoryPoints = new Point[] { variables.CurrentInventory_BackBtnPlace, variables.CurrentInventory_AddBtnPlace, variables.CurrentInventory_DelBtnPlace };
            //Add Wares Window
            addWaresLabels = new Label[] { lblAddWareText, lblAddWareTextName, lblAddWareTextPrice, lblAddWareTextCount, lblAddWareTextUnit };
            addWaresLabelsPoints = new Point[] { variables.AddWareMainLabelPoint, variables.AddWareLabelNamePoint, variables.AddWareLabelPricePoint, variables.AddWareLabelCountPoint, variables.AddWareLabelUnitPoint };
            addWaresTextboxPoints = new Point[] { variables.AddWareTxtName, variables.AddWareTxtPrice, variables.AddWareTxtCount, variables.AddWareTxtUnit };
            addWaresTextboxes = new TextBox[] { txtAddWareName, txtAddWarePrice, txtAddWareCount, txtAddWareUnit };
            addWaresButtons = new Button[] { btnAddWareAdd, btnAddWareCancel };
            addWareButtonPoints = new Point[] { variables.AddWareAddButtonPoint, variables.AddWareCancelButtonPoint };

            //Initial placement of buttons and size of window
            Resize_Mainframe(variables.MainWindow_Width, variables.MainWindow_Height);
            Place_New_Buttons(mainWindowButtons, mainWindowButtonPoints);
            Database_Connection_Open();
        }

        //Connecting to inventory database
        private void Database_Connection_Open()
        {
            try
            {
                databaseConnection = new MySqlConnection(variables.Connection_String);
                databaseConnection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Closing Connection to inventory database
        private void Database_Connection_Close()
        {
            try
            { databaseConnection.Close(); }
            catch(Exception e)
            { }
        }
        #region Buttons
        //Main Window buttons
        private void btnNewInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnShipmendInc_Click(object sender, EventArgs e)
        {

        }

        private void btnShipmentOut_Click(object sender, EventArgs e)
        {

        }
        //"Deletes" Mainwindow, places Current-Inventory Window
        private void btnInventoryCurrent_Click(object sender, EventArgs e)
        {
            Clear_Buttons(mainWindowButtons);
            Resize_Mainframe(variables.Window_DataGrid_Width, variables.Window_DataGrid_Height);
            Place_Datagrid(dataGridWares);
            Place_New_Buttons(currentInventoryButtons, currentInventoryPoints);
            this.Text = "Derzeitiges Inventar";

        }

        //Current Inventory buttons
        //"Zurück" goes back to main window
        private void btnCurrentInventoryBack_Click(object sender, EventArgs e)
        {
            Clear_Buttons(currentInventoryButtons);
            Resize_Mainframe(variables.MainWindow_Width, variables.MainWindow_Height);
            Remove_Datagrid(dataGridWares);
            Place_New_Buttons(mainWindowButtons, mainWindowButtonPoints);
            this.Text = "Inventur";
        }

        private void btnCurrentInventoryAdd_Click(object sender, EventArgs e)
        {
            Database_Connection_Open();
            this.Text = "Ware hinzufügen";
            Clear_Buttons(currentInventoryButtons);
            Resize_Mainframe(variables.AddWares_WindowWidth, variables.AddWares_WindowHeight);
            Place_New_Labels(addWaresLabels, addWaresLabelsPoints);
            Place_New_Textboxes(addWaresTextboxes, addWaresTextboxPoints);
            Place_New_Buttons(addWaresButtons, addWareButtonPoints);
            Remove_Datagrid(dataGridWares);

        }

        private void btnCurrentInventoryDel_Click(object sender, EventArgs e)
        {

        }

        //Add Wares Inventory buttons
        private void btnAddWareCancel_Click(object sender, EventArgs e)
        {
            Clear_Buttons(addWaresButtons);
            Clear_All_Textboxes(addWaresTextboxes);
            Clear_Labels(addWaresLabels);
            Resize_Mainframe(variables.Window_DataGrid_Width, variables.Window_DataGrid_Height);
            Place_Datagrid(dataGridWares);
            Place_New_Buttons(currentInventoryButtons, currentInventoryPoints);
            this.Text = "Derzeitiges Inventar";
        }
        
        //Takes the input of the textboxes, stores them in variables, parses them, and adds them into the database. If a step doesnt work, an Error appears.
        //
        private void btnAddWareAdd_Click(object sender, EventArgs e)
        {
            string unit = txtAddWareUnit.Text;
            string name = txtAddWareName.Text;
            string count = txtAddWareCount.Text;
            double price;
            double countParsed;
            bool priceParse = double.TryParse(txtAddWarePrice.Text, out price);
            bool countParse = double.TryParse(txtAddWareCount.Text, out countParsed);
            if(!priceParse|| !countParse)
            {   
                foreach(TextBox text in addWaresTextboxes)
                {
                    text.Text = "";
                }
                MessageBox.Show("Keine gültige Zahl als Preis oder Menge eingegeben", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(name == "")
            {
                MessageBox.Show("Es muss mindestens ein Name eingegeben werden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                price = Math.Round(price, 2);
                countParsed = Math.Round(countParsed, 2);
                
                foreach (TextBox text in addWaresTextboxes)
                {
                    text.Text = "";
                }
                    Database_Connection_Open();
                try
                {
                    string query = "INSERT INTO wares(`Name`, `Price`, `Count`, `MeasureUnit`, `ID`) VALUES('" + name + "', '" + price + "', '" + count + "', '" + unit + "', NULL)";
                    commandDatabase = new MySqlCommand(query, databaseConnection);
                    myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Erfolgreich eingefügt.", "Erfolg", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion
        //The Code necessary for showing the wares data in the data grid
        private void Mainframe_Load(object sender, EventArgs e)
        {
            try
            {
                this.waresTableAdapter.Fill(this.inventurDataSet.wares);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Disables all buttons and makes them invisible
        private void Clear_Buttons(Button[] oldBtnArray)
        {
            foreach(Button btn in oldBtnArray)
            {
                btn.Enabled = false;
                btn.Visible = false;
            }
        }

        //Places new buttons according to their standard placement and enables them
        private void Place_New_Buttons(Button[] newBtnArray, Point[] points)
        {
            for(int i = 0; i < newBtnArray.Length; i++)
            {
                newBtnArray[i].Enabled = true;
                newBtnArray[i].Visible = true;
                newBtnArray[i].Location = points[i];
            }
        }
        //Placing labels and making them visible
        private void Place_New_Labels(Label[] labels, Point[] points)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = true;
                labels[i].Location = points[i];
            }
        }

        //Making Labels invisible
        private void Clear_Labels(Label[] labels)
        {
            foreach(Label label in labels)
            { label.Visible = false; }
        }

        //Placing textboxes
        private void Place_New_Textboxes(TextBox[] textBoxes, Point[] points)
        {
            for(int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Visible = true;
                textBoxes[i].Enabled = true;
                textBoxes[i].Location = points[i];
            }
        }

        //Making Textboxes invisible
        private void Clear_All_Textboxes(TextBox[] textBoxes)
        {
            foreach(TextBox textBox in textBoxes)
            { textBox.Visible = false; textBox.Enabled = false; }
        }

        //Changes the size of the main window
        private void Resize_Mainframe(int width, int height)
        {
            this.Size = new Size(width, height);
        }

        //places the datagrid and makes it visible
        private void Place_Datagrid(DataGridView dataGrid)
        {
            dataGrid.Location = variables.DataGrid_Point;
            dataGrid.Height = variables.DataGrid_Height;
            dataGrid.Width = variables.DataGrid_Width;
            dataGrid.Enabled = true;
            dataGrid.Visible = true;
        }
        //Makes the datagrid invisible
        private void Remove_Datagrid(DataGridView datagrid)
        {
            datagrid.Enabled = false;
            datagrid.Visible = false;
        }
    }
}
