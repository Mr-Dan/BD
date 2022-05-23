
namespace BD.Forms
{
    partial class FormWarehouse
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
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.buttonProductClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProductDone = new System.Windows.Forms.Button();
            this.textBoxProductUnit = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.panelWarehouse = new System.Windows.Forms.Panel();
            this.buttonGetIdProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdProducts = new System.Windows.Forms.TextBox();
            this.buttonWarehouseClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWarehouseDone = new System.Windows.Forms.Button();
            this.textBoxCountProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewProductsGet = new System.Windows.Forms.DataGridView();
            this.dateTimePickerShelfLifeProduct = new System.Windows.Forms.DateTimePicker();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.panelProduct.SuspendLayout();
            this.panelWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsGet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.AllowUserToAddRows = false;
            this.dataGridViewWarehouse.AllowUserToDeleteRows = false;
            this.dataGridViewWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column1,
            this.Column2});
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.RowHeadersVisible = false;
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(1015, 266);
            this.dataGridViewWarehouse.TabIndex = 0;
            this.dataGridViewWarehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWarehouse_CellClick);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column3,
            this.Column4});
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 385);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.Size = new System.Drawing.Size(629, 266);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.Location = new System.Drawing.Point(466, 297);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(175, 23);
            this.buttonWarehouse.TabIndex = 4;
            this.buttonWarehouse.Text = "Добавить на склад товар";
            this.buttonWarehouse.UseVisualStyleBackColor = true;
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(134, 297);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(175, 23);
            this.buttonProduct.TabIndex = 5;
            this.buttonProduct.Text = "Добавить продукт";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelProduct.Controls.Add(this.buttonProductClose);
            this.panelProduct.Controls.Add(this.label2);
            this.panelProduct.Controls.Add(this.label1);
            this.panelProduct.Controls.Add(this.buttonProductDone);
            this.panelProduct.Controls.Add(this.textBoxProductUnit);
            this.panelProduct.Controls.Add(this.textBoxProductName);
            this.panelProduct.Location = new System.Drawing.Point(12, 326);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(297, 104);
            this.panelProduct.TabIndex = 6;
            this.panelProduct.Visible = false;
            // 
            // buttonProductClose
            // 
            this.buttonProductClose.Location = new System.Drawing.Point(272, 0);
            this.buttonProductClose.Name = "buttonProductClose";
            this.buttonProductClose.Size = new System.Drawing.Size(25, 20);
            this.buttonProductClose.TabIndex = 5;
            this.buttonProductClose.Text = "X";
            this.buttonProductClose.UseVisualStyleBackColor = true;
            this.buttonProductClose.Click += new System.EventHandler(this.buttonProductClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип измерения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // buttonProductDone
            // 
            this.buttonProductDone.Location = new System.Drawing.Point(191, 72);
            this.buttonProductDone.Name = "buttonProductDone";
            this.buttonProductDone.Size = new System.Drawing.Size(75, 23);
            this.buttonProductDone.TabIndex = 2;
            this.buttonProductDone.Text = "Добавить";
            this.buttonProductDone.UseVisualStyleBackColor = true;
            this.buttonProductDone.Click += new System.EventHandler(this.buttonProductDone_Click);
            // 
            // textBoxProductUnit
            // 
            this.textBoxProductUnit.Location = new System.Drawing.Point(94, 46);
            this.textBoxProductUnit.Name = "textBoxProductUnit";
            this.textBoxProductUnit.Size = new System.Drawing.Size(172, 20);
            this.textBoxProductUnit.TabIndex = 1;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(94, 20);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(172, 20);
            this.textBoxProductName.TabIndex = 0;
            // 
            // panelWarehouse
            // 
            this.panelWarehouse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelWarehouse.Controls.Add(this.dateTimePickerShelfLifeProduct);
            this.panelWarehouse.Controls.Add(this.buttonGetIdProduct);
            this.panelWarehouse.Controls.Add(this.label5);
            this.panelWarehouse.Controls.Add(this.textBoxIdProducts);
            this.panelWarehouse.Controls.Add(this.buttonWarehouseClose);
            this.panelWarehouse.Controls.Add(this.label3);
            this.panelWarehouse.Controls.Add(this.label4);
            this.panelWarehouse.Controls.Add(this.buttonWarehouseDone);
            this.panelWarehouse.Controls.Add(this.textBoxCountProduct);
            this.panelWarehouse.Location = new System.Drawing.Point(344, 326);
            this.panelWarehouse.Name = "panelWarehouse";
            this.panelWarehouse.Size = new System.Drawing.Size(311, 132);
            this.panelWarehouse.TabIndex = 7;
            this.panelWarehouse.Visible = false;
            // 
            // buttonGetIdProduct
            // 
            this.buttonGetIdProduct.Location = new System.Drawing.Point(177, 12);
            this.buttonGetIdProduct.Name = "buttonGetIdProduct";
            this.buttonGetIdProduct.Size = new System.Drawing.Size(69, 23);
            this.buttonGetIdProduct.TabIndex = 8;
            this.buttonGetIdProduct.Text = "Выбрать";
            this.buttonGetIdProduct.UseVisualStyleBackColor = true;
            this.buttonGetIdProduct.Click += new System.EventHandler(this.buttonGetIdProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "id продукта";
            // 
            // textBoxIdProducts
            // 
            this.textBoxIdProducts.Location = new System.Drawing.Point(89, 15);
            this.textBoxIdProducts.Name = "textBoxIdProducts";
            this.textBoxIdProducts.Size = new System.Drawing.Size(82, 20);
            this.textBoxIdProducts.TabIndex = 6;
            this.textBoxIdProducts.Click += new System.EventHandler(this.textBoxIdProducts_Click);
            // 
            // buttonWarehouseClose
            // 
            this.buttonWarehouseClose.Location = new System.Drawing.Point(681, 0);
            this.buttonWarehouseClose.Name = "buttonWarehouseClose";
            this.buttonWarehouseClose.Size = new System.Drawing.Size(25, 20);
            this.buttonWarehouseClose.TabIndex = 5;
            this.buttonWarehouseClose.Text = "X";
            this.buttonWarehouseClose.UseVisualStyleBackColor = true;
            this.buttonWarehouseClose.Click += new System.EventHandler(this.buttonWarehouseClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Срок годности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Колличество";
            // 
            // buttonWarehouseDone
            // 
            this.buttonWarehouseDone.Location = new System.Drawing.Point(214, 99);
            this.buttonWarehouseDone.Name = "buttonWarehouseDone";
            this.buttonWarehouseDone.Size = new System.Drawing.Size(75, 23);
            this.buttonWarehouseDone.TabIndex = 2;
            this.buttonWarehouseDone.Text = "Добавить";
            this.buttonWarehouseDone.UseVisualStyleBackColor = true;
            this.buttonWarehouseDone.Click += new System.EventHandler(this.buttonWarehouseDone_Click);
            // 
            // textBoxCountProduct
            // 
            this.textBoxCountProduct.Location = new System.Drawing.Point(89, 44);
            this.textBoxCountProduct.Name = "textBoxCountProduct";
            this.textBoxCountProduct.Size = new System.Drawing.Size(172, 20);
            this.textBoxCountProduct.TabIndex = 0;
            // 
            // dataGridViewProductsGet
            // 
            this.dataGridViewProductsGet.AllowUserToAddRows = false;
            this.dataGridViewProductsGet.AllowUserToDeleteRows = false;
            this.dataGridViewProductsGet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductsGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductsGet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridViewProductsGet.Location = new System.Drawing.Point(661, 326);
            this.dataGridViewProductsGet.Name = "dataGridViewProductsGet";
            this.dataGridViewProductsGet.ReadOnly = true;
            this.dataGridViewProductsGet.RowHeadersVisible = false;
            this.dataGridViewProductsGet.Size = new System.Drawing.Size(380, 266);
            this.dataGridViewProductsGet.TabIndex = 8;
            this.dataGridViewProductsGet.Visible = false;
            this.dataGridViewProductsGet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductsGet_CellClick);
            // 
            // dateTimePickerShelfLifeProduct
            // 
            this.dateTimePickerShelfLifeProduct.Location = new System.Drawing.Point(89, 73);
            this.dateTimePickerShelfLifeProduct.Name = "dateTimePickerShelfLifeProduct";
            this.dateTimePickerShelfLifeProduct.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerShelfLifeProduct.TabIndex = 9;
            this.dateTimePickerShelfLifeProduct.Value = new System.DateTime(2022, 5, 17, 0, 45, 4, 0);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "id продукта";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Колличество";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Срок годности";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Название продукта";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ед.";
            this.Column10.Name = "Column10";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Update";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "delete";
            this.Column2.Name = "Column2";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "id";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Название";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Колличество";
            this.Column13.Name = "Column13";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Update";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Delete";
            this.Column4.Name = "Column4";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "id";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Название";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Колличество";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // FormWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 675);
            this.Controls.Add(this.dataGridViewProductsGet);
            this.Controls.Add(this.panelWarehouse);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonWarehouse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.Name = "FormWarehouse";
            this.Text = "FormWarehouse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelWarehouse.ResumeLayout(false);
            this.panelWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductsGet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Button buttonProductClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProductDone;
        private System.Windows.Forms.TextBox textBoxProductUnit;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Panel panelWarehouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdProducts;
        private System.Windows.Forms.Button buttonWarehouseClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonWarehouseDone;
        private System.Windows.Forms.TextBox textBoxCountProduct;
        private System.Windows.Forms.Button buttonGetIdProduct;
        private System.Windows.Forms.DataGridView dataGridViewProductsGet;
        private System.Windows.Forms.DateTimePicker dateTimePickerShelfLifeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
    }
}