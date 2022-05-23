
namespace BD.Forms
{
    partial class FormRecipe
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRecipe = new System.Windows.Forms.DataGridView();
            this.panelDish = new System.Windows.Forms.Panel();
            this.textBoxTypeDish = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDishClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.buttonDishDone = new System.Windows.Forms.Button();
            this.textBoxCostDish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReadytTmeDish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDishName = new System.Windows.Forms.TextBox();
            this.dataGridViewDish = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRecipeDone = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonProductClose = new System.Windows.Forms.Button();
            this.panelRecipe = new System.Windows.Forms.Panel();
            this.buttonRecipeClose = new System.Windows.Forms.Button();
            this.buttonDishAdd = new System.Windows.Forms.Button();
            this.buttonCostUp = new System.Windows.Forms.Button();
            this.buttonCostDown = new System.Windows.Forms.Button();
            this.textBoxPercentage = new System.Windows.Forms.TextBox();
            this.panelCost = new System.Windows.Forms.Panel();
            this.buttonCostClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTypeDish = new System.Windows.Forms.ComboBox();
            this.buttonCost = new System.Windows.Forms.Button();
            this.buttonSortDish = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).BeginInit();
            this.panelDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelProduct.SuspendLayout();
            this.panelRecipe.SuspendLayout();
            this.panelCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewRecipe
            // 
            this.dataGridViewRecipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column18,
            this.Column6,
            this.Column19,
            this.Column7});
            this.dataGridViewRecipe.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRecipe.Name = "dataGridViewRecipe";
            this.dataGridViewRecipe.Size = new System.Drawing.Size(615, 247);
            this.dataGridViewRecipe.TabIndex = 1;
            this.dataGridViewRecipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipe_CellClick);
            this.dataGridViewRecipe.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // panelDish
            // 
            this.panelDish.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelDish.Controls.Add(this.textBoxTypeDish);
            this.panelDish.Controls.Add(this.label5);
            this.panelDish.Controls.Add(this.buttonDishClose);
            this.panelDish.Controls.Add(this.label4);
            this.panelDish.Controls.Add(this.textBoxImage);
            this.panelDish.Controls.Add(this.buttonDishDone);
            this.panelDish.Controls.Add(this.textBoxCostDish);
            this.panelDish.Controls.Add(this.label3);
            this.panelDish.Controls.Add(this.label2);
            this.panelDish.Controls.Add(this.textBoxReadytTmeDish);
            this.panelDish.Controls.Add(this.label1);
            this.panelDish.Controls.Add(this.textBoxDishName);
            this.panelDish.Location = new System.Drawing.Point(94, 327);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(315, 165);
            this.panelDish.TabIndex = 3;
            this.panelDish.Visible = false;
            // 
            // textBoxTypeDish
            // 
            this.textBoxTypeDish.Location = new System.Drawing.Point(102, 122);
            this.textBoxTypeDish.Name = "textBoxTypeDish";
            this.textBoxTypeDish.Size = new System.Drawing.Size(195, 20);
            this.textBoxTypeDish.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип блюда";
            // 
            // buttonDishClose
            // 
            this.buttonDishClose.Location = new System.Drawing.Point(287, 0);
            this.buttonDishClose.Name = "buttonDishClose";
            this.buttonDishClose.Size = new System.Drawing.Size(25, 23);
            this.buttonDishClose.TabIndex = 9;
            this.buttonDishClose.Text = "X";
            this.buttonDishClose.UseVisualStyleBackColor = true;
            this.buttonDishClose.Click += new System.EventHandler(this.buttonDishClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фото";
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(102, 99);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(195, 20);
            this.textBoxImage.TabIndex = 7;
            // 
            // buttonDishDone
            // 
            this.buttonDishDone.Location = new System.Drawing.Point(166, 142);
            this.buttonDishDone.Name = "buttonDishDone";
            this.buttonDishDone.Size = new System.Drawing.Size(149, 23);
            this.buttonDishDone.TabIndex = 6;
            this.buttonDishDone.Text = "Добавить блюдо";
            this.buttonDishDone.UseVisualStyleBackColor = true;
            this.buttonDishDone.Click += new System.EventHandler(this.buttonDishDone_Click);
            // 
            // textBoxCostDish
            // 
            this.textBoxCostDish.Location = new System.Drawing.Point(102, 73);
            this.textBoxCostDish.Name = "textBoxCostDish";
            this.textBoxCostDish.Size = new System.Drawing.Size(195, 20);
            this.textBoxCostDish.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время готовки";
            // 
            // textBoxReadytTmeDish
            // 
            this.textBoxReadytTmeDish.Location = new System.Drawing.Point(102, 47);
            this.textBoxReadytTmeDish.Name = "textBoxReadytTmeDish";
            this.textBoxReadytTmeDish.Size = new System.Drawing.Size(195, 20);
            this.textBoxReadytTmeDish.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название Блюда";
            // 
            // textBoxDishName
            // 
            this.textBoxDishName.Location = new System.Drawing.Point(102, 21);
            this.textBoxDishName.Name = "textBoxDishName";
            this.textBoxDishName.Size = new System.Drawing.Size(195, 20);
            this.textBoxDishName.TabIndex = 0;
            // 
            // dataGridViewDish
            // 
            this.dataGridViewDish.AllowUserToAddRows = false;
            this.dataGridViewDish.AllowUserToDeleteRows = false;
            this.dataGridViewDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column4,
            this.Column5});
            this.dataGridViewDish.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewDish.Name = "dataGridViewDish";
            this.dataGridViewDish.RowHeadersVisible = false;
            this.dataGridViewDish.RowHeadersWidth = 40;
            this.dataGridViewDish.Size = new System.Drawing.Size(1093, 275);
            this.dataGridViewDish.TabIndex = 4;
            this.dataGridViewDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDish_CellClick);
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
            this.Column13.HeaderText = "Время приготовления";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Цена";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Фото";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Тип блюда";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "В наличии";
            this.Column17.Name = "Column17";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "update";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "delete";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonRecipeDone
            // 
            this.buttonRecipeDone.Location = new System.Drawing.Point(0, 259);
            this.buttonRecipeDone.Name = "buttonRecipeDone";
            this.buttonRecipeDone.Size = new System.Drawing.Size(233, 23);
            this.buttonRecipeDone.TabIndex = 5;
            this.buttonRecipeDone.Text = "Добавить/Обновить ингридиенты";
            this.buttonRecipeDone.UseVisualStyleBackColor = true;
            this.buttonRecipeDone.Click += new System.EventHandler(this.buttonRecipeDone_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.Size = new System.Drawing.Size(436, 285);
            this.dataGridViewProduct.TabIndex = 7;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "id";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Название";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ед.";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelProduct.Controls.Add(this.textBox1);
            this.panelProduct.Controls.Add(this.buttonProductClose);
            this.panelProduct.Controls.Add(this.dataGridViewProduct);
            this.panelProduct.Location = new System.Drawing.Point(660, 337);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(436, 321);
            this.panelProduct.TabIndex = 9;
            this.panelProduct.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonProductClose
            // 
            this.buttonProductClose.Location = new System.Drawing.Point(404, 0);
            this.buttonProductClose.Name = "buttonProductClose";
            this.buttonProductClose.Size = new System.Drawing.Size(32, 23);
            this.buttonProductClose.TabIndex = 9;
            this.buttonProductClose.Text = "X";
            this.buttonProductClose.UseVisualStyleBackColor = true;
            this.buttonProductClose.Click += new System.EventHandler(this.buttonProductClose_Click);
            // 
            // panelRecipe
            // 
            this.panelRecipe.Controls.Add(this.buttonRecipeClose);
            this.panelRecipe.Controls.Add(this.dataGridViewRecipe);
            this.panelRecipe.Controls.Add(this.buttonRecipeDone);
            this.panelRecipe.Location = new System.Drawing.Point(12, 337);
            this.panelRecipe.Name = "panelRecipe";
            this.panelRecipe.Size = new System.Drawing.Size(621, 287);
            this.panelRecipe.TabIndex = 10;
            this.panelRecipe.Visible = false;
            // 
            // buttonRecipeClose
            // 
            this.buttonRecipeClose.Location = new System.Drawing.Point(586, 3);
            this.buttonRecipeClose.Name = "buttonRecipeClose";
            this.buttonRecipeClose.Size = new System.Drawing.Size(32, 23);
            this.buttonRecipeClose.TabIndex = 9;
            this.buttonRecipeClose.Text = "X";
            this.buttonRecipeClose.UseVisualStyleBackColor = true;
            this.buttonRecipeClose.Click += new System.EventHandler(this.buttonRecipeClose_Click);
            // 
            // buttonDishAdd
            // 
            this.buttonDishAdd.Location = new System.Drawing.Point(94, 308);
            this.buttonDishAdd.Name = "buttonDishAdd";
            this.buttonDishAdd.Size = new System.Drawing.Size(135, 23);
            this.buttonDishAdd.TabIndex = 11;
            this.buttonDishAdd.Text = "Добавить блюдо";
            this.buttonDishAdd.UseVisualStyleBackColor = true;
            this.buttonDishAdd.Click += new System.EventHandler(this.buttonDishAdd_Click);
            // 
            // buttonCostUp
            // 
            this.buttonCostUp.Location = new System.Drawing.Point(18, 60);
            this.buttonCostUp.Name = "buttonCostUp";
            this.buttonCostUp.Size = new System.Drawing.Size(118, 23);
            this.buttonCostUp.TabIndex = 12;
            this.buttonCostUp.Text = "Повысить цену на %";
            this.buttonCostUp.UseVisualStyleBackColor = true;
            this.buttonCostUp.Click += new System.EventHandler(this.buttonCostUp_Click);
            // 
            // buttonCostDown
            // 
            this.buttonCostDown.Location = new System.Drawing.Point(162, 60);
            this.buttonCostDown.Name = "buttonCostDown";
            this.buttonCostDown.Size = new System.Drawing.Size(127, 23);
            this.buttonCostDown.TabIndex = 13;
            this.buttonCostDown.Text = "Понизить цену на %";
            this.buttonCostDown.UseVisualStyleBackColor = true;
            this.buttonCostDown.Click += new System.EventHandler(this.buttonCostDown_Click);
            // 
            // textBoxPercentage
            // 
            this.textBoxPercentage.Location = new System.Drawing.Point(162, 34);
            this.textBoxPercentage.MaxLength = 3;
            this.textBoxPercentage.Name = "textBoxPercentage";
            this.textBoxPercentage.Size = new System.Drawing.Size(100, 20);
            this.textBoxPercentage.TabIndex = 14;
            // 
            // panelCost
            // 
            this.panelCost.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCost.Controls.Add(this.buttonCostClose);
            this.panelCost.Controls.Add(this.label7);
            this.panelCost.Controls.Add(this.label6);
            this.panelCost.Controls.Add(this.comboBoxTypeDish);
            this.panelCost.Controls.Add(this.buttonCostUp);
            this.panelCost.Controls.Add(this.textBoxPercentage);
            this.panelCost.Controls.Add(this.buttonCostDown);
            this.panelCost.Location = new System.Drawing.Point(681, 320);
            this.panelCost.Name = "panelCost";
            this.panelCost.Size = new System.Drawing.Size(307, 100);
            this.panelCost.TabIndex = 15;
            this.panelCost.Visible = false;
            // 
            // buttonCostClose
            // 
            this.buttonCostClose.Location = new System.Drawing.Point(276, 1);
            this.buttonCostClose.Name = "buttonCostClose";
            this.buttonCostClose.Size = new System.Drawing.Size(31, 23);
            this.buttonCostClose.TabIndex = 18;
            this.buttonCostClose.Text = "X";
            this.buttonCostClose.UseVisualStyleBackColor = true;
            this.buttonCostClose.Click += new System.EventHandler(this.buttonCostClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Процент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Категория";
            // 
            // comboBoxTypeDish
            // 
            this.comboBoxTypeDish.FormattingEnabled = true;
            this.comboBoxTypeDish.Location = new System.Drawing.Point(18, 31);
            this.comboBoxTypeDish.Name = "comboBoxTypeDish";
            this.comboBoxTypeDish.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeDish.TabIndex = 15;
            // 
            // buttonCost
            // 
            this.buttonCost.Location = new System.Drawing.Point(681, 299);
            this.buttonCost.Name = "buttonCost";
            this.buttonCost.Size = new System.Drawing.Size(191, 23);
            this.buttonCost.TabIndex = 16;
            this.buttonCost.Text = "Повысить/понизить цену";
            this.buttonCost.UseVisualStyleBackColor = true;
            this.buttonCost.Click += new System.EventHandler(this.buttonCost_Click);
            // 
            // buttonSortDish
            // 
            this.buttonSortDish.Location = new System.Drawing.Point(15, 2);
            this.buttonSortDish.Name = "buttonSortDish";
            this.buttonSortDish.Size = new System.Drawing.Size(120, 23);
            this.buttonSortDish.TabIndex = 21;
            this.buttonSortDish.Text = "Сортировать по";
            this.buttonSortDish.UseVisualStyleBackColor = true;
            this.buttonSortDish.Click += new System.EventHandler(this.buttonSortDish_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Название",
            "Время приготовления",
            "Цена",
            "Тип блюда"});
            this.comboBox1.Location = new System.Drawing.Point(141, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Название",
            "Время приготовления",
            "Цена",
            "Тип блюда"});
            this.comboBox2.Location = new System.Drawing.Point(268, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Название",
            "Время приготовления",
            "Цена",
            "Тип блюда"});
            this.comboBox3.Location = new System.Drawing.Point(395, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Название",
            "Время приготовления",
            "Цена",
            "Тип блюда"});
            this.comboBox4.Location = new System.Drawing.Point(525, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id блюда";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id продукта";
            this.Column2.Name = "Column2";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Имя продукта";
            this.Column18.Name = "Column18";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Колличество";
            this.Column6.Name = "Column6";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "ед.";
            this.Column19.Name = "Column19";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.Name = "Column7";
            // 
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 657);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSortDish);
            this.Controls.Add(this.buttonCost);
            this.Controls.Add(this.panelCost);
            this.Controls.Add(this.buttonDishAdd);
            this.Controls.Add(this.panelRecipe);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelDish);
            this.Controls.Add(this.dataGridViewDish);
            this.Controls.Add(this.button1);
            this.Name = "FormRecipe";
            this.Text = "FormRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).EndInit();
            this.panelDish.ResumeLayout(false);
            this.panelDish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelRecipe.ResumeLayout(false);
            this.panelCost.ResumeLayout(false);
            this.panelCost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewRecipe;
        private System.Windows.Forms.Panel panelDish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReadytTmeDish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDishName;
        private System.Windows.Forms.Button buttonDishDone;
        private System.Windows.Forms.TextBox textBoxCostDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDish;
        private System.Windows.Forms.Button buttonRecipeDone;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button buttonProductClose;
        private System.Windows.Forms.Panel panelRecipe;
        private System.Windows.Forms.Button buttonRecipeClose;
        private System.Windows.Forms.Button buttonDishClose;
        private System.Windows.Forms.Button buttonDishAdd;
        private System.Windows.Forms.TextBox textBoxTypeDish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCostUp;
        private System.Windows.Forms.Button buttonCostDown;
        private System.Windows.Forms.TextBox textBoxPercentage;
        private System.Windows.Forms.Panel panelCost;
        private System.Windows.Forms.Button buttonCostClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTypeDish;
        private System.Windows.Forms.Button buttonCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSortDish;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}