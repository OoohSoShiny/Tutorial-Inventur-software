
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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventurDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewInventory
            // 
            this.btnNewInventory.Location = new System.Drawing.Point(12, 500);
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
            this.dataGridWares.AutoGenerateColumns = false;
            this.dataGridWares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridWares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.measureUnitDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridWares.DataSource = this.waresBindingSource;
            this.dataGridWares.Enabled = false;
            this.dataGridWares.Location = new System.Drawing.Point(448, 377);
            this.dataGridWares.Name = "dataGridWares";
            this.dataGridWares.Size = new System.Drawing.Size(170, 56);
            this.dataGridWares.TabIndex = 4;
            this.dataGridWares.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measureUnitDataGridViewTextBoxColumn
            // 
            this.measureUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasureUnit";
            this.measureUnitDataGridViewTextBoxColumn.HeaderText = "MeasureUnit";
            this.measureUnitDataGridViewTextBoxColumn.Name = "measureUnitDataGridViewTextBoxColumn";
            this.measureUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.btnCurrentInventoryBack.Location = new System.Drawing.Point(120, 471);
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
            this.btnCurrentInventoryAdd.Location = new System.Drawing.Point(251, 471);
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
            this.btnCurrentInventoryDel.Location = new System.Drawing.Point(374, 471);
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
            this.lblAddWareTextPrice.Location = new System.Drawing.Point(49, 447);
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
            this.txtAddWareName.Location = new System.Drawing.Point(16, 471);
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
            this.txtAddWareUnit.Location = new System.Drawing.Point(185, 410);
            this.txtAddWareUnit.Name = "txtAddWareUnit";
            this.txtAddWareUnit.Size = new System.Drawing.Size(100, 20);
            this.txtAddWareUnit.TabIndex = 16;
            this.txtAddWareUnit.Visible = false;
            // 
            // btnAddWareAdd
            // 
            this.btnAddWareAdd.Enabled = false;
            this.btnAddWareAdd.Location = new System.Drawing.Point(91, 410);
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
            this.btnAddWareCancel.Location = new System.Drawing.Point(4, 410);
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
            this.dropDownWareInc01.DataSource = this.waresBindingSource;
            this.dropDownWareInc01.DisplayMember = "Name";
            this.dropDownWareInc01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc01.Enabled = false;
            this.dropDownWareInc01.FormattingEnabled = true;
            this.dropDownWareInc01.Location = new System.Drawing.Point(12, 29);
            this.dropDownWareInc01.Name = "dropDownWareInc01";
            this.dropDownWareInc01.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc01.TabIndex = 19;
            this.dropDownWareInc01.Visible = false;
            // 
            // dropDownWareInc02
            // 
            this.dropDownWareInc02.DataSource = this.waresBindingSource;
            this.dropDownWareInc02.DisplayMember = "Name";
            this.dropDownWareInc02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc02.Enabled = false;
            this.dropDownWareInc02.FormattingEnabled = true;
            this.dropDownWareInc02.Location = new System.Drawing.Point(12, 56);
            this.dropDownWareInc02.Name = "dropDownWareInc02";
            this.dropDownWareInc02.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc02.TabIndex = 20;
            this.dropDownWareInc02.Visible = false;
            // 
            // dropDownWareInc03
            // 
            this.dropDownWareInc03.DataSource = this.waresBindingSource;
            this.dropDownWareInc03.DisplayMember = "Name";
            this.dropDownWareInc03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc03.Enabled = false;
            this.dropDownWareInc03.FormattingEnabled = true;
            this.dropDownWareInc03.Location = new System.Drawing.Point(12, 83);
            this.dropDownWareInc03.Name = "dropDownWareInc03";
            this.dropDownWareInc03.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc03.TabIndex = 21;
            this.dropDownWareInc03.Visible = false;
            // 
            // dropDownWareInc04
            // 
            this.dropDownWareInc04.DataSource = this.waresBindingSource;
            this.dropDownWareInc04.DisplayMember = "Name";
            this.dropDownWareInc04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc04.Enabled = false;
            this.dropDownWareInc04.FormattingEnabled = true;
            this.dropDownWareInc04.Location = new System.Drawing.Point(12, 110);
            this.dropDownWareInc04.Name = "dropDownWareInc04";
            this.dropDownWareInc04.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc04.TabIndex = 22;
            this.dropDownWareInc04.Visible = false;
            // 
            // dropDownWareInc05
            // 
            this.dropDownWareInc05.DataSource = this.waresBindingSource;
            this.dropDownWareInc05.DisplayMember = "Name";
            this.dropDownWareInc05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownWareInc05.Enabled = false;
            this.dropDownWareInc05.FormattingEnabled = true;
            this.dropDownWareInc05.Location = new System.Drawing.Point(12, 137);
            this.dropDownWareInc05.Name = "dropDownWareInc05";
            this.dropDownWareInc05.Size = new System.Drawing.Size(121, 21);
            this.dropDownWareInc05.TabIndex = 23;
            this.dropDownWareInc05.Visible = false;
            // 
            // txtWareInc01
            // 
            this.txtWareInc01.Enabled = false;
            this.txtWareInc01.Location = new System.Drawing.Point(139, 29);
            this.txtWareInc01.Name = "txtWareInc01";
            this.txtWareInc01.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc01.TabIndex = 24;
            this.txtWareInc01.Visible = false;
            // 
            // txtWareInc02
            // 
            this.txtWareInc02.Enabled = false;
            this.txtWareInc02.Location = new System.Drawing.Point(139, 57);
            this.txtWareInc02.Name = "txtWareInc02";
            this.txtWareInc02.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc02.TabIndex = 25;
            this.txtWareInc02.Visible = false;
            // 
            // txtWareInc03
            // 
            this.txtWareInc03.Enabled = false;
            this.txtWareInc03.Location = new System.Drawing.Point(139, 84);
            this.txtWareInc03.Name = "txtWareInc03";
            this.txtWareInc03.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc03.TabIndex = 26;
            this.txtWareInc03.Visible = false;
            // 
            // txtWareInc04
            // 
            this.txtWareInc04.Enabled = false;
            this.txtWareInc04.Location = new System.Drawing.Point(139, 111);
            this.txtWareInc04.Name = "txtWareInc04";
            this.txtWareInc04.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc04.TabIndex = 27;
            this.txtWareInc04.Visible = false;
            // 
            // txtWareInc05
            // 
            this.txtWareInc05.Enabled = false;
            this.txtWareInc05.Location = new System.Drawing.Point(139, 137);
            this.txtWareInc05.Name = "txtWareInc05";
            this.txtWareInc05.Size = new System.Drawing.Size(100, 20);
            this.txtWareInc05.TabIndex = 28;
            this.txtWareInc05.Visible = false;
            // 
            // btnIncBack
            // 
            this.btnIncBack.Enabled = false;
            this.btnIncBack.Location = new System.Drawing.Point(254, 29);
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
            this.btnIncSend.Location = new System.Drawing.Point(254, 134);
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
            this.lblIncWare.Location = new System.Drawing.Point(12, 9);
            this.lblIncWare.Name = "lblIncWare";
            this.lblIncWare.Size = new System.Drawing.Size(33, 13);
            this.lblIncWare.TabIndex = 31;
            this.lblIncWare.Text = "Ware";
            this.lblIncWare.Visible = false;
            // 
            // lblIncCount
            // 
            this.lblIncCount.AutoSize = true;
            this.lblIncCount.Location = new System.Drawing.Point(136, 9);
            this.lblIncCount.Name = "lblIncCount";
            this.lblIncCount.Size = new System.Drawing.Size(40, 13);
            this.lblIncCount.TabIndex = 32;
            this.lblIncCount.Text = "Menge";
            this.lblIncCount.Visible = false;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 547);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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
    }
}

