using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventory_manager
{
    public partial class MainFrame : Form
    {
        //Start initliazing necessary classes, arrays etc.
        DataSet data;
        Variables variables;
        MySqlConnection databaseConnection;
        MySqlCommand commandDatabase;
        MySqlDataReader myReader;
        MySqlDataAdapter adapter;
        
        Label[] addWaresLabels, waresIncLabels, currentInventoryLabels, newInvenLabels, newCountLabels;
        TextBox[] addWaresTextboxes, waresIncTextboxes, currentInventoryTextbox, newInvenTextboxes;
        Button[] mainWindowButtons, currentInventoryButtons, addWaresButtons, waresIncButtons, newInvenButtons, newCountButtons;
        ComboBox[] waresIncCombos, newInvenCombos;
        RadioButton[] newInvenRadios;
        
        Point[] mainWindowButtonPoints, currentInventoryPoints, addWaresLabelsPoints, addWaresTextboxPoints, addWareButtonPoints, waresIncComboPlaces;
        Point[] waresIncTextboxPlaces, waresIncLabelPlaces, waresIncButtonPlaces, currentInventoryDelLabelPlaces, currentInventoryTxtBoxPlaces;
        Point[] newInvenTextboxPlaces, newInvenButtonPlaces, newInvenRadioPlaces, newInvenComboPlaces, newInvenLabelPlaces;
        Point[] newCountButtonPlace, newCountLabelPlaces;

        public MainFrame()
        {               
            InitializeComponent();
            variables = new Variables();
            Database_Connection_Open();

            //Filling list for the data grid
            try
            {
                string query = @"SELECT * FROM wares";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                adapter = new MySqlDataAdapter(commandDatabase);
                data = new DataSet();
                adapter.Fill(data);
                dataGridWares.DataSource = data.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Main Window
            mainWindowButtons = new Button[] { btnInventoryCurrent, btnNewInventory, btnShipmentInc, btnShipmentOut,btnInventoryLast, btnMainCloseProgram };
            mainWindowButtonPoints = new Point[] { variables.CurrentInventory_BtnPlace, variables.NewInvetory_BtnPlace, variables.ShipmentInc_BtnPlace, variables.ShipmentOut_BtnPlace, variables.LastInventory_ButtonPlace, variables.CloseProgram_ButtonPlace };
            
            //Current Inventory Window
            currentInventoryButtons = new Button[] { btnCurrentInventoryBack, btnCurrentInventoryAdd, btnCurrentInventoryDel };
            currentInventoryPoints = new Point[] { variables.CurrentInventory_BackBtnPlace, variables.CurrentInventory_AddBtnPlace, variables.CurrentInventory_DelBtnPlace };
            currentInventoryLabels = new Label[] { lblCurrentInventoryDelete };
            currentInventoryDelLabelPlaces = new Point[] { variables.CurrentWares_DelLabelPlace };
            currentInventoryTextbox = new TextBox[] { txtCurrentInventoryDelete };
            currentInventoryTxtBoxPlaces = new Point[] { variables.CurrentWares_TxtBoxPlace };

            //Add Wares Window
            addWaresLabels = new Label[] { lblAddWareText, lblAddWareTextName, lblAddWareTextPrice, lblAddWareTextCount, lblAddWareTextUnit };
            addWaresLabelsPoints = new Point[] { variables.AddWareMainLabelPoint, variables.AddWareLabelNamePoint, variables.AddWareLabelPricePoint, variables.AddWareLabelCountPoint, variables.AddWareLabelUnitPoint };
            addWaresTextboxPoints = new Point[] { variables.AddWareTxtName, variables.AddWareTxtPrice, variables.AddWareTxtCount, variables.AddWareTxtUnit };
            addWaresTextboxes = new TextBox[] { txtAddWareName, txtAddWarePrice, txtAddWareCount, txtAddWareUnit };
            addWaresButtons = new Button[] { btnAddWareAdd, btnAddWareCancel };
            addWareButtonPoints = new Point[] { variables.AddWareAddButtonPoint, variables.AddWareCancelButtonPoint };
            
            //Wares Inc Window
            waresIncCombos = new ComboBox[] { dropDownWareInc01, dropDownWareInc02, dropDownWareInc03, dropDownWareInc04, dropDownWareInc05 };
            waresIncComboPlaces = new Point[] { variables.WaresInc_ComboOne, variables.WaresInc_ComboTwo, variables.WaresInc_ComboThree, variables.WaresInc_ComboFour, variables.WaresInc_ComboFive };
            waresIncTextboxes = new TextBox[] { txtWareInc01, txtWareInc02, txtWareInc03, txtWareInc04, txtWareInc05 };
            waresIncTextboxPlaces = new Point[] { variables.WaresInc_TxtboxOne, variables.WaresInc_TxtboxTwo, variables.WaresInc_TxtboxThree, variables.WaresInc_TxtboxFour, variables.WaresInc_TxtboxFive };
            waresIncLabels = new Label[] { lblIncWare, lblIncCount };
            waresIncLabelPlaces = new Point[] { variables.WaresInc_LabelWare, variables.WaresInc_LabelCount };
            waresIncButtons = new Button[] { btnIncBack, btnIncSend };
            waresIncButtonPlaces = new Point[] { variables.WaresInc_ButtonCancel, variables.WaresInc_ButtonSend };

            //New Inventory Window
            newInvenButtonPlaces = new Point[] { variables.NewInven_ButtonNewPlace,variables.NewInven_ButtonCancel };
            newInvenButtons = new Button[] { btnNewInvenOpen, newInvenBtnCancel };
            newInvenComboPlaces = new Point[] { variables.NewInven_ComboReasonPlace };
            newInvenCombos = new ComboBox[] { comboNewInvenReason };
            newInvenTextboxes = new TextBox[] { txtNewInvenDate, txtNewInvenLeader, txtNewInvenAccount };
            newInvenTextboxPlaces = new Point[] { variables.NewInven_TxtDatePlace, variables.NewInven_TxtLeaderPlace, variables.NewInven_TxtAccountPlace };
            newInvenLabels = new Label[] { lblnewInvenReason, lblNewInvenDate, lblNewInvenLeader, lblNewInvenAccount };
            newInvenLabelPlaces = new Point[] { variables.NewInven_LabelReasonPlace, variables.NewInven_LabelDatePlace, variables.NewInven_LabelLeaderPlace, variables.NewInven_LabelAccountPlace };
            newInvenRadios = new RadioButton[] { radioNewInvenYes, radioNewInvenNo };
            newInvenRadioPlaces = new Point[] { variables.NewInven_RadioYesPlace, variables.NewInven_RadioNoPlace };

            //New Count Window
            newCountButtonPlace = new Point[] { variables.NewCount_PlusOnePlace, variables.NewCount_PluseFivePlace, variables.NewCount_PlusTenPlace, variables.NewCount_PlusFiftyPlace, variables.NewCount_SendButtonPlace, variables.NewCount_MinusOnePlace, variables.NewCount_MinusTenPlace };
            newCountButtons = new Button[] { btnNewCountPlusOne, btnNewCountPlusFive, btnNewCountPlusTen, btnNewCountPlusFifty, btnNewCountSend, btnNewCountMinusOne, btnNewCountMinusTen };
            newCountLabelPlaces = new Point[] { variables.NewCount_LabelWareFixedPlace, variables.NewCount_LabelWareCurrentPlace, variables.NewCount_LabelCountFixedPlace, variables.NewCount_LabelCountCurrentPlace };
            newCountLabels = new Label[] { lblNewCountWareFixed, lblNewCountWareCurrent, lblNewCountCountFixed, lblNewCountCountUpdating };
            
            //Initial placement of buttons and size of window
            Resize_Mainframe(variables.MainWindow_Width, variables.MainWindow_Height);
            Place_New_Buttons(mainWindowButtons, mainWindowButtonPoints);

            //Giving the comboboxes their datasource
            for (int i = 0; i < waresIncCombos.Length; i++)
            {
                waresIncCombos[i].DisplayMember = "Name";
                waresIncCombos[i].DataSource = data.Tables[0];         
            }
            Database_Connection_Close();
        }

        #region Buttons        
        //Main Window buttons
        private void btnNewInventory_Click(object sender, EventArgs e)
        {
            Clear_Buttons(mainWindowButtons);
            this.Text = "Neue Inventur";
            Resize_Mainframe(variables.NewInven_WindowWidth, variables.NewInven_WindowHeight);
            Place_New_Buttons(newInvenButtons, newInvenButtonPlaces);
            Place_New_Labels(newInvenLabels, newInvenLabelPlaces);
            Place_Comboboxes(newInvenCombos, newInvenComboPlaces);
            Place_New_Textboxes(newInvenTextboxes, newInvenTextboxPlaces);
            txtNewInvenAccount.Enabled = false;
            Place_Comboboxes(newInvenCombos, newInvenComboPlaces);
            Place_RadioButtons(newInvenRadios, newInvenRadioPlaces);
        }

        //Moves to the tab for incoming shipments
        private void btnShipmentInc_Click(object sender, EventArgs e)
        {
            variables.WaresInc_IncBool = true;
            Clear_Buttons(mainWindowButtons);
            Resize_Mainframe(variables.WaresInc_WindowWidth, variables.WaresInc_WindowHeight);
            this.Text = "Eingehende Lieferung";
            Place_New_Buttons(waresIncButtons, waresIncButtonPlaces);
            Place_New_Labels(waresIncLabels, waresIncLabelPlaces);
            Place_Comboboxes(waresIncCombos, waresIncComboPlaces);
            Place_New_Textboxes(waresIncTextboxes, waresIncTextboxPlaces);
        }
        
        //In theory the start of a new inventory creates a string that can be saved via streamreader, or otherwise used for working, then starts the Actual count
        private void btnNewInvenOpen_Click(object sender, EventArgs e)
        {
            string newInvenReason = comboNewInvenReason.Text;
            string newInvenLeader = txtNewInvenLeader.Text;
            DateTime newInvenDate = new DateTime();
            string newInvenAccount = txtNewInvenAccount.Text;

            if (newInvenLeader != "")
            {
                try
                {   //Parsing the textbox to datetime
                    newInvenDate = DateTime.ParseExact(txtNewInvenDate.Text, "d", null);
                    
                    if (radioNewInvenYes.Checked && txtNewInvenAccount.Text != "Name") //Crafting the string
                    {   
                        variables.NewInven_DataInput = newInvenReason + ";" + newInvenLeader + ";" + newInvenAccount + ";" + newInvenDate.ToString();
                    }
                    else
                    {
                        variables.NewInven_DataInput = newInvenReason + ";" + newInvenLeader + ";" + newInvenDate.ToString();
                    }
                    //Saving string via streamwriter
                    using (StreamWriter sw = new StreamWriter("LastStockTaking.txt"))
                    {
                        sw.WriteLine(variables.NewInven_DataInput);

                    }
                    //Clearing textboxes
                    comboNewInvenReason.Text = "";
                    txtNewInvenLeader.Text = "";
                    txtNewInvenAccount.Text = "Name";
                    txtNewInvenDate.Text = "";

                    //Moving to the actual "Counting" tab
                    Clear_All_Comboboxes(newInvenCombos);
                    Clear_All_RadioButtons(newInvenRadios);
                    Clear_All_Textboxes(newInvenTextboxes);
                    Clear_Buttons(newInvenButtons);
                    Clear_Labels(newInvenLabels);
                    Resize_Mainframe(variables.NewCount_WindowWidth, variables.NewCount_WindowHeight);
                    Place_New_Labels(newCountLabels, newCountLabelPlaces);
                    Place_New_Buttons(newCountButtons, newCountButtonPlace);
                    this.Text = "Zählung";

                    //establish connection, and get the needed Name and item count from the database via query
                    Database_Connection_Open();

                    string query = "SELECT `Name`,`Count` FROM `wares`";
                    commandDatabase = new MySqlCommand(query, databaseConnection);
                    myReader = commandDatabase.ExecuteReader();
                    myReader.Read();
                    lblNewCountWareCurrent.Text = myReader.GetString(0);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Das gültige Datumsformat ist dd.mm.yyyy");
                }
            }
            else
            {
                MessageBox.Show("Inventurleiter angeben", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Going back to the main menu from the "new inventory" tab
        private void newInvenBtnCancel_Click(object sender, EventArgs e)
        {
            Clear_Buttons(newInvenButtons);
            Clear_All_Comboboxes(newInvenCombos);
            Clear_All_Textboxes(newInvenTextboxes);
            Clear_Labels(newInvenLabels);
            Clear_All_RadioButtons(newInvenRadios);
            Place_New_Buttons(mainWindowButtons, mainWindowButtonPoints);
            this.Text = "Inventur";
            Resize_Mainframe(variables.MainWindow_Width, variables.MainWindow_Height);            
        }

        //The six buttons for counting items in the "counting" Tab (+1, +5, +10, +50, -1, -10)
        private void btnNewCountPlusOne_Click(object sender, EventArgs e)
        {
            variables.NewCount_Counter++;
            lblNewCountCountUpdating.Text = variables.NewCount_Counter.ToString();
        }

        private void btnNewCountPlusFive_Click(object sender, EventArgs e)
        {
            variables.NewCount_Counter += 5;
            lblNewCountCountUpdating.Text = variables.NewCount_Counter.ToString();
        }

        private void btnNewCountPlusTen_Click(object sender, EventArgs e)
        {
            variables.NewCount_Counter += 10;
            lblNewCountCountUpdating.Text = variables.NewCount_Counter.ToString();
        }

        private void btnNewCountPlusFifty_Click(object sender, EventArgs e)
        {
            variables.NewCount_Counter += 50;
            lblNewCountCountUpdating.Text = variables.NewCount_Counter.ToString();
        }

        private void btnNewCountMinusOne_Click_Click(object sender, EventArgs e)
        {
            variables.NewCount_Counter--;
            if(variables.NewCount_Counter < 0)
            {
                variables.NewCount_Counter = 0;
            }
            lblNewCountCountUpdating.Text = variables.NewCount_Counter.ToString();
        }

        private void btnNewCountMinusTen_Click_Click(object sender, EventArgs e)
        {
            variables.NewCount_Counter-=10;
            if (variables.NewCount_Counter < 0)
            {
                variables.NewCount_Counter = 0;
            }
            lblNewCountCountUpdating.Text = variables.NewCount_Counter.ToString();
        }

        //Send count in the Counting tab
        private void btnNewCountSend_Click(object sender, EventArgs e)
        {
            try
            {
                //reader stores in variables, oldname is a compare-string if the reader visited the last line
                int countAmount;
                string countName = myReader.GetString(0);
                string oldname = myReader.GetString(0);
                Int32.TryParse(myReader.GetString(1), out countAmount);
                
                //compare databank result to count result
                int countResult = countAmount - variables.NewCount_Counter;
                
                //If there are more items than expected, and asks if the databank should be updated
                if (countResult < 0)
                {
                    countResult *= -1;
                    DialogResult dialogResult = MessageBox.Show("Es gibt einen Überschuss von " + countResult + " Einheiten, den Wert in der Datenbank anpassen?", "Überschuss", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        NewCount_Databank_Updater(countName);
                    }
                }
                
                //If there are less items than expected, and asks if the databank should be updated
                else if(countResult > 0)
                {                    
                    DialogResult dialogResult = MessageBox.Show("Es gibt einen Fehlbetrag von " + countResult + " Einheiten, den Wert in der Datenbank anpassen?", "Fehlbetrag", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        NewCount_Databank_Updater(countName);
                    }
                }                                
                //If the count fits accurately with the databank
                else
                {
                    MessageBox.Show("Der gezählte Betrag stimmt mit der Datenbank überein", "Zählung korrekt", MessageBoxButtons.OK);
                }
                //Moves to the next line of the query
                myReader.Read();
                lblNewCountWareCurrent.Text = myReader.GetString(0);
                string newName = myReader.GetString(0);
                variables.NewCount_Counter = 0;
                lblNewCountCountUpdating.Text = variables.NewCount_Counter.ToString();
                variables.NewCount_DatabaseWalker++;
                
                //If, even after moving to the next line, the name of the item stays the same (aka there is no new item)
                //Goes back to the main menu
                if (newName == oldname)
                {
                    myReader.Close();
                    MessageBox.Show("Zählung abgeschlossen, Rückkehr zum Hauptmenü", "Abschluss", MessageBoxButtons.OK);
                    Fill_DataTable();

                    Clear_Labels(newCountLabels);
                    Clear_Buttons(newCountButtons);
                    Resize_Mainframe(variables.MainWindow_Width, variables.MainWindow_Height);
                    Place_New_Buttons(mainWindowButtons, mainWindowButtonPoints);
                    this.Text = "Inventur";
                    myReader.Close();
                    Database_Connection_Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Goes to the tab where you can change the amount of items
        private void btnShipmentOut_Click(object sender, EventArgs e)
        {
            Clear_Buttons(mainWindowButtons);
            Resize_Mainframe(variables.WaresInc_WindowWidth, variables.WaresInc_WindowHeight);
            this.Text = "Ausgehende Lieferung";
            Place_New_Buttons(waresIncButtons, waresIncButtonPlaces);
            Place_New_Labels(waresIncLabels, waresIncLabelPlaces);
            Place_Comboboxes(waresIncCombos, waresIncComboPlaces);
            Place_New_Textboxes(waresIncTextboxes, waresIncTextboxPlaces);
        }

        private void btnInventoryLast_Click(object sender, EventArgs e)
        {
            if (File.Exists("LastStockTaking.txt"))
            {
                using (StreamReader sr = new StreamReader("LastStockTaking.txt"))
                {

                }
            }
            else
            {
                MessageBox.Show("LastStockTaking.txt fehlt.", "Fehlende Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMainCloseProgram_Click(object sender, EventArgs e)
        {
            myReader.Close();
            Database_Connection_Close();
            Environment.Exit(0);
        }

        //places Current-Inventory Window
        private void btnInventoryCurrent_Click(object sender, EventArgs e)
        {
            Clear_Buttons(mainWindowButtons);
            Resize_Mainframe(variables.Window_DataGrid_Width, variables.Window_DataGrid_Height);
            Place_Datagrid(dataGridWares);
            Place_New_Buttons(currentInventoryButtons, currentInventoryPoints);
            Place_New_Labels(currentInventoryLabels, currentInventoryDelLabelPlaces);
            Place_New_Textboxes(currentInventoryTextbox, currentInventoryTxtBoxPlaces);
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
            Clear_Labels(currentInventoryLabels);
            Clear_All_Textboxes(currentInventoryTextbox);
            this.Text = "Inventur";
        }

        //Goes to the tab where you add a new item to the list
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
            //Check if something is written in the index box, and parses it
            bool deleteParseBool = false;
            double deleteIndex = -1;
            if(txtCurrentInventoryDelete.Text != "")
            {
                deleteParseBool = double.TryParse(txtCurrentInventoryDelete.Text, out deleteIndex);
            }
            //Error if one of the previous steps didnt work, or a decimal was entered
            if(!deleteParseBool)
            { MessageBox.Show("Bitte einen gültigen Index eingeben.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            else //What happens when valid input was entered
            {
                try //forms a query with the given index and deletes that row
                {
                    Database_Connection_Open();
                    string query = "SELECT `ID` FROM `wares` WHERE `ID` =" + deleteIndex;
                    commandDatabase = new MySqlCommand(query, databaseConnection);
                    myReader = commandDatabase.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        myReader.Close();
                        query = "DELETE FROM wares WHERE ID=" + deleteIndex.ToString() + ";";
                        commandDatabase = new MySqlCommand(query, databaseConnection);
                        myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Löschung Erfolgreich", "Erfolg");
                        Database_Connection_Close();
                        myReader.Close();
                    }
                    else
                    {
                        myReader.Close();
                        MessageBox.Show("Keine Ware am angegebenen Index gefunden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Fill_DataTable();
        }

        //Returns from incoming wares to main menu
        private void btnIncBack_Click(object sender, EventArgs e)
        {
            Clear_All_Textboxes(waresIncTextboxes);
            Clear_Buttons(waresIncButtons);
            Clear_Labels(waresIncLabels);
            Clear_All_Comboboxes(waresIncCombos);
            Resize_Mainframe(variables.MainWindow_Width, variables.MainWindow_Height);
            Place_New_Buttons(mainWindowButtons, mainWindowButtonPoints);
            this.Text = "Inventur";
            variables.WaresInc_IncBool = false;
        }

        //Checks for possible mistakes made (no/wrong entry), and changes everything where value was changed
        private void btnIncSend_Click(object sender, EventArgs e)
        {
            double addValue = 0;
            double oldValue = 0;
            bool textBoxTryParse = false;
            Database_Connection_Open();
            try
            {   //Goes through each Textbox
                for(int i = 0; i < waresIncTextboxes.Length; i++)
                {   //Checks if something was written in the textbox
                    if(waresIncTextboxes[i].Text != "")
                    {   //If yes, try parsing
                        textBoxTryParse = double.TryParse(waresIncTextboxes[i].Text, out addValue);
                        if (!textBoxTryParse || addValue < 0)
                        {   //Error if value was below 0 or not a number, and skips this loop iteration
                            MessageBox.Show(waresIncCombos[i].Text + " konnte nicht verändert werden.");
                            continue;
                        }
                        //What happens When valid user input was given
                        else
                        {   //build a query to get count/id from the wares in question
                            myReader.Close();
                            string query = "SELECT `Count`,`ID` FROM `wares` WHERE `Name`=\"" + waresIncCombos[i].Text + "\";";
                            commandDatabase = new MySqlCommand(query, databaseConnection);
                            myReader = commandDatabase.ExecuteReader();
                            //Goes this route if it found the item in question (Which should be the case considering its from a drop down list)
                            if(myReader.HasRows)
                            {   //Gets the count and id and stores it in variables
                                myReader.Read();
                                string countString = myReader.GetString(0);
                                string idString = myReader.GetString(1);
                                double.TryParse(countString, out oldValue);
                                
                                //Calculates new value depending on if the wares are coming or going
                                if(variables.WaresInc_IncBool)
                                { addValue += oldValue; }
                                else
                                { 
                                    addValue = oldValue - addValue; 
                                    if(addValue < 0)
                                    { addValue = 0; }
                                }

                                //Closes the old reader
                                myReader.Close();

                                //update query which uses the ID and new value
                                query = "UPDATE wares SET Count='" + addValue.ToString() + "'WHERE ID ="+idString+";";
                                commandDatabase = new MySqlCommand(query, databaseConnection);
                                myReader = commandDatabase.ExecuteReader();
                            }
                        }
                    }
                    //Clears text of the textbox
                    waresIncTextboxes[i].Text = "";
                }
                //Final message to say that we are through
                MessageBox.Show("Waren wurden erfolgreich aktualisiert");
            }
            catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            Database_Connection_Close();
            myReader.Close();
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
        private void btnAddWareAdd_Click(object sender, EventArgs e)
        {
            Database_Connection_Open();
            string unit = txtAddWareUnit.Text;
            string name = txtAddWareName.Text;
            string count = txtAddWareCount.Text;
            double price;
            double countParsed;
            bool priceParse = double.TryParse(txtAddWarePrice.Text, out price);
            bool countParse = double.TryParse(txtAddWareCount.Text, out countParsed);

            try//Checks if user input was valid
            {
                if (!priceParse || !countParse)
                {
                    foreach (TextBox text in addWaresTextboxes)
                    {
                        text.Text = "";
                    }
                    MessageBox.Show("Keine gültige Zahl als Preis oder Menge eingegeben", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Checks if minimum requirements are met
                else if (name == "")
                {
                    MessageBox.Show("Es muss ein Name eingegeben werden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (unit == "")
                {
                    MessageBox.Show("Es muss eine Einheit eingegeben werden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Normal route if valid input was given, rounds numbers, clears textboxes, and builds an Insert string
                else
                {
                    price = Math.Round(price, 2);
                    countParsed = Math.Round(countParsed, 2);

                    foreach (TextBox text in addWaresTextboxes)
                    {
                        text.Text = "";
                    }
                    Database_Connection_Open();

                    string query = "INSERT INTO wares(`Name`, `Price`, `Count`, `MeasureUnit`, `ID`) VALUES('" + name + "', '" + price + "', '" + count + "', '" + unit + "', NULL)";
                    commandDatabase = new MySqlCommand(query, databaseConnection);
                    myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Erfolgreich eingefügt.", "Erfolg", MessageBoxButtons.OK);
                    Fill_DataTable();
                }
                Database_Connection_Close();
                myReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        //All on-click events of the buttons 

        //Enables the textbox when the radiobox of the accountant was changed to "yes"
        private void radioNewInvenYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNewInvenYes.Checked)
            {
                txtNewInvenAccount.Text = "";
                txtNewInvenAccount.Enabled = true;
            }
            else
            {
                txtNewInvenAccount.Enabled = false;
                txtNewInvenAccount.Text = "Name";
            }
        }

        //Calling the method necessary for filling the data grid at loadup
        private void Mainframe_Load(object sender, EventArgs e)
        {
            Fill_DataTable();
        }

        #region UI_Updates
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
                labels[i].Enabled = true;
                labels[i].Location = points[i];
            }
        }

        //Making Labels invisible
        private void Clear_Labels(Label[] labels)
        {
            foreach(Label label in labels)
            { 
                label.Visible = false;
                label.Enabled = false;
            }
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

        //places ComboBoxes
        private void Place_Comboboxes(ComboBox[] comboBoxes, Point[] points)
        {
            for(int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].Enabled = true;
                comboBoxes[i].Visible = true;
                comboBoxes[i].Location = points[i];
            }
        }
        
        //Removes comboboxes
        private void Clear_All_Comboboxes(ComboBox[] comboBoxes)
        {
            foreach(ComboBox comboBox in comboBoxes)
            {
                comboBox.Enabled = false;
                comboBox.Visible = false;
            }
        }
        
        //Places radiobuttons at given place
        private void Place_RadioButtons(RadioButton[] radioButtons, Point[] points)
        {
            for(int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].Enabled = true;
                radioButtons[i].Visible = true;
                radioButtons[i].Location = points[i];
            }
        }

        //Removes all radiobuttons
        private void Clear_All_RadioButtons(RadioButton[] radioButtons)
        {
            for(int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].Enabled = false;
                radioButtons[i].Visible = false;
            }
        }
        
        //Updating data grid and comboboxes
        private void Fill_DataTable()
        {
            try
            {
                string query = @"SELECT * FROM wares";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                adapter = new MySqlDataAdapter(commandDatabase);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dataGridWares.DataSource = data.Tables[0];

                for (int i = 0; i < waresIncCombos.Length; i++)
                {
                    waresIncCombos[i].DisplayMember = "Name";
                    waresIncCombos[i].DataSource = data.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion  
        //Replacing / Adding / Removing / Updating UI elements like buttons, labels, datagrids etc.
        
        
        //closes myReader, opens up a new query, updates "name", and moves old reader to position of the Databasewalker
        private void NewCount_Databank_Updater(string name)
        {
            myReader.Close();
            
            string secondaryQuery = "UPDATE wares SET Count='" + variables.NewCount_Counter + "'WHERE Name ='" + name + "';";
            commandDatabase = new MySqlCommand(secondaryQuery, databaseConnection);
            myReader = commandDatabase.ExecuteReader();
            myReader.Close();
            
            string query = "SELECT `Name`,`Count` FROM `wares`";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            myReader = commandDatabase.ExecuteReader();
            for (int i = 0; i <= variables.NewCount_DatabaseWalker; i++)
            { myReader.Read(); }
        }
        
        //Connecting to inventory database
        private void Database_Connection_Open()
        {
            try
            {
                databaseConnection = new MySqlConnection(variables.Connection_String);
                databaseConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Closing Connection to inventory database
        private void Database_Connection_Close()
        {
            try
            { databaseConnection.Close(); }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }
    }
}