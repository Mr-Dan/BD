
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelDish = new System.Windows.Forms.Panel();
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
            this.buttonRecipeDone = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRecipe = new System.Windows.Forms.Panel();
            this.buttonRecipeClose = new System.Windows.Forms.Button();
            this.buttonProductClose = new System.Windows.Forms.Button();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonDishAdd = new System.Windows.Forms.Button();
            this.buttonDishClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).BeginInit();
            this.panelDish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelProduct.SuspendLayout();
            this.panelRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 293);
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
            this.Column6,
            this.Column7});
            this.dataGridViewRecipe.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRecipe.Name = "dataGridViewRecipe";
            this.dataGridViewRecipe.Size = new System.Drawing.Size(543, 247);
            this.dataGridViewRecipe.TabIndex = 1;
            this.dataGridViewRecipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipe_CellClick);
            this.dataGridViewRecipe.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
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
            // Column6
            // 
            this.Column6.HeaderText = "Колличество";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Delete";
            this.Column7.Name = "Column7";
            // 
            // panelDish
            // 
            this.panelDish.BackColor = System.Drawing.SystemColors.ButtonShadow;
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
            this.panelDish.Location = new System.Drawing.Point(235, 293);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(315, 165);
            this.panelDish.TabIndex = 3;
            this.panelDish.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Фото";
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(102, 104);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(195, 20);
            this.textBoxImage.TabIndex = 7;
            // 
            // buttonDishDone
            // 
            this.buttonDishDone.Location = new System.Drawing.Point(6, 130);
            this.buttonDishDone.Name = "buttonDishDone";
            this.buttonDishDone.Size = new System.Drawing.Size(149, 23);
            this.buttonDishDone.TabIndex = 6;
            this.buttonDishDone.Text = "Добавить блюдо";
            this.buttonDishDone.UseVisualStyleBackColor = true;
            this.buttonDishDone.Click += new System.EventHandler(this.buttonDishDone_Click);
            // 
            // textBoxCostDish
            // 
            this.textBoxCostDish.Location = new System.Drawing.Point(102, 78);
            this.textBoxCostDish.Name = "textBoxCostDish";
            this.textBoxCostDish.Size = new System.Drawing.Size(195, 20);
            this.textBoxCostDish.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время готовки";
            // 
            // textBoxReadytTmeDish
            // 
            this.textBoxReadytTmeDish.Location = new System.Drawing.Point(102, 52);
            this.textBoxReadytTmeDish.Name = "textBoxReadytTmeDish";
            this.textBoxReadytTmeDish.Size = new System.Drawing.Size(195, 20);
            this.textBoxReadytTmeDish.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название Блюда";
            // 
            // textBoxDishName
            // 
            this.textBoxDishName.Location = new System.Drawing.Point(102, 26);
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
            this.Column4,
            this.Column5});
            this.dataGridViewDish.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDish.Name = "dataGridViewDish";
            this.dataGridViewDish.RowHeadersVisible = false;
            this.dataGridViewDish.RowHeadersWidth = 40;
            this.dataGridViewDish.Size = new System.Drawing.Size(1093, 275);
            this.dataGridViewDish.TabIndex = 4;
            this.dataGridViewDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDish_CellClick);
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
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.Size = new System.Drawing.Size(436, 285);
            this.dataGridViewProduct.TabIndex = 7;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelProduct.Controls.Add(this.buttonProductClose);
            this.panelProduct.Controls.Add(this.dataGridViewProduct);
            this.panelProduct.Location = new System.Drawing.Point(660, 322);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(436, 292);
            this.panelProduct.TabIndex = 9;
            this.panelProduct.Visible = false;
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
            // panelRecipe
            // 
            this.panelRecipe.Controls.Add(this.buttonRecipeClose);
            this.panelRecipe.Controls.Add(this.dataGridViewRecipe);
            this.panelRecipe.Controls.Add(this.buttonRecipeDone);
            this.panelRecipe.Location = new System.Drawing.Point(12, 322);
            this.panelRecipe.Name = "panelRecipe";
            this.panelRecipe.Size = new System.Drawing.Size(548, 287);
            this.panelRecipe.TabIndex = 10;
            this.panelRecipe.Visible = false;
            // 
            // buttonRecipeClose
            // 
            this.buttonRecipeClose.Location = new System.Drawing.Point(513, 3);
            this.buttonRecipeClose.Name = "buttonRecipeClose";
            this.buttonRecipeClose.Size = new System.Drawing.Size(32, 23);
            this.buttonRecipeClose.TabIndex = 9;
            this.buttonRecipeClose.Text = "X";
            this.buttonRecipeClose.UseVisualStyleBackColor = true;
            this.buttonRecipeClose.Click += new System.EventHandler(this.buttonRecipeClose_Click);
            // 
            // buttonProductClose
            // 
            this.buttonProductClose.Location = new System.Drawing.Point(404, 1);
            this.buttonProductClose.Name = "buttonProductClose";
            this.buttonProductClose.Size = new System.Drawing.Size(32, 23);
            this.buttonProductClose.TabIndex = 9;
            this.buttonProductClose.Text = "X";
            this.buttonProductClose.UseVisualStyleBackColor = true;
            this.buttonProductClose.Click += new System.EventHandler(this.buttonProductClose_Click);
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
            // buttonDishAdd
            // 
            this.buttonDishAdd.Location = new System.Drawing.Point(94, 293);
            this.buttonDishAdd.Name = "buttonDishAdd";
            this.buttonDishAdd.Size = new System.Drawing.Size(135, 23);
            this.buttonDishAdd.TabIndex = 11;
            this.buttonDishAdd.Text = "Добавить блюдо";
            this.buttonDishAdd.UseVisualStyleBackColor = true;
            this.buttonDishAdd.Click += new System.EventHandler(this.buttonDishAdd_Click);
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
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 634);
            this.Controls.Add(this.buttonDishAdd);
            this.Controls.Add(this.panelRecipe);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.dataGridViewDish);
            this.Controls.Add(this.panelDish);
            this.Controls.Add(this.button1);
            this.Name = "FormRecipe";
            this.Text = "FormRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).EndInit();
            this.panelDish.ResumeLayout(false);
            this.panelDish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelRecipe.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button buttonDishClose;
        private System.Windows.Forms.Button buttonDishAdd;
    }
}