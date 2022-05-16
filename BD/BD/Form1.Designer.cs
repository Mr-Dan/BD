
namespace BD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonPersons = new System.Windows.Forms.Button();
            this.buttonSql = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.buttonRecipe = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(984, 60);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(209, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(745, 20);
            this.labelTitle.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.buttonPersons);
            this.panelMenu.Controls.Add(this.buttonSql);
            this.panelMenu.Controls.Add(this.buttonWarehouse);
            this.panelMenu.Controls.Add(this.buttonRecipe);
            this.panelMenu.Controls.Add(this.buttonOrder);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 602);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.Location = new System.Drawing.Point(0, 250);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(200, 50);
            this.buttonOrders.TabIndex = 7;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 552);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "Войти";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // buttonPersons
            // 
            this.buttonPersons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonPersons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPersons.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPersons.FlatAppearance.BorderSize = 0;
            this.buttonPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersons.ForeColor = System.Drawing.Color.White;
            this.buttonPersons.Location = new System.Drawing.Point(0, 200);
            this.buttonPersons.Name = "buttonPersons";
            this.buttonPersons.Size = new System.Drawing.Size(200, 50);
            this.buttonPersons.TabIndex = 5;
            this.buttonPersons.Text = "Сотрудники";
            this.buttonPersons.UseVisualStyleBackColor = false;
            this.buttonPersons.Click += new System.EventHandler(this.buttonPersons_Click);
            // 
            // buttonSql
            // 
            this.buttonSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonSql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSql.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSql.FlatAppearance.BorderSize = 0;
            this.buttonSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSql.ForeColor = System.Drawing.Color.White;
            this.buttonSql.Location = new System.Drawing.Point(0, 150);
            this.buttonSql.Name = "buttonSql";
            this.buttonSql.Size = new System.Drawing.Size(200, 50);
            this.buttonSql.TabIndex = 4;
            this.buttonSql.Text = "SQL-Запрос";
            this.buttonSql.UseVisualStyleBackColor = false;
            this.buttonSql.Click += new System.EventHandler(this.buttonSql_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonWarehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonWarehouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWarehouse.FlatAppearance.BorderSize = 0;
            this.buttonWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWarehouse.ForeColor = System.Drawing.Color.White;
            this.buttonWarehouse.Location = new System.Drawing.Point(0, 100);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(200, 50);
            this.buttonWarehouse.TabIndex = 3;
            this.buttonWarehouse.Text = "Склад";
            this.buttonWarehouse.UseVisualStyleBackColor = false;
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // buttonRecipe
            // 
            this.buttonRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonRecipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRecipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecipe.FlatAppearance.BorderSize = 0;
            this.buttonRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecipe.ForeColor = System.Drawing.Color.White;
            this.buttonRecipe.Location = new System.Drawing.Point(0, 50);
            this.buttonRecipe.Name = "buttonRecipe";
            this.buttonRecipe.Size = new System.Drawing.Size(200, 50);
            this.buttonRecipe.TabIndex = 2;
            this.buttonRecipe.Text = "Рецепты";
            this.buttonRecipe.UseVisualStyleBackColor = false;
            this.buttonRecipe.Click += new System.EventHandler(this.buttonRecipe_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.buttonOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.ForeColor = System.Drawing.Color.White;
            this.buttonOrder.Location = new System.Drawing.Point(0, 0);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(200, 50);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Сделать заказ";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 60);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(784, 602);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTitle.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonRecipe;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonPersons;
        private System.Windows.Forms.Button buttonSql;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button button1;
    }
}

