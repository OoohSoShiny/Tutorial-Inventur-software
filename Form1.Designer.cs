
namespace Inventory_manager
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNewInventory = new System.Windows.Forms.Button();
            this.btnShipmentInc = new System.Windows.Forms.Button();
            this.btnInventoryCurrent = new System.Windows.Forms.Button();
            this.btnShipmentOut = new System.Windows.Forms.Button();
            this.dataGridWares = new System.Windows.Forms.DataGridView();
            this.waresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventurDataSet = new Inventory_manager.inventurDataSet();
            this.waresTableAdapter = new Inventory_manager.inventurDataSetTableAdapters.waresTableAdapter();
            this.btnCurrentInventoryBack = new System.Windows.Forms.Button();
            this.btnCurrentInventoryAdd = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCurrentInventoryDel = new System.Windows.Forms.Button();
            this.lblAddWareText = new System.Windows.Forms.Label();
            this.lblAddWareTextName = new System.Windows.Forms.Label();
            this.lblAddWareTextPrice = new System.Windows.Forms.Label();
            this.lblAddWareTextCount = new System.Windows.Forms.Label();
            this.lblAddWareTextUnit = new System.Windows.Forms.Label();
            this.txtAddWareName = new System.Windows.Forms.TextBox();
            this.txtAddWarePrice = new System.Windows.Forms.TextBox();
            this.txtAddWareCount = new System.Windows.Forms.TextBox();
            this.txtAddWareUnit = new System.Windows.Forms.TextBox();
            this.btnAddWareAdd = new System.Windows.Forms.Button();
            this.btnAddWareCancel = new System.Windows.Forms.Button();
            this.dropDownWareInc01 = new System.Windows.Forms.ComboBox();
            this.dropDownWareInc02 = new System.Windows.Forms.ComboBox();
            this.dropDownWareInc03 = new System.Windows.Forms.ComboBox();
            this.dropDownWareInc04 = new System.Windows.Forms.ComboBox();
            this.dropDownWareInc05 = new System.Windows.Forms.ComboBox();
            this.txtWareInc01 = new System.Windows.Forms.TextBox();
            this.txtWareInc02 = new System.Windows.Forms.TextBox();
            this.txtWareInc03 = new System.Windows.Forms.TextBox();
            this.txtWareInc04 = new System.Windows.Forms.TextBox();
            this.txtWareInc05 = new System.Windows.Forms.TextBox();
            this.btnIncBack = new System.Windows.Forms.Button();
            this.btnIncSend = new System.Windows.Forms.Button();
            this.lblIncWare = new System.Windows.Forms.Label();
            this.lblIncCount = new System.Windows.Forms.Label();
            this.txtCurrentInventoryDelete = new System.Windows.Forms.TextBox();
            this.lblCurrentInventoryDelete = new System.Windows.Forms.Label();
            this.lblnewInvenReason = new System.Windows.Forms.Label();
            this.lblNewInvenDate = new System.Windows.Forms.Label();
            this.lblNewInvenLeader = new System.Windows.Forms.Label();
            this.lblNewInvenAccount = new System.Windows.Forms.Label();
            this.txtNewInvenDate = new System.Windows.Forms.TextBox();
            this.txtNewInvenLeader = new System.Windows.Forms.TextBox();
            this.radioNewInvenYes = new System.Windows.Forms.RadioButton();
            this.radioNewInvenNo = new System.Windows.Forms.RadioButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.txtNewInvenAccount = new System.Windows.Forms.TextBox();
            this.comboNewInvenReason = new System.Windows.Forms.ComboBox();
            this.btnNewInvenOpen = new System.Windows.Forms.Button();
            this.newInvenBtnCancel = new System.Windows.Forms.Button();
            this.lblNewCountWareFixed = new System.Windows.Forms.Label();
            this.lblNewCountWareCurrent = new System.Windows.Forms.Label();
            this.lblNewCountCountFixed = new System.Windows.Forms.Label();
            this.lblNewCountCountUpdating = new System.Windows.Forms.Label();
            this.btnNewCountPlusOne = new System.Windows.Forms.Button();
            this.btnNewCountPlusFive = new System.Windows.Forms.Button();
            this.btnNewCountPlusTen = new System.Windows.Forms.Button();
            this.btnNewCountPlusFifty = new System.Windows.Forms.Button();
            this.btnNewCountSend = new System.Windows.Forms.Button();
            this.btnNewCountMinusOne = new System.Windows.Forms.Button();
            this.btnNewCountMinusTen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventurDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewInventory
            // 
            this.btnNewInventory.Location = new System.Drawing.Point(31, 418);
            this.btnNewInventory.Name = "btnNewInventory";
            this.btnNewInventory.Size = new System.Drawing.Size(102, 23);
            this.btnNewInventory.TabIndex = 0;
            this.btnNewInventory.Text = "Neue Inventur";
            this.btnNewInventory.UseVisualStyleBackColor = true;
            this.btnNewInventory.Click += new System.EventHandler(this.btnNewInventory_Click);
            // 
            // btnShipmentInc
            // 
            this.btnShipmentInc.Location = new System.Drawing.Point(501, 348);
            this.btnShipmentInc.Name = "btnShipmentInc";
            this.btnShipmentInc.Size = new System.Drawing.Size(117, 23);
            this.btnShipmentInc.TabIndex = 1;
            this.btnShipmentInc.Text = "Lieferung Eingehend";
            this.btnShipmentInc.UseVisualStyleBackColor = true;
            this.btnShipmentInc.Click += new System.EventHandler(this.btnShipmentInc_Click);
            // 
            // btnInventoryCurrent
            // 
            this.btnInventoryCurrent.Location = new System.Drawing.Point(374, 500);
            this.btnInventoryCurrent.Name = "btnInventoryCurrent";
            this.btnInventoryCurrent.Size = new System.Drawing.Size(126, 23);
            this.btnInventoryCurrent.TabIndex = 2;
            this.btnInventoryCurrent.Text = "Derzeitiges Inventar";
            this.btnInventoryCurrent.UseVisualStyleBackColor = true;
            this.btnInventoryCurrent.Click += new System.EventHandler(this.btnInventoryCurrent_Click);
            // 
            // btnShipmentOut
            // 
            this.btnShipmentOut.Location = new System.Drawing.Point(215, 499);
            this.btnShipmentOut.Name = "btnShipmentOut";
            this.btnShipmentOut.Size = new System.Drawing.Size(125, 23);
            this.btnShipmentOut.TabIndex = 3;
            this.btnShipmentOut.Text = "Lieferung Ausgehend";
            this.btnShipmentOut.UseVisualStyleBackColor = true;
            this.btnShipmentOut.Click += new System.EventHandler(this.btnShipmentOut_Click);
            // 
            // dataGridWares
            // 
            this.dataGridWares.AllowUserToAddRows = false;
            this.dataGridWares.AllowUserToDeleteRows = false;
            this.dataGridWares.AllowUserToResizeColumns = false;
            this.dataGridWares.AllowUserToResizeRows = false;
            this.dataGridWares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridWares.Enabled = false;
            this.dataGridWares.Location = new System.Drawing.Point(361, 183);
            this.dataGridWares.Name = "dataGridWares";
            this.dataGridWares.Size = new System.Drawing.Size(157, 67);
            this.dataGridWares.TabIndex = 4;
            this.dataGridWares.Visible = false;
            // 
            // waresBindingSource
            // 
            this.waresBindingSource.DataMember = "wares";
            this.waresBindingSource.DataSource = this.inventurDataSet;
            // 
            // inventurDataSet
            // 
            this.inventurDataSet.DataSetName = "inventurDataSet";
            this.inventurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waresTableAdapter
            // 
            this.waresTableAdapter.ClearBeforeFill = true;
            // 
            // btnCurrentInventoryBack
            // 
            this.btnCurrentInventoryBack.Enabled = false;
            this.btnCurrentInventoryBack.Location = new System.Drawing.Point(110, 447);
            this.btnCurrentInventoryBack.Name = "btnCurrentInventoryBack";
            this.btnCurrentInventoryBack.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentInventoryBack.TabIndex = 5;
            this.btnCurrentInventoryBack.Text = "Zurück";
            this.btnCurrentInventoryBack.UseVisualStyleBackColor = true;
            this.btnCurrentInventoryBack.Visible = false;
            this.btnCurrentInventoryBack.Click += new System.EventHandler(this.btnCurrentInventoryBack_Click);
            // 
            // btnCurrentInventoryAdd
            // 
            this.btnCurrentInventoryAdd.Enabled = false;
            this.btnCurrentInventoryAdd.Location = new System.Drawing.Point(112, 523);
            this.btnCurrentInventoryAdd.Name = "btnCurrentInventoryAdd";
            this.btnCurrentInventoryAdd.Size = new System.Drawing.Size(105, 23);
            this.btnCurrentInventoryAdd.TabIndex = 6;
            this.btnCurrentInventoryAdd.Text = "Ware hinzufügen";
            this.btnCurrentInventoryAdd.UseVisualStyleBackColor = true;
            this.btnCurrentInventoryAdd.Visible = false;
            this.btnCurrentInventoryAdd.Click += new System.EventHandler(this.btnCurrentInventoryAdd_Click);
            // 
            // btnCurrentInventoryDel
            // 
            this.btnCurrentInventoryDel.Enabled = false;
            this.btnCurrentInventoryDel.Location = new System.Drawing.Point(312, 526);
            this.btnCurrentInventoryDel.Name = "btnCurrentInventoryDel";
            this.btnCurrentInventoryDel.Size = new System.Drawing.Size(105, 23);
            this.btnCurrentInventoryDel.TabIndex = 7;
            this.btnCurrentInventoryDel.Text = "Ware entfernen";
            this.btnCurrentInventoryDel.UseVisualStyleBackColor = true;
            this.btnCurrentInventoryDel.Visible = false;
            this.btnCurrentInventoryDel.Click += new System.EventHandler(this.btnCurrentInventoryDel_Click);
            // 
            // lblAddWareText
            // 
            this.lblAddWareText.AutoSize = true;
            this.lblAddWareText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWareText.Location = new System.Drawing.Point(515, 476);
            this.lblAddWareText.Name = "lblAddWareText";
            this.lblAddWareText.Size = new System.Drawing.Size(103, 13);
            this.lblAddWareText.TabIndex = 8;
            this.lblAddWareText.Text = "Ware hinzufügen";
            this.lblAddWareText.Visible = false;
            // 
            // lblAddWareTextName
            // 
            this.lblAddWareTextName.AutoSize = true;
            this.lblAddWareTextName.Location = new System.Drawing.Point(638, 417);
            this.lblAddWareTextName.Name = "lblAddWareTextName";
            this.lblAddWareTextName.Size = new System.Drawing.Size(35, 13);
            this.lblAddWareTextName.TabIndex = 9;
            this.lblAddWareTextName.Text = "Name";
            this.lblAddWareTextName.Visible = false;
            // 
            // lblAddWareTextPrice
            // 
            this.lblAddWareTextPrice.AutoSize = true;
            this.lblAddWareTextPrice.Location = new System.Drawing.Point(49, 381);
            this.lblAddWareTextPrice.Name = "lblAddWareTextPrice";
            this.lblAddWareTextPrice.Size = new System.Drawing.Size(30, 13);
            this.lblAddWareTextPrice.TabIndex = 10;
            this.lblAddWareTextPrice.Text = "Preis";
            this.lblAddWareTextPrice.Visible = false;
            // 
            // lblAddWareTextCount
            // 
            this.lblAddWareTextCount.AutoSize = true;
            this.lblAddWareTextCount.Location = new System.Drawing.Point(495, 447);
            this.lblAddWareTextCount.Name = "lblAddWareTextCount";
            this.lblAddWareTextCount.Size = new System.Drawing.Size(40, 13);
            this.lblAddWareTextCount.TabIndex = 11;
            this.lblAddWareTextCount.Text = "Menge";
            this.lblAddWareTextCount.Visible = false;
            // 
            // lblAddWareTextUnit
            // 
            this.lblAddWareTextUnit.AutoSize = true;
            this.lblAddWareTextUnit.Location = new System.Drawing.Point(309, 415);
            this.lblAddWareTextUnit.Name = "lblAddWareTextUnit";
            this.lblAddWareTextUnit.Size = new System.Drawing.Size(59, 13);
            this.lblAddWareTextUnit.TabIndex = 12;
            this.lblAddWareTextUnit.Text = "Maßeinheit";
            this.lblAddWareTextUnit.Visible = false;
            // 
            // txtAddWareName
            // 
            this.txtAddWareName.Enabled = false;
            this.txtAddWareName.Location = new System.Drawing.Point(12, 377);
            this.txtAddWareName.Name = "txtAddWareName";
            this.txtAddWareName.Size = new System.Drawing.Size(100, 20);
            this.txtAddWareName.TabIndex = 13;
            this.txtAddWareName.Visible = false;
            // 
            // txtAddWarePrice
            // 
            this.txtAddWarePrice.Enabled = false;
            this.txtAddWarePrice.Location = new System.Drawing.Point(558, 447);
            this.txtAddWarePrice.Name = "txtAddWarePrice";
            this.txtAddWarePrice.Size = new System.Drawing.Size(100, 20);
            this.txtAddWarePrice.TabIndex = 14;
            this.txtAddWarePrice.Visible = false;
            // 
            // txtAddWareCount
            // 
            this.txtAddWareCount.Enabled = false;
            this.txtAddWareCount.Location = new System.Drawing.Point(312, 392);
            this.txtAddWareCount.Name = "txtAddWareCount";
            this.txtAddWareCount.Size = new System.Drawing.Size(100, 20);
            this.txtAddWareCount.TabIndex = 15;
            this.txtAddWareCount.Visible = false;
            // 
            // txtAddWareUnit
            // 
            this.txtAddWareUnit.Enabled = false;
            this.txtAddWareUnit.Location = new System.Drawing.Point(139, 381);
            this.txtAddWareUnit.Name = "txtAddWareUnit";
            this.txtAddWareUnit.Size = new System.Drawing.Size(100, 20);
            this.txtAddWareUnit.TabIndex = 16;
            this.txtAddWareUnit.Visible = false;
            // 
            // btnAddWareAdd
            // 
            this.btnAddWareAdd.Enabled = false;
            this.btnAddWareAdd.Location = new System.Drawing.Point(110, 483);
            this.btnAddWareAdd.Name = "btnAddWareAdd";
            this.btnAddWareAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAddWareAdd.TabIndex = 17;
            this.btnAddWareAdd.Text = "Hinzufügen";
            this.btnAddWareAdd.UseVisualStyleBackColor = true;
            this.btnAddWareAdd.Visible = false;
            this.btnAddWareAdd.Click += new System.EventHandler(this.btnAddWareAdd_Click);
            // 
            // btnAddWareCancel
            // 
            this.btnAddWareCancel.Enabled = false;
            this.btnAddWareCancel.Location = new System.Drawing.Point(31, 466);
            this.btnAddWareCancel.Name = "btnAddWareCancel";
            this.btnAddWareCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddWareCancel.TabIndex = 18;
            this.btnAddWareCancel.Text = "Abbrechen";
            this.btnAddWareCancel.UseVisualStyleBackColor = true;
            this.btnAddWareCancel.Visible = false;
            this.btnAddWareCancel.Click += new System.EventHandler(this.btnAddWareCancel_Click);
            // 
            // dropDownWareInc01
            // 
            this.dropDownWareInc01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc01.Enabled = false;
            this.dropDownWareInc01.FormattingEnabled = true;
            this.dropDownWareInc01.Location = new System.Drawing.Point(624, 211);
            this.dropDownWareInc01.Name = "dropDownWareInc01";
            this.dropDownWareInc01.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc01.TabIndex = 19;
            this.dropDownWareInc01.Visible = false;
            // 
            // dropDownWareInc02
            // 
            this.dropDownWareInc02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc02.Enabled = false;
            this.dropDownWareInc02.FormattingEnabled = true;
            this.dropDownWareInc02.Location = new System.Drawing.Point(620, 168);
            this.dropDownWareInc02.Name = "dropDownWareInc02";
            this.dropDownWareInc02.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc02.TabIndex = 20;
            this.dropDownWareInc02.Visible = false;
            // 
            // dropDownWareInc03
            // 
            this.dropDownWareInc03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc03.Enabled = false;
            this.dropDownWareInc03.FormattingEnabled = true;
            this.dropDownWareInc03.Location = new System.Drawing.Point(620, 135);
            this.dropDownWareInc03.Name = "dropDownWareInc03";
            this.dropDownWareInc03.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc03.TabIndex = 21;
            this.dropDownWareInc03.Visible = false;
            // 
            // dropDownWareInc04
            // 
            this.dropDownWareInc04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc04.Enabled = false;
            this.dropDownWareInc04.FormattingEnabled = true;
            this.dropDownWareInc04.Location = new System.Drawing.Point(625, 250);
            this.dropDownWareInc04.Name = "dropDownWareInc04";
            this.dropDownWareInc04.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc04.TabIndex = 22;
            this.dropDownWareInc04.Visible = false;
            // 
            // dropDownWareInc05
            // 
            this.dropDownWareInc05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc05.Enabled = false;
            this.dropDownWareInc05.FormattingEnabled = true;
            this.dropDownWareInc05.Location = new System.Drawing.Point(624, 286);
            this.dropDownWareInc05.Name = "dropDownWareInc05";
            this.dropDownWareInc05.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc05.TabIndex = 23;
            this.dropDownWareInc05.Visible = false;
            // 
            // txtWareInc01
            // 
            this.txtWareInc01.Enabled = false;
            this.txtWareInc01.Location = new System.Drawing.Point(682, 408);
            this.txtWareInc01.Name = "txtWareInc01";
            this.txtWareInc01.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc01.TabIndex = 24;
            this.txtWareInc01.Visible = false;
            // 
            // txtWareInc02
            // 
            this.txtWareInc02.Enabled = false;
            this.txtWareInc02.Location = new System.Drawing.Point(185, 466);
            this.txtWareInc02.Name = "txtWareInc02";
            this.txtWareInc02.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc02.TabIndex = 25;
            this.txtWareInc02.Visible = false;
            // 
            // txtWareInc03
            // 
            this.txtWareInc03.Enabled = false;
            this.txtWareInc03.Location = new System.Drawing.Point(682, 432);
            this.txtWareInc03.Name = "txtWareInc03";
            this.txtWareInc03.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc03.TabIndex = 26;
            this.txtWareInc03.Visible = false;
            // 
            // txtWareInc04
            // 
            this.txtWareInc04.Enabled = false;
            this.txtWareInc04.Location = new System.Drawing.Point(624, 476);
            this.txtWareInc04.Name = "txtWareInc04";
            this.txtWareInc04.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc04.TabIndex = 27;
            this.txtWareInc04.Visible = false;
            // 
            // txtWareInc05
            // 
            this.txtWareInc05.Enabled = false;
            this.txtWareInc05.Location = new System.Drawing.Point(641, 485);
            this.txtWareInc05.Name = "txtWareInc05";
            this.txtWareInc05.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc05.TabIndex = 28;
            this.txtWareInc05.Visible = false;
            // 
            // btnIncBack
            // 
            this.btnIncBack.Enabled = false;
            this.btnIncBack.Location = new System.Drawing.Point(112, 464);
            this.btnIncBack.Name = "btnIncBack";
            this.btnIncBack.Size = new System.Drawing.Size(75, 23);
            this.btnIncBack.TabIndex = 29;
            this.btnIncBack.Text = "Zurück";
            this.btnIncBack.UseVisualStyleBackColor = true;
            this.btnIncBack.Visible = false;
            this.btnIncBack.Click += new System.EventHandler(this.btnIncBack_Click);
            // 
            // btnIncSend
            // 
            this.btnIncSend.Enabled = false;
            this.btnIncSend.Location = new System.Drawing.Point(29, 490);
            this.btnIncSend.Name = "btnIncSend";
            this.btnIncSend.Size = new System.Drawing.Size(75, 23);
            this.btnIncSend.TabIndex = 30;
            this.btnIncSend.Text = "Abschicken";
            this.btnIncSend.UseVisualStyleBackColor = true;
            this.btnIncSend.Visible = false;
            this.btnIncSend.Click += new System.EventHandler(this.btnIncSend_Click);
            // 
            // lblIncWare
            // 
            this.lblIncWare.AutoSize = true;
            this.lblIncWare.Location = new System.Drawing.Point(231, 450);
            this.lblIncWare.Name = "lblIncWare";
            this.lblIncWare.Size = new System.Drawing.Size(33, 13);
            this.lblIncWare.TabIndex = 31;
            this.lblIncWare.Text = "Ware";
            this.lblIncWare.Visible = false;
            // 
            // lblIncCount
            // 
            this.lblIncCount.AutoSize = true;
            this.lblIncCount.Location = new System.Drawing.Point(415, 439);
            this.lblIncCount.Name = "lblIncCount";
            this.lblIncCount.Size = new System.Drawing.Size(40, 13);
            this.lblIncCount.TabIndex = 32;
            this.lblIncCount.Text = "Menge";
            this.lblIncCount.Visible = false;
            // 
            // txtCurrentInventoryDelete
            // 
            this.txtCurrentInventoryDelete.Enabled = false;
            this.txtCurrentInventoryDelete.Location = new System.Drawing.Point(641, 511);
            this.txtCurrentInventoryDelete.Name = "txtCurrentInventoryDelete";
            this.txtCurrentInventoryDelete.Size = new System.Drawing.Size(105, 20);
            this.txtCurrentInventoryDelete.TabIndex = 33;
            this.txtCurrentInventoryDelete.Visible = false;
            // 
            // lblCurrentInventoryDelete
            // 
            this.lblCurrentInventoryDelete.AutoSize = true;
            this.lblCurrentInventoryDelete.Location = new System.Drawing.Point(498, 526);
            this.lblCurrentInventoryDelete.Name = "lblCurrentInventoryDelete";
            this.lblCurrentInventoryDelete.Size = new System.Drawing.Size(133, 13);
            this.lblCurrentInventoryDelete.TabIndex = 34;
            this.lblCurrentInventoryDelete.Text = "Folgenden Index Löschen:";
            this.lblCurrentInventoryDelete.Visible = false;
            // 
            // lblnewInvenReason
            // 
            this.lblnewInvenReason.AutoSize = true;
            this.lblnewInvenReason.Enabled = false;
            this.lblnewInvenReason.Location = new System.Drawing.Point(331, 499);
            this.lblnewInvenReason.Name = "lblnewInvenReason";
            this.lblnewInvenReason.Size = new System.Drawing.Size(68, 13);
            this.lblnewInvenReason.TabIndex = 35;
            this.lblnewInvenReason.Text = "Begründung:";
            this.lblnewInvenReason.Visible = false;
            // 
            // lblNewInvenDate
            // 
            this.lblNewInvenDate.AutoSize = true;
            this.lblNewInvenDate.Enabled = false;
            this.lblNewInvenDate.Location = new System.Drawing.Point(184, 490);
            this.lblNewInvenDate.Name = "lblNewInvenDate";
            this.lblNewInvenDate.Size = new System.Drawing.Size(41, 13);
            this.lblNewInvenDate.TabIndex = 37;
            this.lblNewInvenDate.Text = "Datum:";
            this.lblNewInvenDate.Visible = false;
            // 
            // lblNewInvenLeader
            // 
            this.lblNewInvenLeader.AutoSize = true;
            this.lblNewInvenLeader.Enabled = false;
            this.lblNewInvenLeader.Location = new System.Drawing.Point(231, 485);
            this.lblNewInvenLeader.Name = "lblNewInvenLeader";
            this.lblNewInvenLeader.Size = new System.Drawing.Size(71, 13);
            this.lblNewInvenLeader.TabIndex = 38;
            this.lblNewInvenLeader.Text = "Inventurleiter:";
            this.lblNewInvenLeader.Visible = false;
            // 
            // lblNewInvenAccount
            // 
            this.lblNewInvenAccount.AutoSize = true;
            this.lblNewInvenAccount.Enabled = false;
            this.lblNewInvenAccount.Location = new System.Drawing.Point(28, 514);
            this.lblNewInvenAccount.Name = "lblNewInvenAccount";
            this.lblNewInvenAccount.Size = new System.Drawing.Size(71, 13);
            this.lblNewInvenAccount.TabIndex = 39;
            this.lblNewInvenAccount.Text = "Steuerberater";
            this.lblNewInvenAccount.Visible = false;
            // 
            // txtNewInvenDate
            // 
            this.txtNewInvenDate.Enabled = false;
            this.txtNewInvenDate.Location = new System.Drawing.Point(400, 519);
            this.txtNewInvenDate.Name = "txtNewInvenDate";
            this.txtNewInvenDate.Size = new System.Drawing.Size(100, 20);
            this.txtNewInvenDate.TabIndex = 40;
            this.txtNewInvenDate.Visible = false;
            // 
            // txtNewInvenLeader
            // 
            this.txtNewInvenLeader.Enabled = false;
            this.txtNewInvenLeader.Location = new System.Drawing.Point(418, 482);
            this.txtNewInvenLeader.Name = "txtNewInvenLeader";
            this.txtNewInvenLeader.Size = new System.Drawing.Size(100, 20);
            this.txtNewInvenLeader.TabIndex = 41;
            this.txtNewInvenLeader.Visible = false;
            // 
            // radioNewInvenYes
            // 
            this.radioNewInvenYes.AutoSize = true;
            this.radioNewInvenYes.Enabled = false;
            this.radioNewInvenYes.Location = new System.Drawing.Point(52, 443);
            this.radioNewInvenYes.Name = "radioNewInvenYes";
            this.radioNewInvenYes.Size = new System.Drawing.Size(36, 17);
            this.radioNewInvenYes.TabIndex = 42;
            this.radioNewInvenYes.Text = "Ja";
            this.radioNewInvenYes.UseVisualStyleBackColor = true;
            this.radioNewInvenYes.Visible = false;
            this.radioNewInvenYes.CheckedChanged += new System.EventHandler(this.radioNewInvenYes_CheckedChanged);
            // 
            // radioNewInvenNo
            // 
            this.radioNewInvenNo.AutoSize = true;
            this.radioNewInvenNo.Checked = true;
            this.radioNewInvenNo.Enabled = false;
            this.radioNewInvenNo.Location = new System.Drawing.Point(16, 437);
            this.radioNewInvenNo.Name = "radioNewInvenNo";
            this.radioNewInvenNo.Size = new System.Drawing.Size(47, 17);
            this.radioNewInvenNo.TabIndex = 43;
            this.radioNewInvenNo.TabStop = true;
            this.radioNewInvenNo.Text = "Nein";
            this.radioNewInvenNo.UseVisualStyleBackColor = true;
            this.radioNewInvenNo.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // txtNewInvenAccount
            // 
            this.txtNewInvenAccount.Enabled = false;
            this.txtNewInvenAccount.Location = new System.Drawing.Point(16, 332);
            this.txtNewInvenAccount.Name = "txtNewInvenAccount";
            this.txtNewInvenAccount.Size = new System.Drawing.Size(121, 20);
            this.txtNewInvenAccount.TabIndex = 44;
            this.txtNewInvenAccount.Text = "Name";
            this.txtNewInvenAccount.Visible = false;
            // 
            // comboNewInvenReason
            // 
            this.comboNewInvenReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNewInvenReason.Enabled = false;
            this.comboNewInvenReason.FormattingEnabled = true;
            this.comboNewInvenReason.Items.AddRange(new object[] {
            "Stichtag",
            "Öffnung Geschäftstätigkeit",
            "Schließung",
            "Übernahme"});
            this.comboNewInvenReason.Location = new System.Drawing.Point(112, 567);
            this.comboNewInvenReason.Name = "comboNewInvenReason";
            this.comboNewInvenReason.Size = new System.Drawing.Size(176, 21);
            this.comboNewInvenReason.TabIndex = 45;
            this.comboNewInvenReason.Visible = false;
            // 
            // btnNewInvenOpen
            // 
            this.btnNewInvenOpen.Enabled = false;
            this.btnNewInvenOpen.Location = new System.Drawing.Point(433, 376);
            this.btnNewInvenOpen.Name = "btnNewInvenOpen";
            this.btnNewInvenOpen.Size = new System.Drawing.Size(308, 23);
            this.btnNewInvenOpen.TabIndex = 46;
            this.btnNewInvenOpen.Text = "Inventur öffnen";
            this.btnNewInvenOpen.UseVisualStyleBackColor = true;
            this.btnNewInvenOpen.Visible = false;
            this.btnNewInvenOpen.Click += new System.EventHandler(this.btnNewInvenOpen_Click);
            // 
            // newInvenBtnCancel
            // 
            this.newInvenBtnCancel.Enabled = false;
            this.newInvenBtnCancel.Location = new System.Drawing.Point(416, 421);
            this.newInvenBtnCancel.Name = "newInvenBtnCancel";
            this.newInvenBtnCancel.Size = new System.Drawing.Size(211, 23);
            this.newInvenBtnCancel.TabIndex = 47;
            this.newInvenBtnCancel.Text = "Abbrechen";
            this.newInvenBtnCancel.UseVisualStyleBackColor = true;
            this.newInvenBtnCancel.Visible = false;
            this.newInvenBtnCancel.Click += new System.EventHandler(this.newInvenBtnCancel_Click);
            // 
            // lblNewCountWareFixed
            // 
            this.lblNewCountWareFixed.AutoSize = true;
            this.lblNewCountWareFixed.Enabled = false;
            this.lblNewCountWareFixed.Location = new System.Drawing.Point(13, 13);
            this.lblNewCountWareFixed.Name = "lblNewCountWareFixed";
            this.lblNewCountWareFixed.Size = new System.Drawing.Size(33, 13);
            this.lblNewCountWareFixed.TabIndex = 48;
            this.lblNewCountWareFixed.Text = "Ware";
            this.lblNewCountWareFixed.Visible = false;
            // 
            // lblNewCountWareCurrent
            // 
            this.lblNewCountWareCurrent.AutoSize = true;
            this.lblNewCountWareCurrent.Enabled = false;
            this.lblNewCountWareCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCountWareCurrent.Location = new System.Drawing.Point(78, 13);
            this.lblNewCountWareCurrent.Name = "lblNewCountWareCurrent";
            this.lblNewCountWareCurrent.Size = new System.Drawing.Size(44, 13);
            this.lblNewCountWareCurrent.TabIndex = 49;
            this.lblNewCountWareCurrent.Text = "WARE";
            this.lblNewCountWareCurrent.Visible = false;
            // 
            // lblNewCountCountFixed
            // 
            this.lblNewCountCountFixed.AutoSize = true;
            this.lblNewCountCountFixed.Enabled = false;
            this.lblNewCountCountFixed.Location = new System.Drawing.Point(12, 57);
            this.lblNewCountCountFixed.Name = "lblNewCountCountFixed";
            this.lblNewCountCountFixed.Size = new System.Drawing.Size(40, 13);
            this.lblNewCountCountFixed.TabIndex = 50;
            this.lblNewCountCountFixed.Text = "Menge";
            this.lblNewCountCountFixed.Visible = false;
            // 
            // lblNewCountCountUpdating
            // 
            this.lblNewCountCountUpdating.AutoSize = true;
            this.lblNewCountCountUpdating.Enabled = false;
            this.lblNewCountCountUpdating.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCountCountUpdating.Location = new System.Drawing.Point(146, 57);
            this.lblNewCountCountUpdating.Name = "lblNewCountCountUpdating";
            this.lblNewCountCountUpdating.Size = new System.Drawing.Size(40, 42);
            this.lblNewCountCountUpdating.TabIndex = 51;
            this.lblNewCountCountUpdating.Text = "0";
            this.lblNewCountCountUpdating.Visible = false;
            // 
            // btnNewCountPlusOne
            // 
            this.btnNewCountPlusOne.Enabled = false;
            this.btnNewCountPlusOne.Location = new System.Drawing.Point(12, 135);
            this.btnNewCountPlusOne.Name = "btnNewCountPlusOne";
            this.btnNewCountPlusOne.Size = new System.Drawing.Size(75, 23);
            this.btnNewCountPlusOne.TabIndex = 52;
            this.btnNewCountPlusOne.Text = "+1";
            this.btnNewCountPlusOne.UseVisualStyleBackColor = true;
            this.btnNewCountPlusOne.Visible = false;
            this.btnNewCountPlusOne.Click += new System.EventHandler(this.btnNewCountPlusOne_Click);
            // 
            // btnNewCountPlusFive
            // 
            this.btnNewCountPlusFive.Enabled = false;
            this.btnNewCountPlusFive.Location = new System.Drawing.Point(93, 135);
            this.btnNewCountPlusFive.Name = "btnNewCountPlusFive";
            this.btnNewCountPlusFive.Size = new System.Drawing.Size(75, 23);
            this.btnNewCountPlusFive.TabIndex = 53;
            this.btnNewCountPlusFive.Text = "+5";
            this.btnNewCountPlusFive.UseVisualStyleBackColor = true;
            this.btnNewCountPlusFive.Visible = false;
            this.btnNewCountPlusFive.Click += new System.EventHandler(this.btnNewCountPlusFive_Click);
            // 
            // btnNewCountPlusTen
            // 
            this.btnNewCountPlusTen.Enabled = false;
            this.btnNewCountPlusTen.Location = new System.Drawing.Point(174, 135);
            this.btnNewCountPlusTen.Name = "btnNewCountPlusTen";
            this.btnNewCountPlusTen.Size = new System.Drawing.Size(75, 23);
            this.btnNewCountPlusTen.TabIndex = 54;
            this.btnNewCountPlusTen.Text = "+10";
            this.btnNewCountPlusTen.UseVisualStyleBackColor = true;
            this.btnNewCountPlusTen.Visible = false;
            this.btnNewCountPlusTen.Click += new System.EventHandler(this.btnNewCountPlusTen_Click);
            // 
            // btnNewCountPlusFifty
            // 
            this.btnNewCountPlusFifty.Enabled = false;
            this.btnNewCountPlusFifty.Location = new System.Drawing.Point(255, 135);
            this.btnNewCountPlusFifty.Name = "btnNewCountPlusFifty";
            this.btnNewCountPlusFifty.Size = new System.Drawing.Size(75, 23);
            this.btnNewCountPlusFifty.TabIndex = 55;
            this.btnNewCountPlusFifty.Text = "+50";
            this.btnNewCountPlusFifty.UseVisualStyleBackColor = true;
            this.btnNewCountPlusFifty.Visible = false;
            this.btnNewCountPlusFifty.Click += new System.EventHandler(this.btnNewCountPlusFifty_Click);
            // 
            // btnNewCountSend
            // 
            this.btnNewCountSend.Enabled = false;
            this.btnNewCountSend.Location = new System.Drawing.Point(93, 253);
            this.btnNewCountSend.Name = "btnNewCountSend";
            this.btnNewCountSend.Size = new System.Drawing.Size(156, 23);
            this.btnNewCountSend.TabIndex = 56;
            this.btnNewCountSend.Text = "Menge bestätigen";
            this.btnNewCountSend.UseVisualStyleBackColor = true;
            this.btnNewCountSend.Visible = false;
            this.btnNewCountSend.Click += new System.EventHandler(this.btnNewCountSend_Click);
            // 
            // btnNewCountMinusOne
            // 
            this.btnNewCountMinusOne.Enabled = false;
            this.btnNewCountMinusOne.Location = new System.Drawing.Point(12, 186);
            this.btnNewCountMinusOne.Name = "btnNewCountMinusOne";
            this.btnNewCountMinusOne.Size = new System.Drawing.Size(75, 23);
            this.btnNewCountMinusOne.TabIndex = 57;
            this.btnNewCountMinusOne.Text = "-1";
            this.btnNewCountMinusOne.UseVisualStyleBackColor = true;
            this.btnNewCountMinusOne.Visible = false;
            this.btnNewCountMinusOne.Click += new System.EventHandler(this.btnNewCountMinusOne_Click_Click);
            // 
            // btnNewCountMinusTen
            // 
            this.btnNewCountMinusTen.Enabled = false;
            this.btnNewCountMinusTen.Location = new System.Drawing.Point(174, 186);
            this.btnNewCountMinusTen.Name = "btnNewCountMinusTen";
            this.btnNewCountMinusTen.Size = new System.Drawing.Size(75, 23);
            this.btnNewCountMinusTen.TabIndex = 58;
            this.btnNewCountMinusTen.Text = "-10";
            this.btnNewCountMinusTen.UseVisualStyleBackColor = true;
            this.btnNewCountMinusTen.Visible = false;
            this.btnNewCountMinusTen.Click += new System.EventHandler(this.btnNewCountMinusTen_Click_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 288);
            this.Controls.Add(this.btnNewCountMinusTen);
            this.Controls.Add(this.btnNewCountMinusOne);
            this.Controls.Add(this.btnNewCountSend);
            this.Controls.Add(this.btnNewCountPlusFifty);
            this.Controls.Add(this.btnNewCountPlusTen);
            this.Controls.Add(this.btnNewCountPlusFive);
            this.Controls.Add(this.btnNewCountPlusOne);
            this.Controls.Add(this.lblNewCountCountUpdating);
            this.Controls.Add(this.lblNewCountCountFixed);
            this.Controls.Add(this.lblNewCountWareCurrent);
            this.Controls.Add(this.lblNewCountWareFixed);
            this.Controls.Add(this.newInvenBtnCancel);
            this.Controls.Add(this.btnNewInvenOpen);
            this.Controls.Add(this.comboNewInvenReason);
            this.Controls.Add(this.txtNewInvenAccount);
            this.Controls.Add(this.radioNewInvenNo);
            this.Controls.Add(this.radioNewInvenYes);
            this.Controls.Add(this.txtNewInvenLeader);
            this.Controls.Add(this.txtNewInvenDate);
            this.Controls.Add(this.lblNewInvenAccount);
            this.Controls.Add(this.lblNewInvenLeader);
            this.Controls.Add(this.lblNewInvenDate);
            this.Controls.Add(this.lblnewInvenReason);
            this.Controls.Add(this.lblCurrentInventoryDelete);
            this.Controls.Add(this.txtCurrentInventoryDelete);
            this.Controls.Add(this.lblIncCount);
            this.Controls.Add(this.lblIncWare);
            this.Controls.Add(this.btnIncSend);
            this.Controls.Add(this.btnIncBack);
            this.Controls.Add(this.txtWareInc05);
            this.Controls.Add(this.txtWareInc04);
            this.Controls.Add(this.txtWareInc03);
            this.Controls.Add(this.txtWareInc02);
            this.Controls.Add(this.txtWareInc01);
            this.Controls.Add(this.dropDownWareInc05);
            this.Controls.Add(this.dropDownWareInc04);
            this.Controls.Add(this.dropDownWareInc03);
            this.Controls.Add(this.dropDownWareInc02);
            this.Controls.Add(this.dropDownWareInc01);
            this.Controls.Add(this.btnAddWareCancel);
            this.Controls.Add(this.btnAddWareAdd);
            this.Controls.Add(this.txtAddWareUnit);
            this.Controls.Add(this.txtAddWareCount);
            this.Controls.Add(this.txtAddWarePrice);
            this.Controls.Add(this.txtAddWareName);
            this.Controls.Add(this.lblAddWareTextUnit);
            this.Controls.Add(this.lblAddWareTextCount);
            this.Controls.Add(this.lblAddWareTextPrice);
            this.Controls.Add(this.lblAddWareTextName);
            this.Controls.Add(this.lblAddWareText);
            this.Controls.Add(this.btnCurrentInventoryDel);
            this.Controls.Add(this.btnCurrentInventoryAdd);
            this.Controls.Add(this.btnCurrentInventoryBack);
            this.Controls.Add(this.dataGridWares);
            this.Controls.Add(this.btnShipmentOut);
            this.Controls.Add(this.btnInventoryCurrent);
            this.Controls.Add(this.btnShipmentInc);
            this.Controls.Add(this.btnNewInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrame";
            this.Text = "Inventur";
            this.Load += new System.EventHandler(this.Mainframe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventurDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewInventory;
        private System.Windows.Forms.Button btnShipmentInc;
        private System.Windows.Forms.Button btnInventoryCurrent;
        private System.Windows.Forms.Button btnShipmentOut;
        private System.Windows.Forms.DataGridView dataGridWares;
        private inventurDataSet inventurDataSet;
        private System.Windows.Forms.BindingSource waresBindingSource;
        private inventurDataSetTableAdapters.waresTableAdapter waresTableAdapter;
        private System.Windows.Forms.Button btnCurrentInventoryBack;
        private System.Windows.Forms.Button btnCurrentInventoryAdd;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCurrentInventoryDel;
        private System.Windows.Forms.Label lblAddWareText;
        private System.Windows.Forms.Label lblAddWareTextName;
        private System.Windows.Forms.Label lblAddWareTextPrice;
        private System.Windows.Forms.Label lblAddWareTextCount;
        private System.Windows.Forms.Label lblAddWareTextUnit;
        private System.Windows.Forms.TextBox txtAddWareName;
        private System.Windows.Forms.TextBox txtAddWarePrice;
        private System.Windows.Forms.TextBox txtAddWareCount;
        private System.Windows.Forms.TextBox txtAddWareUnit;
        private System.Windows.Forms.Button btnAddWareAdd;
        private System.Windows.Forms.Button btnAddWareCancel;
        private System.Windows.Forms.ComboBox dropDownWareInc01;
        private System.Windows.Forms.ComboBox dropDownWareInc02;
        private System.Windows.Forms.ComboBox dropDownWareInc03;
        private System.Windows.Forms.ComboBox dropDownWareInc04;
        private System.Windows.Forms.ComboBox dropDownWareInc05;
        private System.Windows.Forms.TextBox txtWareInc01;
        private System.Windows.Forms.TextBox txtWareInc02;
        private System.Windows.Forms.TextBox txtWareInc03;
        private System.Windows.Forms.TextBox txtWareInc04;
        private System.Windows.Forms.TextBox txtWareInc05;
        private System.Windows.Forms.Button btnIncBack;
        private System.Windows.Forms.Button btnIncSend;
        private System.Windows.Forms.Label lblIncWare;
        private System.Windows.Forms.Label lblIncCount;
        private System.Windows.Forms.TextBox txtCurrentInventoryDelete;
        private System.Windows.Forms.Label lblCurrentInventoryDelete;
        private System.Windows.Forms.Label lblnewInvenReason;
        private System.Windows.Forms.Label lblNewInvenDate;
        private System.Windows.Forms.Label lblNewInvenLeader;
        private System.Windows.Forms.Label lblNewInvenAccount;
        private System.Windows.Forms.TextBox txtNewInvenDate;
        private System.Windows.Forms.TextBox txtNewInvenLeader;
        private System.Windows.Forms.RadioButton radioNewInvenYes;
        private System.Windows.Forms.RadioButton radioNewInvenNo;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox txtNewInvenAccount;
        private System.Windows.Forms.ComboBox comboNewInvenReason;
        private System.Windows.Forms.Button btnNewInvenOpen;
        private System.Windows.Forms.Button newInvenBtnCancel;
        private System.Windows.Forms.Label lblNewCountWareFixed;
        private System.Windows.Forms.Label lblNewCountWareCurrent;
        private System.Windows.Forms.Label lblNewCountCountFixed;
        private System.Windows.Forms.Label lblNewCountCountUpdating;
        private System.Windows.Forms.Button btnNewCountPlusOne;
        private System.Windows.Forms.Button btnNewCountPlusFive;
        private System.Windows.Forms.Button btnNewCountPlusTen;
        private System.Windows.Forms.Button btnNewCountPlusFifty;
        private System.Windows.Forms.Button btnNewCountSend;
        private System.Windows.Forms.Button btnNewCountMinusOne;
        private System.Windows.Forms.Button btnNewCountMinusTen;
    }
}

