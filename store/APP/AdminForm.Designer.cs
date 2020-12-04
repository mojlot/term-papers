namespace APP
{
    partial class AdminForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.buttonSaveEmployee = new System.Windows.Forms.Button();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePK = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.pKemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kusachDataSet = new APP.kusachDataSet();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.textBoxCategoreTitle = new System.Windows.Forms.TextBox();
            this.textBoxCategoryID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pKcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageBrand = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRemoveBrand = new System.Windows.Forms.Button();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pKbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageManufact = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRemoveManufact = new System.Windows.Forms.Button();
            this.buttonAddManufact = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pKmanufactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.pKproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKmanufactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonRemoveStock = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.pKstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKdeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKproductsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageShop = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonRemoveShop = new System.Windows.Forms.Button();
            this.buttonAddShop = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.pKshopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageShift = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonRemoveShift = new System.Windows.Forms.Button();
            this.buttonAddShift = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.pKshiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKstoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageRoom = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.pKroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKstoreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageChek = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonRemoveChek = new System.Windows.Forms.Button();
            this.buttonAddChek = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.pKchekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKshopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saledateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageStore = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonRemoveStore = new System.Windows.Forms.Button();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.pKstoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKcashboxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCashbox = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonRemoveCashbox = new System.Windows.Forms.Button();
            this.buttonAddCashbox = new System.Windows.Forms.Button();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.pKcashboxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new APP.kusachDataSetTableAdapters.employeeTableAdapter();
            this.categoryTableAdapter = new APP.kusachDataSetTableAdapters.categoryTableAdapter();
            this.brandTableAdapter = new APP.kusachDataSetTableAdapters.brandTableAdapter();
            this.productsTableAdapter = new APP.kusachDataSetTableAdapters.productsTableAdapter();
            this.manufactTableAdapter = new APP.kusachDataSetTableAdapters.manufactTableAdapter();
            this.stockTableAdapter = new APP.kusachDataSetTableAdapters.stockTableAdapter();
            this.shopTableAdapter = new APP.kusachDataSetTableAdapters.shopTableAdapter();
            this.shiftTableAdapter = new APP.kusachDataSetTableAdapters.shiftTableAdapter();
            this.roomTableAdapter = new APP.kusachDataSetTableAdapters.roomTableAdapter();
            this.chekTableAdapter = new APP.kusachDataSetTableAdapters.chekTableAdapter();
            this.storeTableAdapter = new APP.kusachDataSetTableAdapters.storeTableAdapter();
            this.cashboxTableAdapter = new APP.kusachDataSetTableAdapters.cashboxTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kusachDataSet)).BeginInit();
            this.tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.tabPageBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.tabPageManufact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactBindingSource)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.tabPageStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.tabPageShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            this.tabPageShift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            this.tabPageRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.tabPageChek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekBindingSource)).BeginInit();
            this.tabPageStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.tabPageCashbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashboxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEmployee);
            this.tabControl.Controls.Add(this.tabPageCategory);
            this.tabControl.Controls.Add(this.tabPageBrand);
            this.tabControl.Controls.Add(this.tabPageManufact);
            this.tabControl.Controls.Add(this.tabPageProducts);
            this.tabControl.Controls.Add(this.tabPageStock);
            this.tabControl.Controls.Add(this.tabPageShop);
            this.tabControl.Controls.Add(this.tabPageShift);
            this.tabControl.Controls.Add(this.tabPageRoom);
            this.tabControl.Controls.Add(this.tabPageChek);
            this.tabControl.Controls.Add(this.tabPageStore);
            this.tabControl.Controls.Add(this.tabPageCashbox);
            this.tabControl.Location = new System.Drawing.Point(8, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1253, 648);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.AutoScroll = true;
            this.tabPageEmployee.Controls.Add(this.label2);
            this.tabPageEmployee.Controls.Add(this.label1);
            this.tabPageEmployee.Controls.Add(this.buttonRemoveEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonSaveEmployee);
            this.tabPageEmployee.Controls.Add(this.textBoxEmployeeName);
            this.tabPageEmployee.Controls.Add(this.textBoxEmployeePK);
            this.tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageEmployee.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(1245, 619);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Работники";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(810, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(810, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "PK(ID)";
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(1115, 6);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveEmployee.TabIndex = 4;
            this.buttonRemoveEmployee.Text = "Remove";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // buttonSaveEmployee
            // 
            this.buttonSaveEmployee.Location = new System.Drawing.Point(1115, 60);
            this.buttonSaveEmployee.Name = "buttonSaveEmployee";
            this.buttonSaveEmployee.Size = new System.Drawing.Size(121, 35);
            this.buttonSaveEmployee.TabIndex = 3;
            this.buttonSaveEmployee.Text = "Add";
            this.buttonSaveEmployee.UseVisualStyleBackColor = true;
            this.buttonSaveEmployee.Click += new System.EventHandler(this.buttonSaveEmployee_Click_1);
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(887, 61);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(222, 34);
            this.textBoxEmployeeName.TabIndex = 2;
            // 
            // textBoxEmployeePK
            // 
            this.textBoxEmployeePK.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmployeePK.Location = new System.Drawing.Point(887, 6);
            this.textBoxEmployeePK.Name = "textBoxEmployeePK";
            this.textBoxEmployeePK.Size = new System.Drawing.Size(222, 34);
            this.textBoxEmployeePK.TabIndex = 1;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKemployeeDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn});
            this.dataGridViewEmployee.DataSource = this.employeeBindingSource;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(798, 607);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // pKemployeeDataGridViewTextBoxColumn
            // 
            this.pKemployeeDataGridViewTextBoxColumn.DataPropertyName = "PK_employee";
            this.pKemployeeDataGridViewTextBoxColumn.HeaderText = "PK_employee";
            this.pKemployeeDataGridViewTextBoxColumn.Name = "pKemployeeDataGridViewTextBoxColumn";
            this.pKemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullnameDataGridViewTextBoxColumn.Width = 250;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.kusachDataSet;
            // 
            // kusachDataSet
            // 
            this.kusachDataSet.DataSetName = "kusachDataSet";
            this.kusachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.label3);
            this.tabPageCategory.Controls.Add(this.label4);
            this.tabPageCategory.Controls.Add(this.buttonRemoveCategory);
            this.tabPageCategory.Controls.Add(this.buttonAddCategory);
            this.tabPageCategory.Controls.Add(this.textBoxCategoreTitle);
            this.tabPageCategory.Controls.Add(this.textBoxCategoryID);
            this.tabPageCategory.Controls.Add(this.dataGridView1);
            this.tabPageCategory.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageCategory.Location = new System.Drawing.Point(4, 25);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(1245, 619);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Категория";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(813, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(813, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "PK(ID)";
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Location = new System.Drawing.Point(1118, 6);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveCategory.TabIndex = 10;
            this.buttonRemoveCategory.Text = "Remove";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click_1);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(1118, 60);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(121, 35);
            this.buttonAddCategory.TabIndex = 9;
            this.buttonAddCategory.Text = "Add";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click_1);
            // 
            // textBoxCategoreTitle
            // 
            this.textBoxCategoreTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategoreTitle.Location = new System.Drawing.Point(890, 61);
            this.textBoxCategoreTitle.Name = "textBoxCategoreTitle";
            this.textBoxCategoreTitle.Size = new System.Drawing.Size(222, 34);
            this.textBoxCategoreTitle.TabIndex = 8;
            // 
            // textBoxCategoryID
            // 
            this.textBoxCategoryID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCategoryID.Location = new System.Drawing.Point(890, 6);
            this.textBoxCategoryID.Name = "textBoxCategoryID";
            this.textBoxCategoryID.Size = new System.Drawing.Size(222, 34);
            this.textBoxCategoryID.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKcategoryDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 607);
            this.dataGridView1.TabIndex = 0;
            // 
            // pKcategoryDataGridViewTextBoxColumn
            // 
            this.pKcategoryDataGridViewTextBoxColumn.DataPropertyName = "PK_category";
            this.pKcategoryDataGridViewTextBoxColumn.HeaderText = "PK_category";
            this.pKcategoryDataGridViewTextBoxColumn.Name = "pKcategoryDataGridViewTextBoxColumn";
            this.pKcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageBrand
            // 
            this.tabPageBrand.Controls.Add(this.label5);
            this.tabPageBrand.Controls.Add(this.label6);
            this.tabPageBrand.Controls.Add(this.buttonRemoveBrand);
            this.tabPageBrand.Controls.Add(this.buttonAddBrand);
            this.tabPageBrand.Controls.Add(this.textBox3);
            this.tabPageBrand.Controls.Add(this.textBox4);
            this.tabPageBrand.Controls.Add(this.dataGridView2);
            this.tabPageBrand.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageBrand.Location = new System.Drawing.Point(4, 25);
            this.tabPageBrand.Name = "tabPageBrand";
            this.tabPageBrand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrand.Size = new System.Drawing.Size(1245, 619);
            this.tabPageBrand.TabIndex = 2;
            this.tabPageBrand.Text = "Бренд";
            this.tabPageBrand.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(810, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(810, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "PK(ID)";
            // 
            // buttonRemoveBrand
            // 
            this.buttonRemoveBrand.Location = new System.Drawing.Point(1115, 6);
            this.buttonRemoveBrand.Name = "buttonRemoveBrand";
            this.buttonRemoveBrand.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveBrand.TabIndex = 10;
            this.buttonRemoveBrand.Text = "Remove";
            this.buttonRemoveBrand.UseVisualStyleBackColor = true;
            this.buttonRemoveBrand.Click += new System.EventHandler(this.buttonRemoveBrand_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Location = new System.Drawing.Point(1115, 60);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(121, 35);
            this.buttonAddBrand.TabIndex = 9;
            this.buttonAddBrand.Text = "Add";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(887, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 34);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(887, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 34);
            this.textBox4.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKbrandDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.brandBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(798, 607);
            this.dataGridView2.TabIndex = 0;
            // 
            // pKbrandDataGridViewTextBoxColumn
            // 
            this.pKbrandDataGridViewTextBoxColumn.DataPropertyName = "PK_brand";
            this.pKbrandDataGridViewTextBoxColumn.HeaderText = "PK_brand";
            this.pKbrandDataGridViewTextBoxColumn.Name = "pKbrandDataGridViewTextBoxColumn";
            this.pKbrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageManufact
            // 
            this.tabPageManufact.Controls.Add(this.label7);
            this.tabPageManufact.Controls.Add(this.label8);
            this.tabPageManufact.Controls.Add(this.buttonRemoveManufact);
            this.tabPageManufact.Controls.Add(this.buttonAddManufact);
            this.tabPageManufact.Controls.Add(this.textBox5);
            this.tabPageManufact.Controls.Add(this.textBox6);
            this.tabPageManufact.Controls.Add(this.dataGridView3);
            this.tabPageManufact.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageManufact.Location = new System.Drawing.Point(4, 25);
            this.tabPageManufact.Name = "tabPageManufact";
            this.tabPageManufact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManufact.Size = new System.Drawing.Size(1245, 619);
            this.tabPageManufact.TabIndex = 3;
            this.tabPageManufact.Text = "Производство";
            this.tabPageManufact.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(805, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Addres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(810, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "PK(ID)";
            // 
            // buttonRemoveManufact
            // 
            this.buttonRemoveManufact.Location = new System.Drawing.Point(1115, 6);
            this.buttonRemoveManufact.Name = "buttonRemoveManufact";
            this.buttonRemoveManufact.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveManufact.TabIndex = 10;
            this.buttonRemoveManufact.Text = "Remove";
            this.buttonRemoveManufact.UseVisualStyleBackColor = true;
            this.buttonRemoveManufact.Click += new System.EventHandler(this.buttonRemoveManufact_Click);
            // 
            // buttonAddManufact
            // 
            this.buttonAddManufact.Location = new System.Drawing.Point(1115, 60);
            this.buttonAddManufact.Name = "buttonAddManufact";
            this.buttonAddManufact.Size = new System.Drawing.Size(121, 35);
            this.buttonAddManufact.TabIndex = 9;
            this.buttonAddManufact.Text = "Add";
            this.buttonAddManufact.UseVisualStyleBackColor = true;
            this.buttonAddManufact.Click += new System.EventHandler(this.buttonAddManufact_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(887, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 34);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(887, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(222, 34);
            this.textBox6.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKmanufactDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.manufactBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(793, 607);
            this.dataGridView3.TabIndex = 0;
            // 
            // pKmanufactDataGridViewTextBoxColumn
            // 
            this.pKmanufactDataGridViewTextBoxColumn.DataPropertyName = "PK_manufact";
            this.pKmanufactDataGridViewTextBoxColumn.HeaderText = "PK_manufact";
            this.pKmanufactDataGridViewTextBoxColumn.Name = "pKmanufactDataGridViewTextBoxColumn";
            this.pKmanufactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufactBindingSource
            // 
            this.manufactBindingSource.DataMember = "manufact";
            this.manufactBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.label27);
            this.tabPageProducts.Controls.Add(this.textBox25);
            this.tabPageProducts.Controls.Add(this.label26);
            this.tabPageProducts.Controls.Add(this.textBox24);
            this.tabPageProducts.Controls.Add(this.label25);
            this.tabPageProducts.Controls.Add(this.textBox23);
            this.tabPageProducts.Controls.Add(this.label9);
            this.tabPageProducts.Controls.Add(this.label10);
            this.tabPageProducts.Controls.Add(this.buttonRemoveProduct);
            this.tabPageProducts.Controls.Add(this.buttonAddProduct);
            this.tabPageProducts.Controls.Add(this.textBox7);
            this.tabPageProducts.Controls.Add(this.textBox8);
            this.tabPageProducts.Controls.Add(this.dataGridView4);
            this.tabPageProducts.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageProducts.Location = new System.Drawing.Point(4, 25);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(1245, 619);
            this.tabPageProducts.TabIndex = 4;
            this.tabPageProducts.Text = "Продукт";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(755, 164);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 29);
            this.label27.TabIndex = 18;
            this.label27.Text = "Price";
            // 
            // textBox25
            // 
            this.textBox25.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox25.Location = new System.Drawing.Point(891, 164);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(222, 34);
            this.textBox25.TabIndex = 17;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(755, 124);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(130, 29);
            this.label26.TabIndex = 16;
            this.label26.Text = "FK_manufact";
            // 
            // textBox24
            // 
            this.textBox24.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox24.Location = new System.Drawing.Point(891, 124);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(222, 34);
            this.textBox24.TabIndex = 15;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(755, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 29);
            this.label25.TabIndex = 14;
            this.label25.Text = "FK_brand";
            // 
            // textBox23
            // 
            this.textBox23.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox23.Location = new System.Drawing.Point(891, 84);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(222, 34);
            this.textBox23.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(755, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "FK_category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(755, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "PK(ID)";
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(1119, 6);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveProduct.TabIndex = 10;
            this.buttonRemoveProduct.Text = "Remove";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(1119, 43);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(121, 35);
            this.buttonAddProduct.TabIndex = 9;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(891, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(222, 34);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(891, 6);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(222, 34);
            this.textBox8.TabIndex = 7;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKproductDataGridViewTextBoxColumn,
            this.fKcategoryDataGridViewTextBoxColumn,
            this.fKbrandDataGridViewTextBoxColumn,
            this.fKmanufactDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.productsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(743, 607);
            this.dataGridView4.TabIndex = 0;
            // 
            // pKproductDataGridViewTextBoxColumn
            // 
            this.pKproductDataGridViewTextBoxColumn.DataPropertyName = "PK_product";
            this.pKproductDataGridViewTextBoxColumn.HeaderText = "PK_product";
            this.pKproductDataGridViewTextBoxColumn.Name = "pKproductDataGridViewTextBoxColumn";
            this.pKproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKcategoryDataGridViewTextBoxColumn
            // 
            this.fKcategoryDataGridViewTextBoxColumn.DataPropertyName = "FK_category";
            this.fKcategoryDataGridViewTextBoxColumn.HeaderText = "FK_category";
            this.fKcategoryDataGridViewTextBoxColumn.Name = "fKcategoryDataGridViewTextBoxColumn";
            this.fKcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKbrandDataGridViewTextBoxColumn
            // 
            this.fKbrandDataGridViewTextBoxColumn.DataPropertyName = "FK_brand";
            this.fKbrandDataGridViewTextBoxColumn.HeaderText = "FK_brand";
            this.fKbrandDataGridViewTextBoxColumn.Name = "fKbrandDataGridViewTextBoxColumn";
            this.fKbrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKmanufactDataGridViewTextBoxColumn
            // 
            this.fKmanufactDataGridViewTextBoxColumn.DataPropertyName = "FK_manufact";
            this.fKmanufactDataGridViewTextBoxColumn.HeaderText = "FK_manufact";
            this.fKmanufactDataGridViewTextBoxColumn.Name = "fKmanufactDataGridViewTextBoxColumn";
            this.fKmanufactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Controls.Add(this.label30);
            this.tabPageStock.Controls.Add(this.textBox28);
            this.tabPageStock.Controls.Add(this.label29);
            this.tabPageStock.Controls.Add(this.textBox27);
            this.tabPageStock.Controls.Add(this.label28);
            this.tabPageStock.Controls.Add(this.textBox26);
            this.tabPageStock.Controls.Add(this.label11);
            this.tabPageStock.Controls.Add(this.label12);
            this.tabPageStock.Controls.Add(this.buttonRemoveStock);
            this.tabPageStock.Controls.Add(this.buttonAddStock);
            this.tabPageStock.Controls.Add(this.textBox9);
            this.tabPageStock.Controls.Add(this.textBox10);
            this.tabPageStock.Controls.Add(this.dataGridView5);
            this.tabPageStock.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageStock.Location = new System.Drawing.Point(4, 25);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStock.Size = new System.Drawing.Size(1245, 619);
            this.tabPageStock.TabIndex = 5;
            this.tabPageStock.Text = "Склад";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(758, 186);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(56, 29);
            this.label30.TabIndex = 18;
            this.label30.Text = "price";
            // 
            // textBox28
            // 
            this.textBox28.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox28.Location = new System.Drawing.Point(889, 181);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(222, 34);
            this.textBox28.TabIndex = 17;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(758, 146);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 29);
            this.label29.TabIndex = 16;
            this.label29.Text = "amount";
            // 
            // textBox27
            // 
            this.textBox27.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox27.Location = new System.Drawing.Point(889, 141);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(222, 34);
            this.textBox27.TabIndex = 15;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(758, 106);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(125, 29);
            this.label28.TabIndex = 14;
            this.label28.Text = "FK_products";
            // 
            // textBox26
            // 
            this.textBox26.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox26.Location = new System.Drawing.Point(889, 101);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(222, 34);
            this.textBox26.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(758, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "FK_delivery";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(758, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 29);
            this.label12.TabIndex = 11;
            this.label12.Text = "PK(ID)";
            // 
            // buttonRemoveStock
            // 
            this.buttonRemoveStock.Location = new System.Drawing.Point(1117, 6);
            this.buttonRemoveStock.Name = "buttonRemoveStock";
            this.buttonRemoveStock.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveStock.TabIndex = 10;
            this.buttonRemoveStock.Text = "Remove";
            this.buttonRemoveStock.UseVisualStyleBackColor = true;
            this.buttonRemoveStock.Click += new System.EventHandler(this.buttonRemoveStock_Click);
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Location = new System.Drawing.Point(1117, 60);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(121, 35);
            this.buttonAddStock.TabIndex = 9;
            this.buttonAddStock.Text = "Add";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(889, 61);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(222, 34);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(889, 6);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(222, 34);
            this.textBox10.TabIndex = 7;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKstockDataGridViewTextBoxColumn,
            this.fKdeliveryDataGridViewTextBoxColumn,
            this.fKproductsDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.stockBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(746, 607);
            this.dataGridView5.TabIndex = 0;
            // 
            // pKstockDataGridViewTextBoxColumn
            // 
            this.pKstockDataGridViewTextBoxColumn.DataPropertyName = "PK_stock";
            this.pKstockDataGridViewTextBoxColumn.HeaderText = "PK_stock";
            this.pKstockDataGridViewTextBoxColumn.Name = "pKstockDataGridViewTextBoxColumn";
            this.pKstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKdeliveryDataGridViewTextBoxColumn
            // 
            this.fKdeliveryDataGridViewTextBoxColumn.DataPropertyName = "FK_delivery";
            this.fKdeliveryDataGridViewTextBoxColumn.HeaderText = "FK_delivery";
            this.fKdeliveryDataGridViewTextBoxColumn.Name = "fKdeliveryDataGridViewTextBoxColumn";
            this.fKdeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKproductsDataGridViewTextBoxColumn
            // 
            this.fKproductsDataGridViewTextBoxColumn.DataPropertyName = "FK_products";
            this.fKproductsDataGridViewTextBoxColumn.HeaderText = "FK_products";
            this.fKproductsDataGridViewTextBoxColumn.Name = "fKproductsDataGridViewTextBoxColumn";
            this.fKproductsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "stock";
            this.stockBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageShop
            // 
            this.tabPageShop.Controls.Add(this.label32);
            this.tabPageShop.Controls.Add(this.textBox30);
            this.tabPageShop.Controls.Add(this.label31);
            this.tabPageShop.Controls.Add(this.textBox29);
            this.tabPageShop.Controls.Add(this.label13);
            this.tabPageShop.Controls.Add(this.label14);
            this.tabPageShop.Controls.Add(this.buttonRemoveShop);
            this.tabPageShop.Controls.Add(this.buttonAddShop);
            this.tabPageShop.Controls.Add(this.textBox11);
            this.tabPageShop.Controls.Add(this.textBox12);
            this.tabPageShop.Controls.Add(this.dataGridView6);
            this.tabPageShop.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageShop.Location = new System.Drawing.Point(4, 25);
            this.tabPageShop.Name = "tabPageShop";
            this.tabPageShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShop.Size = new System.Drawing.Size(1245, 619);
            this.tabPageShop.TabIndex = 6;
            this.tabPageShop.Text = "Склад Магазина";
            this.tabPageShop.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(790, 141);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(78, 29);
            this.label32.TabIndex = 16;
            this.label32.Text = "amount";
            // 
            // textBox30
            // 
            this.textBox30.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox30.Location = new System.Drawing.Point(890, 141);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(222, 34);
            this.textBox30.TabIndex = 15;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(790, 101);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(94, 29);
            this.label31.TabIndex = 14;
            this.label31.Text = "FK_room";
            // 
            // textBox29
            // 
            this.textBox29.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox29.Location = new System.Drawing.Point(890, 101);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(222, 34);
            this.textBox29.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(790, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 29);
            this.label13.TabIndex = 12;
            this.label13.Text = "FK_stock";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(813, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 29);
            this.label14.TabIndex = 11;
            this.label14.Text = "PK(ID)";
            // 
            // buttonRemoveShop
            // 
            this.buttonRemoveShop.Location = new System.Drawing.Point(1118, 6);
            this.buttonRemoveShop.Name = "buttonRemoveShop";
            this.buttonRemoveShop.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveShop.TabIndex = 10;
            this.buttonRemoveShop.Text = "Remove";
            this.buttonRemoveShop.UseVisualStyleBackColor = true;
            this.buttonRemoveShop.Click += new System.EventHandler(this.buttonRemoveShop_Click);
            // 
            // buttonAddShop
            // 
            this.buttonAddShop.Location = new System.Drawing.Point(1118, 60);
            this.buttonAddShop.Name = "buttonAddShop";
            this.buttonAddShop.Size = new System.Drawing.Size(121, 35);
            this.buttonAddShop.TabIndex = 9;
            this.buttonAddShop.Text = "Add";
            this.buttonAddShop.UseVisualStyleBackColor = true;
            this.buttonAddShop.Click += new System.EventHandler(this.buttonAddShop_Click);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(890, 61);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(222, 34);
            this.textBox11.TabIndex = 8;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12.Location = new System.Drawing.Point(890, 6);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(222, 34);
            this.textBox12.TabIndex = 7;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKshopDataGridViewTextBoxColumn,
            this.fKstockDataGridViewTextBoxColumn,
            this.fKroomDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1});
            this.dataGridView6.DataSource = this.shopBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(6, 6);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(778, 607);
            this.dataGridView6.TabIndex = 0;
            // 
            // pKshopDataGridViewTextBoxColumn
            // 
            this.pKshopDataGridViewTextBoxColumn.DataPropertyName = "PK_shop";
            this.pKshopDataGridViewTextBoxColumn.HeaderText = "PK_shop";
            this.pKshopDataGridViewTextBoxColumn.Name = "pKshopDataGridViewTextBoxColumn";
            this.pKshopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKstockDataGridViewTextBoxColumn
            // 
            this.fKstockDataGridViewTextBoxColumn.DataPropertyName = "FK_stock";
            this.fKstockDataGridViewTextBoxColumn.HeaderText = "FK_stock";
            this.fKstockDataGridViewTextBoxColumn.Name = "fKstockDataGridViewTextBoxColumn";
            this.fKstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKroomDataGridViewTextBoxColumn
            // 
            this.fKroomDataGridViewTextBoxColumn.DataPropertyName = "FK_room";
            this.fKroomDataGridViewTextBoxColumn.HeaderText = "FK_room";
            this.fKroomDataGridViewTextBoxColumn.Name = "fKroomDataGridViewTextBoxColumn";
            this.fKroomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "shop";
            this.shopBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageShift
            // 
            this.tabPageShift.Controls.Add(this.label33);
            this.tabPageShift.Controls.Add(this.textBox31);
            this.tabPageShift.Controls.Add(this.label15);
            this.tabPageShift.Controls.Add(this.label16);
            this.tabPageShift.Controls.Add(this.buttonRemoveShift);
            this.tabPageShift.Controls.Add(this.buttonAddShift);
            this.tabPageShift.Controls.Add(this.textBox13);
            this.tabPageShift.Controls.Add(this.textBox14);
            this.tabPageShift.Controls.Add(this.dataGridView7);
            this.tabPageShift.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageShift.Location = new System.Drawing.Point(4, 25);
            this.tabPageShift.Name = "tabPageShift";
            this.tabPageShift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShift.Size = new System.Drawing.Size(1245, 619);
            this.tabPageShift.TabIndex = 7;
            this.tabPageShift.Text = "Смена";
            this.tabPageShift.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(751, 101);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 29);
            this.label33.TabIndex = 14;
            this.label33.Text = "FK_employee";
            // 
            // textBox31
            // 
            this.textBox31.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox31.Location = new System.Drawing.Point(890, 101);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(222, 34);
            this.textBox31.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(751, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 29);
            this.label15.TabIndex = 12;
            this.label15.Text = "FK_store";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(813, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 29);
            this.label16.TabIndex = 11;
            this.label16.Text = "PK(ID)";
            // 
            // buttonRemoveShift
            // 
            this.buttonRemoveShift.Location = new System.Drawing.Point(1118, 6);
            this.buttonRemoveShift.Name = "buttonRemoveShift";
            this.buttonRemoveShift.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveShift.TabIndex = 10;
            this.buttonRemoveShift.Text = "Remove";
            this.buttonRemoveShift.UseVisualStyleBackColor = true;
            this.buttonRemoveShift.Click += new System.EventHandler(this.buttonRemoveShift_Click);
            // 
            // buttonAddShift
            // 
            this.buttonAddShift.Location = new System.Drawing.Point(1118, 60);
            this.buttonAddShift.Name = "buttonAddShift";
            this.buttonAddShift.Size = new System.Drawing.Size(121, 35);
            this.buttonAddShift.TabIndex = 9;
            this.buttonAddShift.Text = "Add";
            this.buttonAddShift.UseVisualStyleBackColor = true;
            this.buttonAddShift.Click += new System.EventHandler(this.buttonAddShift_Click);
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(890, 61);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(222, 34);
            this.textBox13.TabIndex = 8;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox14.Location = new System.Drawing.Point(890, 6);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(222, 34);
            this.textBox14.TabIndex = 7;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKshiftDataGridViewTextBoxColumn,
            this.fKstoreDataGridViewTextBoxColumn,
            this.fKemployeeDataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.shiftBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(6, 6);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(739, 607);
            this.dataGridView7.TabIndex = 0;
            // 
            // pKshiftDataGridViewTextBoxColumn
            // 
            this.pKshiftDataGridViewTextBoxColumn.DataPropertyName = "PK_shift";
            this.pKshiftDataGridViewTextBoxColumn.HeaderText = "PK_shift";
            this.pKshiftDataGridViewTextBoxColumn.Name = "pKshiftDataGridViewTextBoxColumn";
            this.pKshiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKstoreDataGridViewTextBoxColumn
            // 
            this.fKstoreDataGridViewTextBoxColumn.DataPropertyName = "FK_store";
            this.fKstoreDataGridViewTextBoxColumn.HeaderText = "FK_store";
            this.fKstoreDataGridViewTextBoxColumn.Name = "fKstoreDataGridViewTextBoxColumn";
            this.fKstoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKemployeeDataGridViewTextBoxColumn
            // 
            this.fKemployeeDataGridViewTextBoxColumn.DataPropertyName = "FK_employee";
            this.fKemployeeDataGridViewTextBoxColumn.HeaderText = "FK_employee";
            this.fKemployeeDataGridViewTextBoxColumn.Name = "fKemployeeDataGridViewTextBoxColumn";
            this.fKemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataMember = "shift";
            this.shiftBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Controls.Add(this.label17);
            this.tabPageRoom.Controls.Add(this.label18);
            this.tabPageRoom.Controls.Add(this.buttonRemoveRoom);
            this.tabPageRoom.Controls.Add(this.buttonAddRoom);
            this.tabPageRoom.Controls.Add(this.textBox15);
            this.tabPageRoom.Controls.Add(this.textBox16);
            this.tabPageRoom.Controls.Add(this.dataGridView8);
            this.tabPageRoom.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageRoom.Location = new System.Drawing.Point(4, 25);
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoom.Size = new System.Drawing.Size(1245, 619);
            this.tabPageRoom.TabIndex = 8;
            this.tabPageRoom.Text = "Торговый Зал";
            this.tabPageRoom.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(791, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 29);
            this.label17.TabIndex = 12;
            this.label17.Text = "FK_store";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(813, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 29);
            this.label18.TabIndex = 11;
            this.label18.Text = "PK(ID)";
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.Location = new System.Drawing.Point(1118, 6);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveRoom.TabIndex = 10;
            this.buttonRemoveRoom.Text = "Remove";
            this.buttonRemoveRoom.UseVisualStyleBackColor = true;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(1118, 60);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(121, 35);
            this.buttonAddRoom.TabIndex = 9;
            this.buttonAddRoom.Text = "Add";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox15.Location = new System.Drawing.Point(890, 61);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(222, 34);
            this.textBox15.TabIndex = 8;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox16.Location = new System.Drawing.Point(890, 6);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(222, 34);
            this.textBox16.TabIndex = 7;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.AllowUserToDeleteRows = false;
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKroomDataGridViewTextBoxColumn,
            this.fKstoreDataGridViewTextBoxColumn1});
            this.dataGridView8.DataSource = this.roomBindingSource;
            this.dataGridView8.Location = new System.Drawing.Point(6, 6);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.RowTemplate.Height = 24;
            this.dataGridView8.Size = new System.Drawing.Size(779, 607);
            this.dataGridView8.TabIndex = 0;
            // 
            // pKroomDataGridViewTextBoxColumn
            // 
            this.pKroomDataGridViewTextBoxColumn.DataPropertyName = "PK_room";
            this.pKroomDataGridViewTextBoxColumn.HeaderText = "PK_room";
            this.pKroomDataGridViewTextBoxColumn.Name = "pKroomDataGridViewTextBoxColumn";
            this.pKroomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKstoreDataGridViewTextBoxColumn1
            // 
            this.fKstoreDataGridViewTextBoxColumn1.DataPropertyName = "FK_store";
            this.fKstoreDataGridViewTextBoxColumn1.HeaderText = "FK_store";
            this.fKstoreDataGridViewTextBoxColumn1.Name = "fKstoreDataGridViewTextBoxColumn1";
            this.fKstoreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "room";
            this.roomBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageChek
            // 
            this.tabPageChek.Controls.Add(this.label34);
            this.tabPageChek.Controls.Add(this.textBox32);
            this.tabPageChek.Controls.Add(this.label19);
            this.tabPageChek.Controls.Add(this.label20);
            this.tabPageChek.Controls.Add(this.buttonRemoveChek);
            this.tabPageChek.Controls.Add(this.buttonAddChek);
            this.tabPageChek.Controls.Add(this.textBox17);
            this.tabPageChek.Controls.Add(this.textBox18);
            this.tabPageChek.Controls.Add(this.dataGridView9);
            this.tabPageChek.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageChek.Location = new System.Drawing.Point(4, 25);
            this.tabPageChek.Name = "tabPageChek";
            this.tabPageChek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChek.Size = new System.Drawing.Size(1245, 619);
            this.tabPageChek.TabIndex = 9;
            this.tabPageChek.Text = "Чек";
            this.tabPageChek.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(793, 101);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 29);
            this.label34.TabIndex = 14;
            this.label34.Text = "sale date";
            // 
            // textBox32
            // 
            this.textBox32.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox32.Location = new System.Drawing.Point(891, 101);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(222, 34);
            this.textBox32.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(793, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 29);
            this.label19.TabIndex = 12;
            this.label19.Text = "FK_shop";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(814, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 29);
            this.label20.TabIndex = 11;
            this.label20.Text = "PK(ID)";
            // 
            // buttonRemoveChek
            // 
            this.buttonRemoveChek.Location = new System.Drawing.Point(1119, 6);
            this.buttonRemoveChek.Name = "buttonRemoveChek";
            this.buttonRemoveChek.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveChek.TabIndex = 10;
            this.buttonRemoveChek.Text = "Remove";
            this.buttonRemoveChek.UseVisualStyleBackColor = true;
            this.buttonRemoveChek.Click += new System.EventHandler(this.buttonRemoveChek_Click);
            // 
            // buttonAddChek
            // 
            this.buttonAddChek.Location = new System.Drawing.Point(1119, 60);
            this.buttonAddChek.Name = "buttonAddChek";
            this.buttonAddChek.Size = new System.Drawing.Size(121, 35);
            this.buttonAddChek.TabIndex = 9;
            this.buttonAddChek.Text = "Add";
            this.buttonAddChek.UseVisualStyleBackColor = true;
            this.buttonAddChek.Click += new System.EventHandler(this.buttonAddChek_Click);
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox17.Location = new System.Drawing.Point(891, 61);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(222, 34);
            this.textBox17.TabIndex = 8;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox18.Location = new System.Drawing.Point(891, 6);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(222, 34);
            this.textBox18.TabIndex = 7;
            // 
            // dataGridView9
            // 
            this.dataGridView9.AllowUserToAddRows = false;
            this.dataGridView9.AllowUserToDeleteRows = false;
            this.dataGridView9.AutoGenerateColumns = false;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKchekDataGridViewTextBoxColumn,
            this.fKshopDataGridViewTextBoxColumn,
            this.saledateDataGridViewTextBoxColumn});
            this.dataGridView9.DataSource = this.chekBindingSource;
            this.dataGridView9.Location = new System.Drawing.Point(6, 6);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.ReadOnly = true;
            this.dataGridView9.RowTemplate.Height = 24;
            this.dataGridView9.Size = new System.Drawing.Size(781, 607);
            this.dataGridView9.TabIndex = 0;
            // 
            // pKchekDataGridViewTextBoxColumn
            // 
            this.pKchekDataGridViewTextBoxColumn.DataPropertyName = "PK_chek";
            this.pKchekDataGridViewTextBoxColumn.HeaderText = "PK_chek";
            this.pKchekDataGridViewTextBoxColumn.Name = "pKchekDataGridViewTextBoxColumn";
            this.pKchekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKshopDataGridViewTextBoxColumn
            // 
            this.fKshopDataGridViewTextBoxColumn.DataPropertyName = "FK_shop";
            this.fKshopDataGridViewTextBoxColumn.HeaderText = "FK_shop";
            this.fKshopDataGridViewTextBoxColumn.Name = "fKshopDataGridViewTextBoxColumn";
            this.fKshopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saledateDataGridViewTextBoxColumn
            // 
            this.saledateDataGridViewTextBoxColumn.DataPropertyName = "sale_date";
            this.saledateDataGridViewTextBoxColumn.HeaderText = "sale_date";
            this.saledateDataGridViewTextBoxColumn.Name = "saledateDataGridViewTextBoxColumn";
            this.saledateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chekBindingSource
            // 
            this.chekBindingSource.DataMember = "chek";
            this.chekBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageStore
            // 
            this.tabPageStore.Controls.Add(this.label36);
            this.tabPageStore.Controls.Add(this.textBox34);
            this.tabPageStore.Controls.Add(this.label35);
            this.tabPageStore.Controls.Add(this.textBox33);
            this.tabPageStore.Controls.Add(this.label21);
            this.tabPageStore.Controls.Add(this.label22);
            this.tabPageStore.Controls.Add(this.buttonRemoveStore);
            this.tabPageStore.Controls.Add(this.buttonAddStore);
            this.tabPageStore.Controls.Add(this.textBox19);
            this.tabPageStore.Controls.Add(this.textBox20);
            this.tabPageStore.Controls.Add(this.dataGridView10);
            this.tabPageStore.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageStore.Location = new System.Drawing.Point(4, 25);
            this.tabPageStore.Name = "tabPageStore";
            this.tabPageStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStore.Size = new System.Drawing.Size(1245, 619);
            this.tabPageStore.TabIndex = 10;
            this.tabPageStore.Text = "Магазин";
            this.tabPageStore.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(761, 142);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(76, 29);
            this.label36.TabIndex = 16;
            this.label36.Text = "Addres";
            // 
            // textBox34
            // 
            this.textBox34.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox34.Location = new System.Drawing.Point(890, 141);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(222, 34);
            this.textBox34.TabIndex = 15;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(761, 102);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 29);
            this.label35.TabIndex = 14;
            this.label35.Text = "title";
            // 
            // textBox33
            // 
            this.textBox33.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox33.Location = new System.Drawing.Point(890, 101);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(222, 34);
            this.textBox33.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(761, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 29);
            this.label21.TabIndex = 12;
            this.label21.Text = "FK_cashbox";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(813, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 29);
            this.label22.TabIndex = 11;
            this.label22.Text = "PK(ID)";
            // 
            // buttonRemoveStore
            // 
            this.buttonRemoveStore.Location = new System.Drawing.Point(1118, 6);
            this.buttonRemoveStore.Name = "buttonRemoveStore";
            this.buttonRemoveStore.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveStore.TabIndex = 10;
            this.buttonRemoveStore.Text = "Remove";
            this.buttonRemoveStore.UseVisualStyleBackColor = true;
            this.buttonRemoveStore.Click += new System.EventHandler(this.buttonRemoveStore_Click);
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.Location = new System.Drawing.Point(1118, 60);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(121, 35);
            this.buttonAddStore.TabIndex = 9;
            this.buttonAddStore.Text = "Add";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox19.Location = new System.Drawing.Point(890, 61);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(222, 34);
            this.textBox19.TabIndex = 8;
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox20.Location = new System.Drawing.Point(890, 6);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(222, 34);
            this.textBox20.TabIndex = 7;
            // 
            // dataGridView10
            // 
            this.dataGridView10.AllowUserToAddRows = false;
            this.dataGridView10.AllowUserToDeleteRows = false;
            this.dataGridView10.AutoGenerateColumns = false;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKstoreDataGridViewTextBoxColumn,
            this.fKcashboxDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn2,
            this.addresDataGridViewTextBoxColumn});
            this.dataGridView10.DataSource = this.storeBindingSource;
            this.dataGridView10.Location = new System.Drawing.Point(6, 6);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.ReadOnly = true;
            this.dataGridView10.RowTemplate.Height = 24;
            this.dataGridView10.Size = new System.Drawing.Size(749, 607);
            this.dataGridView10.TabIndex = 0;
            // 
            // pKstoreDataGridViewTextBoxColumn
            // 
            this.pKstoreDataGridViewTextBoxColumn.DataPropertyName = "PK_store";
            this.pKstoreDataGridViewTextBoxColumn.HeaderText = "PK_store";
            this.pKstoreDataGridViewTextBoxColumn.Name = "pKstoreDataGridViewTextBoxColumn";
            this.pKstoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKcashboxDataGridViewTextBoxColumn
            // 
            this.fKcashboxDataGridViewTextBoxColumn.DataPropertyName = "FK_cashbox";
            this.fKcashboxDataGridViewTextBoxColumn.HeaderText = "FK_cashbox";
            this.fKcashboxDataGridViewTextBoxColumn.Name = "fKcashboxDataGridViewTextBoxColumn";
            this.fKcashboxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "addres";
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            this.addresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "store";
            this.storeBindingSource.DataSource = this.kusachDataSet;
            // 
            // tabPageCashbox
            // 
            this.tabPageCashbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageCashbox.Controls.Add(this.label23);
            this.tabPageCashbox.Controls.Add(this.label24);
            this.tabPageCashbox.Controls.Add(this.buttonRemoveCashbox);
            this.tabPageCashbox.Controls.Add(this.buttonAddCashbox);
            this.tabPageCashbox.Controls.Add(this.textBox21);
            this.tabPageCashbox.Controls.Add(this.textBox22);
            this.tabPageCashbox.Controls.Add(this.dataGridView11);
            this.tabPageCashbox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageCashbox.Location = new System.Drawing.Point(4, 25);
            this.tabPageCashbox.Name = "tabPageCashbox";
            this.tabPageCashbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCashbox.Size = new System.Drawing.Size(1245, 619);
            this.tabPageCashbox.TabIndex = 11;
            this.tabPageCashbox.Text = "К.С.А.";
            this.tabPageCashbox.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(812, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 29);
            this.label23.TabIndex = 12;
            this.label23.Text = "Limit";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(812, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 29);
            this.label24.TabIndex = 11;
            this.label24.Text = "PK(ID)";
            // 
            // buttonRemoveCashbox
            // 
            this.buttonRemoveCashbox.Location = new System.Drawing.Point(1117, 6);
            this.buttonRemoveCashbox.Name = "buttonRemoveCashbox";
            this.buttonRemoveCashbox.Size = new System.Drawing.Size(121, 34);
            this.buttonRemoveCashbox.TabIndex = 10;
            this.buttonRemoveCashbox.Text = "Remove";
            this.buttonRemoveCashbox.UseVisualStyleBackColor = true;
            this.buttonRemoveCashbox.Click += new System.EventHandler(this.buttonRemoveCashbox_Click);
            // 
            // buttonAddCashbox
            // 
            this.buttonAddCashbox.Location = new System.Drawing.Point(1117, 60);
            this.buttonAddCashbox.Name = "buttonAddCashbox";
            this.buttonAddCashbox.Size = new System.Drawing.Size(121, 35);
            this.buttonAddCashbox.TabIndex = 9;
            this.buttonAddCashbox.Text = "Add";
            this.buttonAddCashbox.UseVisualStyleBackColor = true;
            this.buttonAddCashbox.Click += new System.EventHandler(this.buttonAddCashbox_Click);
            // 
            // textBox21
            // 
            this.textBox21.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox21.Location = new System.Drawing.Point(889, 61);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(222, 34);
            this.textBox21.TabIndex = 8;
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox22.Location = new System.Drawing.Point(889, 6);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(222, 34);
            this.textBox22.TabIndex = 7;
            // 
            // dataGridView11
            // 
            this.dataGridView11.AllowUserToAddRows = false;
            this.dataGridView11.AllowUserToDeleteRows = false;
            this.dataGridView11.AutoGenerateColumns = false;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKcashboxDataGridViewTextBoxColumn,
            this.limitDataGridViewTextBoxColumn});
            this.dataGridView11.DataSource = this.cashboxBindingSource;
            this.dataGridView11.Location = new System.Drawing.Point(6, 6);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.ReadOnly = true;
            this.dataGridView11.RowTemplate.Height = 24;
            this.dataGridView11.Size = new System.Drawing.Size(800, 603);
            this.dataGridView11.TabIndex = 0;
            // 
            // pKcashboxDataGridViewTextBoxColumn
            // 
            this.pKcashboxDataGridViewTextBoxColumn.DataPropertyName = "PK_cashbox";
            this.pKcashboxDataGridViewTextBoxColumn.HeaderText = "PK_cashbox";
            this.pKcashboxDataGridViewTextBoxColumn.Name = "pKcashboxDataGridViewTextBoxColumn";
            this.pKcashboxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // limitDataGridViewTextBoxColumn
            // 
            this.limitDataGridViewTextBoxColumn.DataPropertyName = "limit";
            this.limitDataGridViewTextBoxColumn.HeaderText = "limit";
            this.limitDataGridViewTextBoxColumn.Name = "limitDataGridViewTextBoxColumn";
            this.limitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashboxBindingSource
            // 
            this.cashboxBindingSource.DataMember = "cashbox";
            this.cashboxBindingSource.DataSource = this.kusachDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // manufactTableAdapter
            // 
            this.manufactTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // shiftTableAdapter
            // 
            this.shiftTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // chekTableAdapter
            // 
            this.chekTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // cashboxTableAdapter
            // 
            this.cashboxTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kusachDataSet)).EndInit();
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.tabPageBrand.ResumeLayout(false);
            this.tabPageBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.tabPageManufact.ResumeLayout(false);
            this.tabPageManufact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactBindingSource)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.tabPageStock.ResumeLayout(false);
            this.tabPageStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.tabPageShop.ResumeLayout(false);
            this.tabPageShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            this.tabPageShift.ResumeLayout(false);
            this.tabPageShift.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            this.tabPageRoom.ResumeLayout(false);
            this.tabPageRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.tabPageChek.ResumeLayout(false);
            this.tabPageChek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chekBindingSource)).EndInit();
            this.tabPageStore.ResumeLayout(false);
            this.tabPageStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.tabPageCashbox.ResumeLayout(false);
            this.tabPageCashbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashboxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TabPage tabPageBrand;
        private System.Windows.Forms.TabPage tabPageManufact;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.TabPage tabPageShop;
        private System.Windows.Forms.TabPage tabPageShift;
        private System.Windows.Forms.TabPage tabPageRoom;
        private System.Windows.Forms.TabPage tabPageChek;
        private System.Windows.Forms.TabPage tabPageStore;
        private System.Windows.Forms.TabPage tabPageCashbox;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeePK;
        private kusachDataSet kusachDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private kusachDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSaveEmployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private kusachDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private kusachDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private kusachDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource manufactBindingSource;
        private kusachDataSetTableAdapters.manufactTableAdapter manufactTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKmanufactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKmanufactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private kusachDataSetTableAdapters.stockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKdeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKproductsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private kusachDataSetTableAdapters.shopTableAdapter shopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKshopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.BindingSource shiftBindingSource;
        private kusachDataSetTableAdapters.shiftTableAdapter shiftTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKshiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKstoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private kusachDataSetTableAdapters.roomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKstoreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.BindingSource chekBindingSource;
        private kusachDataSetTableAdapters.chekTableAdapter chekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKchekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKshopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saledateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private kusachDataSetTableAdapters.storeTableAdapter storeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKstoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKcashboxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.BindingSource cashboxBindingSource;
        private kusachDataSetTableAdapters.cashboxTableAdapter cashboxTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKcashboxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.TextBox textBoxCategoreTitle;
        private System.Windows.Forms.TextBox textBoxCategoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRemoveBrand;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRemoveManufact;
        private System.Windows.Forms.Button buttonAddManufact;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonRemoveStock;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonRemoveShop;
        private System.Windows.Forms.Button buttonAddShop;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonRemoveShift;
        private System.Windows.Forms.Button buttonAddShift;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonRemoveChek;
        private System.Windows.Forms.Button buttonAddChek;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonRemoveStore;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonRemoveCashbox;
        private System.Windows.Forms.Button buttonAddCashbox;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox33;
    }
}